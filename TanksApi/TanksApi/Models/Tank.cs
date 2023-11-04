namespace TanksApi.Models
{
    public class Tank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public int NationId { get; set; }
        public Nation Nation { get; set; }

        public int LevelId { get; set; }
        public Level Level { get; set; }
    }
}
