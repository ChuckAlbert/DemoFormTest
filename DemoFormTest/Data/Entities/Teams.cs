using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFormTest.Data.Entities
{
    public class Teams
    {
        public int Id { get; set; }

        [MaxLength(5)]
        [Required]
        public string TeamsNo { get; set; }

        [MaxLength(20), Required]
        public string TeamsName { get; set; }

        [MaxLength(3)]
        public int SumOfPersons { get; set; }

        [MaxLength(15)]
        public double SalaryOfTeams { get; set; }

    }
}
