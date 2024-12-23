using CMS.BL.DTOs;

namespace CMS.BL.Services.Abstraction
{
    public interface IDoctorService
    {
        IEnumerable<DoctorDto> GetAll();
    }
}
