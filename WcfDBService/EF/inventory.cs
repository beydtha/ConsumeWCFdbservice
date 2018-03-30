namespace WcfDBService.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("inventory")]
    public partial class inventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int inventid { get; set; }

        public int? productid { get; set; }

        public int? shelf { get; set; }

        public int? bin { get; set; }

        public int? quantity { get; set; }

        public DateTime? updatedate { get; set; }

        public virtual product product { get; set; }
    }
}
