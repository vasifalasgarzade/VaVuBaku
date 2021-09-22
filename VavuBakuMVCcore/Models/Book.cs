using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VavuBakuMVCcore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        public int Count { get; set; }

        //Klientin gelmek istediyi tarix
        public DateTime BookDate { get; set; }

        //Klientin book ucun muraciet etdiyi gun
        public DateTime Date { get; set; }
    }
}
