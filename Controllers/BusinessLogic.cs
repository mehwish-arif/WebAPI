public class BusinessLogic : ILogic
{
    private IRepo _repo;
    public BusinessLogic (IRepo repo)
    {
        _repo = repo;
    }

    public void Create(AccountPoco item)
    {
        _repo.Create(item);
    }

    public AccountPoco Read(int id)
    {
        return _repo.Read(id);
    }

    public void Update(AccountPoco item)
    {
        _repo.Update(item);
    }

    public void Delete(int id)
    {
        _repo.Delete(id);
    }
}