using CMS.BL.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace CMS.PL.Controllers
{
    [Route("api/Doctor/[controller]")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet("GetAll")]
        public ActionResult GetAll() => Ok(_doctorService.GetAll());
    }
}
