namespace WcfDBService.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EModel : DbContext
    {
        public EModel()
            : base("name=EModel")
        {
        }

        public virtual DbSet<department> department { get; set; }
        public virtual DbSet<employee> employee { get; set; }
        public virtual DbSet<inventory> inventory { get; set; }
        public virtual DbSet<product> product { get; set; }
        public virtual DbSet<userdetail> userdetail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<department>()
                .Property(e => e.deptName)
                .IsUnicode(false);

            modelBuilder.Entity<department>()
                .Property(e => e.deptCode)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.employeeName)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.employeeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.employeePh)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.productnumber)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.size)
                .IsFixedLength();
        }
    }
}
