using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeAniversarios.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public virtual int Id { get; set; }
    }
}
