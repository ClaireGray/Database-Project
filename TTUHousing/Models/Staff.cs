namespace TTUHousing.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            Halls = new HashSet<Hall>();
            Inspections = new HashSet<Inspection>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int staffNo { get; set; }

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
        [StringLength(50)]
        public string email { get; set; }

        public DateTime? dateOfBirth { get; set; }

        [Required]
        [StringLength(1)]
        public string gender { get; set; }

        [Required]
        [StringLength(25)]
        public string position { get; set; }

        [StringLength(30)]
        public string location { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hall> Halls { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inspection> Inspections { get; set; }
    }
}
