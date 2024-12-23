using CMS.DAL.Entities;
using CMS.DAL.Repositories.Abstraction;

namespace CMS.DAL.Repositories.implementation
{
    public class DoctorRepository : GenericRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
