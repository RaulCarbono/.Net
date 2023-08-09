using Microsoft.EntityFrameworkCore;
using proyectoef.Models;


namespace proyectoef;

public class TareasContext : DbContext
{

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Tarea> Tareas { get; set; }

    public TareasContext(DbContextOptions<TareasContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        List<Categoria> catagoriasInit = new List<Categoria>();
        catagoriasInit.Add(new Categoria() { CategoriaId = Guid.Parse("540f2590-9c6d-4f2e-8bab-8f3629720a34"), Nombre = "Actividades pendientes", Peso = 20 });
        catagoriasInit.Add(new Categoria() { CategoriaId = Guid.Parse("540f2590-9c6d-4f2e-8bab-8f3629720a02"), Nombre = "Actividade personales", Peso = 50 });

        modelBuilder.Entity<Categoria>(categoria =>
        {
            categoria.ToTable("Categoria");
            categoria.HasKey(p => p.CategoriaId);

            categoria.Property(p => p.Nombre).IsRequired().HasMaxLength(150);

            categoria.Property(p => p.Descripción).IsRequired(false);

            categoria.Property(p => p.Peso);

            categoria.HasData(catagoriasInit);
        });

        List<Tarea> tareasInit = new List<Tarea>();
        tareasInit.Add(new Tarea() { TareaId = Guid.Parse("540f2590-9c6d-4f2e-8bab-8f3629720a10"), CategoriaId = Guid.Parse("540f2590-9c6d-4f2e-8bab-8f3629720a34"), PrioridadTarea = Prioridad.Media, Titulo = "Pago Servicios Publicos", FechaCreacion = DateTime.Now });
        tareasInit.Add(new Tarea() { TareaId = Guid.Parse("540f2590-9c6d-4f2e-8bab-8f3629720a11"), CategoriaId = Guid.Parse("540f2590-9c6d-4f2e-8bab-8f3629720a02"), PrioridadTarea = Prioridad.Baja, Titulo = "Pago Gastos", FechaCreacion = DateTime.Now });


        modelBuilder.Entity<Tarea>(tarea =>
        {
            tarea.ToTable("Tarea");
            tarea.HasKey(p => p.TareaId);

            tarea.HasOne(p => p.Categoria).WithMany(p => p.Tareas).HasForeignKey(p => p.CategoriaId);

            tarea.Property(p => p.Titulo).IsRequired().HasMaxLength(200);

            tarea.Property(p => p.Descripción).IsRequired(false);

            tarea.Property(p => p.PrioridadTarea);

            tarea.Property(p => p.FechaCreacion);

            tarea.Property(p => p.Comentarios).IsRequired(false);

            tarea.HasData(tareasInit);
        });
    }
}