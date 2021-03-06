using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Entities
{
    [Table("car_owner")]
    public class CarOwner
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("person_id")]
        [Required]
        public int PersonId { get; set; }

        [Column("avto_id")]
        [ForeignKey(nameof(Avto))]
        [Required]
        public int AvtoId { get; set; }
        public virtual Avto Avto { get; set; }
    }
}
