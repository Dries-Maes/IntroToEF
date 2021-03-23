using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEF.Data.Entities
{
    internal class Horse
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]

        public string Name { get; set; }

        [MaxLength(255)]

        public string ImportantDetails { get; set; }

        [Range(0, 35)]

        public int Age { get; set; }

        public char Gender { get; set; }


        // One to many -> A horse can have only one or no samurai
        public Samurai Samurai { get; set; }

        // If we respect the naming [ClassName]Id, then EF will be
        // smart enough to know that this is a Foreign key
        public int SamuraiId { get; set; }
    }
}