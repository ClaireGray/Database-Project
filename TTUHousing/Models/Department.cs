namespace TTUHousing.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Department")]
    public partial class Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Department()
        {
            Advisors = new HashSet<Advisor>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short deptNo { get; set; }

        [Required]
        [StringLength(30)]
        public string deptName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Advisor> Advisors { get; set; }
    }
}
