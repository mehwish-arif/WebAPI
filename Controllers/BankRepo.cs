public class BankRepo : IRepo
{
    public BankRepo ()
    {
        _context = new BankContext();
    }

    public void Create(AccountPoco item)
    {
        _context.Account.Add(item);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var item =_context.Account.Find(id);
        item.Entry(item).State = EntityState.Deleted;
        _context.SaveChanges();
    }

    public AccountPoco Read(int id)
    {
        return _context.Account.Where( a=> a.Id == id).FirstorDefault();
    }

    public void Update(AccountPoco item)
    {
        _context.Entry(item).State = EntityState.Modified;
        _context.SaveChanges();
    }
}