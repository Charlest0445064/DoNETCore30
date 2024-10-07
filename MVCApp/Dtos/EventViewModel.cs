using System.ComponentModel.DataAnnotations;

namespace MVCApp.Dtos
{
    public class EventViewModel
    {
        [Display(Name = "Event Date")]
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }
    }
}
