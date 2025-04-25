using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bookify.Web.Core.ViewModels
{
    public class BookFormViewModel
    {
        public int Id { get; set; }

        [MaxLength(500, ErrorMessage =Errors.MaxLength)]
        public string Title { get; set; } = null!;

        [Display(Name = "Author")]
        public int AuthorId { get; set; }
        public IEnumerable<SelectListItem>? Authors { get; set; } = null!;

        [MaxLength(200, ErrorMessage = Errors.MaxLength)]
        public string Publisher { get; set; } = null!;

        [Display(Name = "Publishing Date")]
        public DateTime PubllishingDate { get; set; } = DateTime.Now;



        public IFormFile? Image { get; set; }
        public string? ImageURL { get; set; }


        [MaxLength(50, ErrorMessage = Errors.MaxLength)]
        public string Hall { get; set; } = null!;

        [Display(Name = "Is Available For Rental?")]
        public bool IsAvailableForRental { get; set; }

        public string Discription { get; set; } = null!;


        [Display(Name = "Categories")]
        public IList<int> SelectedCategories { get; set; } = new List<int>();

        public IEnumerable<SelectListItem>? Categories { get; set; } = null!;

    }
}
