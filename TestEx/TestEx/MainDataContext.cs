using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEx
{
    class MainDataContext : DbContext
    {
        

        public MainDataContext()
            : base("DBConnection") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var model = modelBuilder.Build(Database.Connection);
            ISqlGenerator sqlGenerator = new SqliteSqlGenerator();
            string sql = sqlGenerator.Generate(model.StoreModel);
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
