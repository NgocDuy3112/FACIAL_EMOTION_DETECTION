using FacialEmotionDetectionWebApp.Models;
using FacialEmotionDetectionWebApp.ImageHelper;
using Microsoft.AspNetCore.Mvc;

namespace FacialEmotionDetectionWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacialEmotionDetectionController: ControllerBase
    {
        public IConfiguration Configuration { get; }

    }
}
