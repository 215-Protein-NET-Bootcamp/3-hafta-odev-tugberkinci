namespace _3_hafta_odev_tugberkinci.Service.IServices
{
    public interface IGenericService <T> where T : class
    {
        IEnumerable<T> GetAll ();
        T GetById (int id);
        T Insert(T entity);
        T Update (T entity);
        T DeleteById (int id);
    }
}
