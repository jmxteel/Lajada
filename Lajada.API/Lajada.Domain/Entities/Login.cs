using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lajada.Domain.Entities
{
    public class Login
    {
        public int Id { get; set; }

        [ForeignKey("Personal_Information_Id")]
        public Personal_Information Personal_Information_Id { get; set; }

        [Required, MaxLength(8)]
        public string UserName { get; set; }

        [Required, MaxLength(8)]
        public string Password { get; set; }
    }
}
