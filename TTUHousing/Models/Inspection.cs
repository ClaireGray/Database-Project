namespace TTUHousing.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inspection")]
    public partial class Inspection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int inspectionNo { get; set; }

        public DateTime inspectionDate { get; set; }

        [Required]
        [StringLength(4)]
        public string satisfactory { get; set; }

        [StringLength(300)]
        public string comments { get; set; }

        public int flatNo { get; set; }

        public int staffNo { get; set; }

        public virtual Flat Flat { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
