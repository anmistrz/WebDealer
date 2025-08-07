namespace WebPromotion.Services
{
    public interface ICrud<T>
    {
        T Create(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Update(T entity);
        void Delete(int id);
    }
}
