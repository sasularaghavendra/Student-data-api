using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Models.Models
{
    [Table("tbl_Student")]
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        [Column("Student_Name")]
        public string StudentName { get; set; }
        [Required]
        public int Class { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public int Marks { get; set; }
    }
}
