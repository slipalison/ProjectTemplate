
using ProgectTemplate.Business.Entity.Table;
using ProgectTemplate.Repository.EntityConfig.Table;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.SqlServer;

namespace ProgectTemplate.Repository.Context
{
    public class Context: DbContext
    {
        public Context()
            :base("Process")
        {
            var ensureDLLIsCopied = SqlProviderServices.Instance;
        }


        public DbSet<WUser> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();


            modelBuilder.Configurations.Add(new WUserMap());

            base.OnModelCreating(modelBuilder);
        }
        
    }
    // Classe para trocar a ConnectionString do EF em tempo de execução.
    public static class ChangeDb
    {
        public static void ChangeConnection(this Context context, string cn)
        {
             context.Database.Connection.ConnectionString = cn;
        }
    }
}
