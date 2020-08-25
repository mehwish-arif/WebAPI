using Microsoft.EntityFrameworkCore;

public class BankContext : DbContext
{
public DbSet<AccountPoco> Account { get; set;}
 protected  override void onConfiguring (DbContextOptionBuilder opt)
{
    optionBuilder.UseSqlServer("")
    base.onConfiguring(optionBuilder);
}
}
