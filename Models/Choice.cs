namespace shiyuejiuhao1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Choice")]
    public partial class Choice
    {
        [Key]
        [StringLength(50)]
        public string cname { get; set; }

        public virtual Location Location { get; set; }
    }
}
