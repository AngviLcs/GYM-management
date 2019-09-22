namespace shiyuejiuhao1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Location")]
    public partial class Location
    {
        [Key]
        [StringLength(50)]
        public string lname { get; set; }

        public virtual Choice Choice { get; set; }
    }
}
