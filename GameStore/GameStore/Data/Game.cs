namespace GameStore.Data
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int GenreId { get; set; } // Жанр
        public int CategoriesId { get; set; } // Категория

    }
}
