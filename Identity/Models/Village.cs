namespace Identity.Models
{
    public class Village
    {
        public int VillageId { get; set; }
        public string Name { get; set; }
        public int DistrictId { get; set; }

        // 用來關聯 District
        public virtual District District { get; set; }
    }
}
