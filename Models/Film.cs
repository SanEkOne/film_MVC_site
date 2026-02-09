using System.ComponentModel;

namespace mvc
{
    public class Film
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Название")]
        public string? Name { get; set; }

        [DisplayName("Режиссер")]
        public string? Director { get; set; }

        [DisplayName("Жанр")]
        public string? Genre { get; set; }

        [DisplayName("Год выпуска")]
        public int Year { get; set; }

        [DisplayName("Постер")]
        public string? Poster { get; set; }

        [DisplayName("Описание")]
        public string? Description { get; set; }

        [DisplayName("Ссылка на трейлер")]
        public string? TrailerLink { get; set; }
    }
}