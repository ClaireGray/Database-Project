namespace TTUHousing.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentAttendCourse")]
    public partial class StudentAttendCourse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudentAttendCourse()
        {
            Courses = new HashSet<Course>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int studentAttendCourseID { get; set; }

        [Required]
        [StringLength(25)]
        public string semester { get; set; }

        [Required]
        [StringLength(4)]
        public string year { get; set; }

        [Required]
        [StringLength(25)]
        public string instructor { get; set; }

        [Required]
        [StringLength(20)]
        public string phoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [Required]
        [StringLength(3)]
        public string roomNo { get; set; }

        [Required]
        [StringLength(25)]
        public string deptName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
