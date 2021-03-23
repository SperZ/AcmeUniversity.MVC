using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AcmeUniversity.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(50, MinimumLength =2)]
        [Required]
        public string LastName { get; set; }

        [Column("FirstName"), Display(Name ="First Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]$"), StringLength(50)] 
        [Required]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name ="Full Name")]
        public string FullName 
        {
            get 
            {
                return LastName + ", " + FirstMidName; 
            }
        }
        public ICollection<Enrollment> Enrollments{get; set;}
    }
}
