namespace WcfDBService.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            inventory = new HashSet<inventory>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int productid { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string productnumber { get; set; }

        public float? listprice { get; set; }

        [StringLength(10)]
        public string size { get; set; }

        public int? weight { get; set; }

        public DateTime? selldatestart { get; set; }

        public DateTime? discountdatestart { get; set; }

        public DateTime? modifieddate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inventory> inventory { get; set; }
    }
}
