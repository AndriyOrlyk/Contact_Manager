using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        [DisplayName("DateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Column(TypeName = "bit")]
        [DisplayName("Married")]
        public bool Married { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Phone")]
        public string Phone { get; set; }

        [Required]
        [Column(TypeName = "money")]
        [DisplayName("Salary")]
        public decimal Salary { get; set; }
    }
}
