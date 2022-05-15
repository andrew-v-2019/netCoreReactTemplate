using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace _300.Data
{
    public class ApplicationContextFactory: IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer("Data Source=tcp:300.database.windows.net;Initial Catalog=300dev;Persist Security Info=True;User ID=vlasovandrei87@gmail.com@300;Password=Kludgekludge1",
                b => b.MigrationsAssembly("300.Data"));
            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}
