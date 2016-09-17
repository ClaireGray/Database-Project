namespace TTUHousing.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lease")]
    public partial class Lease
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lease()
        {
            Invoices = new HashSet<Invoice>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int leaseID { get; set; }

        public short? numOfSemester { get; set; }

        public DateTime? moveInDate { get; set; }

        public DateTime? moveOutDate { get; set; }

        public int placeID { get; set; }

        public int bannerNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }

        public virtual Student Student { get; set; }

        public virtual Room Room { get; set; }
    }
}
