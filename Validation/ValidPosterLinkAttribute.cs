using System.ComponentModel.DataAnnotations;

namespace film_site.Validation
{
    public class ValidPosterLinkAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
                return ValidationResult.Success;

            if (value is not string url)
                return new ValidationResult("Некорректный формат ссылки.");

            if (!Uri.TryCreate(url, UriKind.Absolute, out Uri? uriResult) ||
                (uriResult.Scheme != Uri.UriSchemeHttp &&
                 uriResult.Scheme != Uri.UriSchemeHttps))
            {
                return new ValidationResult("Введите корректную ссылку (http/https).");
            }

            string extension = Path.GetExtension(uriResult.AbsolutePath).ToLower();

            string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".webp", ".gif" };

            if (!Array.Exists(allowedExtensions, e => e == extension))
            {
                return new ValidationResult("Ссылка должна вести на изображение (.jpg, .png, .webp и т.д.)");
            }

            return ValidationResult.Success;

        }
    }
}
