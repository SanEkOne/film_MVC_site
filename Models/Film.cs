using film_site.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mvc
{
    public class Film
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Название")]
        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        public string? Name { get; set; }

        [DisplayName("Режиссер")]
        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        public string? Director { get; set; }

        [DisplayName("Жанр")]
        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        public string? Genre { get; set; }

        [DisplayName("Год выпуска")]
        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        [Range(1895, 2033, ErrorMessage = "Не корректный год!")]
        public int Year { get; set; }

        [DisplayName("Постер")]
        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        [ValidPosterLink]
        public string? Poster { get; set; }

        [DisplayName("Описание")]
        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        public string? Description { get; set; }

        [DisplayName("Ссылка на трейлер")]
        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        [Url(ErrorMessage = "Введите корректный URL!")]
        public string? TrailerLink { get; set; }
    }
}