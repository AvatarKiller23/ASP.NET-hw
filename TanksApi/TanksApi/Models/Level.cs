namespace TanksApi.Models
{
    public class Level
    {
        public int Id { get; set; }
        public short TankLevel { get; set; }
        
        public ICollection<Tank> Tanks { get; set; }
    }
}
