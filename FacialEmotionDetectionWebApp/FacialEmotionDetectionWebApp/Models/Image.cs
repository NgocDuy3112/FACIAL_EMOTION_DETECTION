using System.ComponentModel.DataAnnotations.Schema;

namespace FacialEmotionDetectionWebApp.Models
{
    public class Image
    {
        public string Path { get; set; }
        public string PredictedLabel { get; set; }
        public float Probability { get; set; }
        public long ExecutionTime { get; set; }

        [NotMapped]
        public IFormFile file { get; set; }
    }
}
