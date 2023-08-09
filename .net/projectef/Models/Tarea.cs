
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoef.Models;

public class Tarea
{
    [Key]
    public Guid TareaId { get; set; }

    [ForeignKey("Categoriaid")]
    public Guid CategoriaId { get; set; }

    [Required]
    [MaxLength(200)]

    public string Titulo { get; set; }

    public string Descripción { get; set; }

    public Prioridad PrioridadTarea { get; set; }

    public DateTime FechaCreacion { get; set; }


    public virtual Categoria Categoria { get; set; }

    [NotMapped]

    public string Resumen { get; set; }

    public string Comentarios { get; set; }

}

public enum Prioridad
{

    Baja,

    Media,

    Alta
}