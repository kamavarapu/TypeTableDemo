namespace TypeTableDemo
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Linq;

    public class TypeTableContext : DbContext
    {
        // Your context has been configured to use a 'TypeTableContext' connection string from your application's
        // configuration file (App.config or Web.config). By default, this connection string targets the
        // 'TypeTableDemo.TypeTableContext' database on your LocalDb instance.
        //
        // If you wish to target a different database and/or database provider, modify the 'TypeTableContext'
        // connection string in the application configuration file.
        public TypeTableContext()
            : base("TypeTableContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<StatusType> StatusTypes { get; set; }
    }

    public class StatusType
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }
    }

    public class StatusTypeMap : EntityTypeConfiguration<StatusType>
    {
        public StatusTypeMap()
        {
            ToTable("StatusType");

            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.Code).IsRequired();
            Property(p => p.Name).IsRequired();
        }
    }
}