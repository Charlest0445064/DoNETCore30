namespace Identity.Models
{
    public class District
    {
        public int DistrictId { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }

        // 用來關聯 City
        public virtual City City { get; set; }
    }
}
