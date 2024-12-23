using CMS.BL.DTOs;
using CMS.BL.Services.Abstraction;
using CMS.DAL.Repositories.Abstraction;

namespace CMS.BL.Services.implementation
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;

        #region constructor
        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        #endregion

        public IEnumerable<DoctorDto> GetAll()
        {
            var doctors = _doctorRepository.GetAll();
            var doctorsDto = new List<DoctorDto>();
            foreach (var doctor in doctors)
            {
                doctorsDto.Add(new DoctorDto
                {
                    Id = doctor.Id,
                    Name = doctor.Name,
                    Phone = doctor.Phone,
                    Salary = doctor.Salary,
                    Specialization = doctor.Specialization
                });

            }

            return doctorsDto;
        }
    }
}
