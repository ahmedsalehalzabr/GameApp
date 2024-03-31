using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace GameZone.ViewModels
{
    public class CreateGameFormVM
    {
        [MaxLength(250)]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; } = Enumerable.Empty<SelectListItem>();

        public IEnumerable<SelectListItem> Devices { get; set; } = Enumerable.Empty<SelectListItem>();

        [Display(Name = "Supported Devices")]
        public List<int> SelectedDevices { get; set; } = new List<int>();

        public IFormFile Cover { get; set; } = default!;

        [MaxLength(250)]
        public string Description { get; set; } = string.Empty;
    }
}
