using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(250)]
        public string LastName { get; set; }
        [StringLength(200)]
        public string EmailId { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }




    }
}
