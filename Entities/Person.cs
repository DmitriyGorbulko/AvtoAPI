using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Entities
{
    [Table("person")]
    public class Person
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("surname")]
        public string Surname{ get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("numberlicense")]
        public int NumberLicense { get; set; }

        [Column("numberpasport")]
        public int NumberPasport { get; set; }

        [Column("email")]
        public int Email { get; set; }

        [Column("numberphone")]
        public int NumberPhone { get; set; }

        [Column("AvtoId")]
        [ForeignKey("Avto")]
        public int AvtoId { get; set; }
        public virtual Avto Avto { get; set; }
    }
}
