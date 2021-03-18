using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SATApplication.DATA.EF
{
    #region Student MetaData

    
    public class StudentMetadata
    {
        [Required(ErrorMessage ="First Name is required ")]
        [StringLength(20, ErrorMessage = "First Name must be 20 characters or less")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required ")]
        [StringLength(20, ErrorMessage = "Last Name must be 20 characters or less")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(15, ErrorMessage = "Major must be 15 characters or less")]
        [Display(Name = "Major")]
        public string Major { get; set; }

        [StringLength(50, ErrorMessage = "Address must be 50 characters or less")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [StringLength(25, ErrorMessage = "City must be 25 characters or less")]
        [Display(Name = "City")]
        public string City { get; set; }

        [StringLength(2, ErrorMessage = "State must be 2 characters or less")]
        [Display(Name = "City")]
        public string State { get; set; }

        [StringLength(10, ErrorMessage = "Zip Code must be 10 characters or less")]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [StringLength(13, ErrorMessage = "City must be 13 characters or less")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email is required ")]
        [StringLength(60, ErrorMessage = "Email must be 60 characters or less")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "Photo URL must be 100 characters or less")]
        [Display(Name = "Photo URL")]
        public string PhotoUrl { get; set; }


        
        [Required(ErrorMessage ="Student Status is required")]
        [Display(Name = "Student Status")]
        public int SSID { get; set; }
    }
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {

    }
    #endregion
    #region Enrollments Metadata
    public class EnrollmentsMetadata
    {
        [Required(ErrorMessage = "Student ID is required")]
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Scheduled Class ID is required")]
        [Display(Name = "Scheduled Class ID")]
        public int ScheduledClassId { get; set; }

        [Required(ErrorMessage = "Enrollment Date is required")]
        [Display(Name = "Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true, NullDisplayText = "[N/A]")]
        public System.DateTime EnrollmentDate { get; set; }
    }
    [MetadataType(typeof(EnrollmentsMetadata))]
    public partial class Enrollment { }
    #endregion
    #region StudentStatuses MetaData
    public class StudentStatusesMetadata
    {
        [Required(ErrorMessage = "Student Status Name is required")]
        [StringLength(30, ErrorMessage = "Student Status Name must be 30 characters or less")]
        public string SSName { get; set; }

        [Required(ErrorMessage = "Student Status Description is required")]
        [StringLength(250, ErrorMessage = "Student Status Name must be 250 characters or less")]
        public string SSDescription { get; set; }
    }
    [MetadataType(typeof(StudentStatusesMetadata))]
    public partial class StudentStatus { }

    #endregion
    #region ScheduledClasses MetaData
    public class ScheduledClassesMetadata
    {
        [Required(ErrorMessage = "Course ID is required")]
        [Display(Name = "Course ID")]      
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Start Date is required")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true, NullDisplayText = "[N/A]")]
        public System.DateTime StartDate { get; set; }
        [Required(ErrorMessage = "End Date is required")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true, NullDisplayText = "[N/A]")]
        public System.DateTime EndDate { get; set; }
        [Required(ErrorMessage = " Name is required")]
        [StringLength(40, ErrorMessage = "Instructor Name must be 40 characters or less")]
        [Display(Name = "Instructor Name")]
        public string InstructorName { get; set; }
        [Required(ErrorMessage = "Location is required")]
        [StringLength(20, ErrorMessage = "Location must be 20 characters or less")]
        [Display(Name = "Location")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Scheduled Classes Status ID is required")]
        [Display(Name = "Scheduled Classes Status ID")]
        public int SCSID { get; set; }
    }
    [MetadataType(typeof(ScheduledClassesMetadata))]
    public partial class ScheduledClass { }

    #endregion
    #region Courses MetaData
    public class CoursesMetaData
    {
        [Required(ErrorMessage = "Course Name is required")]
        [StringLength(50,ErrorMessage = "Course Name must be 50 characters or less")]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }
        [Required(ErrorMessage = "Course Description is required")]
        [MaxLength(ErrorMessage = "You have exceeded the maximum amount of characters")]
        [Display(Name = "Course Description")]
        public string CourseDescription { get; set; }
        [Required(ErrorMessage = "Credit Hours are required")]
        [Display(Name = "Credit Hours")]
        public byte CreditHours { get; set; }
        [StringLength(250, ErrorMessage = "Curriculum must be 250 characters or less")]
        [Display(Name = "Curriculum")]
        public string Curriculum { get; set; }
        [StringLength(500, ErrorMessage = "Your Notes must be 500 characters or less")]
        [Display(Name = "Notes")]
        public string Notes { get; set; }
        [Required(ErrorMessage = "Is Active status is required")]
        public bool IsActive { get; set; }
    }
    [MetadataType(typeof(CoursesMetaData))]
    public partial class Cours { }

    #endregion
    #region ScheduledClass Statuses
    public class ScheduledClassStatusMetadata
    {
        [Required(ErrorMessage = "Scheduled Class Status Name is required")]
        [Display(Name = "Scheduled Class Status Name")]
        [StringLength(50, ErrorMessage = "Your Notes must be 50 characters or less")]
        public string SCSName { get; set; }
    }
    [MetadataType(typeof(ScheduledClassStatusMetadata))]
    public partial class ScheduledClassStatus { }
    #endregion
}
