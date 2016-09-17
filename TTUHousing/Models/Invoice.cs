namespace TTUHousing.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice")]
    public partial class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int invoiceNo { get; set; }

        [Required]
        [StringLength(10)]
        public string semester { get; set; }

        [Column(TypeName = "money")]
        public decimal payDue { get; set; }

        public DateTime? date { get; set; }

        [StringLength(10)]
        public string payMethod { get; set; }

        public DateTime? firstReminderDate { get; set; }

        public DateTime? secondReminderDate { get; set; }

        public int leaseNo { get; set; }

        public virtual Lease Lease { get; set; }
    }
}
