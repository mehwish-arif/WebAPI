public interface IRepo
{
    void Create(AccountPoco item);
    
    AccountPoco Read(int id);

    void update(AccountPoco item);
    
    void Delete(int id);
}