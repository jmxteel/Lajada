using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lajada.Domain.Entities
{
    public class Personal_Information
    {
        public int Id { get; set; }

        public int Login_Id { get; set; }

        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string MiddleName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Surname { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }

        public int Gender { get; set; }

        [Required, MaxLength(100)]
        public int Address { get; set; }
    }
}
