using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEF.Data.Entities
{
    internal class Quote
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]

        public string Text { get; set; }
        // One to many -> A quote can have only one samurai
        public Samurai Samurai { get; set; }

        // If we respect the naming [ClassName]Id, then EF will be
        // smart enough to know that this is a Foreign key
        public int SamuraiId { get; set; }
    }
}