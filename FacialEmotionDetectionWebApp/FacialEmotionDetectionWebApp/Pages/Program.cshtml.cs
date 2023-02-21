using FacialEmotionDetectionWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FacialEmotionDetectionWebApp.Pages
{
    public class ProgramModel : PageModel
    {
        [BindProperty]
        public Image image { get; set; }
        public void OnGet()
        {
        }
    }
}
