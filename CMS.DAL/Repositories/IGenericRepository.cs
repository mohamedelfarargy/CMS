namespace CMS.DAL.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
