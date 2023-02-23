using System.ComponentModel.DataAnnotations.Schema;

namespace FacialEmotionDetectionWebApp.Models
{
    public class Image
    {
        public string path { get; set; }
        public string emotion { get; set; }

        [NotMapped]
        public IFormFile file { get; set; }
    }
}
