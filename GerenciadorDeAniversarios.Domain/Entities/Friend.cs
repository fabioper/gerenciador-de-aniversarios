using System;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeAniversarios.Domain.Entities
{
    public class Friend : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string FamilyName { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }

        public int DaysUntilBirthday()
        {
            var result = Birthdate - DateTime.Now;

            return result.Days;
        }
    }
}
