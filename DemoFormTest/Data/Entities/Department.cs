using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFormTest.Data.Entities
{
    public class Department
    {
        public int Id { get; set; }

        [MaxLength(20)]
        [Required]
        public string DepartmentNo { get; set; }

        [MaxLength(100),Required]
        public string DepartmentName { get; set; }

        [MaxLength(500)]
        public string Remark { get; set; }
    }
}
