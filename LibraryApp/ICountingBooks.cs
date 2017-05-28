namespace LibraryApp
{
    public interface ICountingBooks<T>
    {
        int counter(T obj);
    }
}