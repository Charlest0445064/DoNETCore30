using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCApp.Dtos;
using MVCApp.Models;
using MVCApp.Filter;

namespace MVCApp.Controllers
{
   
    public class NewsController : Controller
    {
        private readonly KcgContext _context;

        public NewsController(KcgContext context)
        {
            _context = context;
        }


        // GET: News
        
        public async Task<IActionResult> Index()
        {
            var q = from news in _context.News
                    join dep in _context.Department on news.DepartmentId equals dep.DepartmentId
                    join emp in _context.Employee on news.UpdateEmployeeId equals emp.EmployeeId
                    select new NewsDto
                    {
                        NewsId = news.NewsId,
                        Title = news.Title,
                        DepartmentName = dep.Name,
                        StartDateTime = news.StartDateTime,
                        EndDateTime = news.EndDateTime,
                        UpdateDateTime = news.InsertDateTime,
                        
                        Click = news.Click,
                        Enable = news.Enable,
                        UpdateEmployeeName = emp.Name,
                        
                    };
            return View(await q.ToListAsync());
        }

        // GET: News/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .FirstOrDefaultAsync(m => m.NewsId == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        [HttpGet]
        public IActionResult Create()
        {
            NewsCreateDto newsCreateDto = new NewsCreateDto();
            newsCreateDto.DepList = _context.Department.ToList();
            return View(newsCreateDto);
        }

        // POST: News/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]       
        public async Task<IActionResult> Create(NewsCreateDto news)
        {          

            if (ModelState.IsValid)
            {
                News insert = new News()
                {
                    Title = news.Title,
                    Contents = news.Contents,
                    DepartmentId = news.DepartmentId,
                    StartDateTime = news.StartDateTime,
                    EndDateTime = (DateTime) news.EndDateTime,
                    Click = 0,
                    Enable = true,
                    InsertEmployeeId = 1,
                    UpdateEmployeeId = 1
                };
              
                _context.News.Add(insert);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(news);
        }

        // GET: News/Edit/5\
        [HttpGet]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await (from a in _context.News
                              where a.NewsId == id
                              select new NewsEditDto
                              {
                                  EndDateTime = a.EndDateTime,
                                  NewsId = a.NewsId,
                                  StartDateTime = a.StartDateTime,
                                  Title = a.Title,
                                  Contents = a.Contents,
                                  DepartmentId = a.DepartmentId
                              }).SingleOrDefaultAsync();
            if (news == null)
            {
                return NotFound();
            }
            return View(news);
        }

        // POST: News/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, NewsEditDto news)
        {
            if (id != news.NewsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var update = _context.News.Find(news.NewsId);

                if (update != null)
                {
                    update.Title = news.Title;
                    update.Contents = news.Contents;
                    update.DepartmentId = news.DepartmentId;
                    update.StartDateTime = news.StartDateTime;
                    update.EndDateTime = news.EndDateTime;
                    update.Enable = news.Enable;

                    update.UpdateEmployeeId = 1;
                    update.UpdateDateTime = DateTime.Now;

                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
            }
            return View(news);
        }

        // GET: News/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .FirstOrDefaultAsync(m => m.NewsId == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // POST: News/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var news = await _context.News.FindAsync(id);
            if (news != null)
            {
                _context.News.Remove(news);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewsExists(Guid id)
        {
            return _context.News.Any(e => e.NewsId == id);
        }
    }
}
