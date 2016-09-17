namespace TTUHousing.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            Leases = new HashSet<Lease>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int bannerNumber { get; set; }

        [Required]
        [StringLength(25)]
        public string firstName { get; set; }

        [Required]
        [StringLength(25)]
        public string lastName { get; set; }

        [Required]
        [StringLength(30)]
        public string street { get; set; }

        [Required]
        [StringLength(30)]
        public string city { get; set; }

        [Required]
        [StringLength(5)]
        public string postalCode { get; set; }

        [Required]
        [StringLength(20)]
        public string phoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        public DateTime? dateOfBirth { get; set; }

        [Required]
        [StringLength(1)]
        public string gender { get; set; }

        [Required]
        [StringLength(20)]
        public string nationality { get; set; }

        [StringLength(100)]
        public string specialNeeds { get; set; }

        [StringLength(300)]
        public string comments { get; set; }

        [Required]
        [StringLength(10)]
        public string status { get; set; }

        public int nokID { get; set; }

        public short majorID { get; set; }

        public short StudentLevelID { get; set; }

        public int advisorID { get; set; }

        public int vinID { get; set; }

        public int courseID { get; set; }

        public virtual Advisor Advisor { get; set; }

        public virtual Course Course { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lease> Leases { get; set; }

        public virtual Major Major { get; set; }

        public virtual NextOfKin NextOfKin { get; set; }

        public virtual StudentLevel StudentLevel { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}
