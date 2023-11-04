namespace TanksApi.Models
{
    public class Nation
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Tank> Tanks { get; set; }
    }
}
