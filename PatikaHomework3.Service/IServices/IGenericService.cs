namespace PatikaHomework3.Service.IServices
{
    public interface IGenericService <T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetById(int id);
        T  Insert(T entity);
        T  Update(T entity);
        T  Delete(int id);
    }
}
