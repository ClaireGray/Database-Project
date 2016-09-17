namespace TTUHousing.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Room")]
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            Leases = new HashSet<Lease>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int placeID { get; set; }

        public int roomNo { get; set; }

        [Column(TypeName = "money")]
        public decimal rentRate { get; set; }

        public DateTime? date { get; set; }

        [StringLength(10)]
        public string payMethod { get; set; }

        public DateTime? firstReminderDate { get; set; }

        public DateTime? secondReminderDate { get; set; }

        public int hallNo { get; set; }

        public int flatNo { get; set; }

        public virtual Flat Flat { get; set; }

        public virtual Hall Hall { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lease> Leases { get; set; }
    }
}
