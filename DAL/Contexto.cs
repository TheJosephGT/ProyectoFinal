public class Contexto : DbContext
{
    public DbSet<Cliente> Cliente { get; set; }

    public Contexto(DbContextOptions <Contexto> options) : base(options){}

}