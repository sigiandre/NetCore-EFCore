using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace LeerData
{
    public class AppVentaCursosContext : DbContext
    {
        public AppVentaCursosContext(){
            Database.SetCommandTimeout(150000);
        }
        private const string connectionString = @"Data Source=localhost,1433; Initial Catalog=CursosOnline; User=sa; Password=Naruhina2020";

        private const string connectionStringMysql = @"server=db4free.net;port=3306;database=andrediaz001us;user=andrediaz;password=Naruhina@2021;old guids=true;default command timeout=800";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            //optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.UseMySQL(connectionStringMysql);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<CursoInstructor>().HasKey(ci => new {ci.CursoId, ci.InstructorId});
        }

        public DbSet<Curso> Curso { get; set; }
        public DbSet<Precio> Precio { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<CursoInstructor> CursoInstructor { get; set; }
    }
}