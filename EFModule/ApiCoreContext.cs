using EFModule.DBEntity;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFModule
{
    public class ApiCoreContext:DbContext
    {
        public ApiCoreContext(DbContextOptions<ApiCoreContext> contextOptions):base(contextOptions)
        {
                
        }

        public DbSet<Student> Students { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var loggerFactory = new LoggerFactory();
        //    loggerFactory.AddConsole(LogLevel.Debug);
        //    optionsBuilder.UseLoggerFactory(loggerFactory);
        //    optionsBuilder.UseSqlServer("data source=WANGPENG;User Id=sa;Pwd=sa123;initial catalog=Demo1;integrated security=True;");
        //}
    }
}
