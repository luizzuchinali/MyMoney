using Microsoft.EntityFrameworkCore;

namespace MyMoney.Infra
{
    public class MyMoneyDbContext : DbContext
    {
        public MyMoneyDbContext(DbContextOptions<MyMoneyDbContext> options)
        : base(options)
        {
        }
    }
}