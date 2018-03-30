namespace WcfDBService.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("employee")]
    public partial class employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int employeeid { get; set; }

        [StringLength(50)]
        public string employeeName { get; set; }

        [StringLength(50)]
        public string employeeAddress { get; set; }

        [StringLength(50)]
        public string employeePh { get; set; }

        public DateTime? dob { get; set; }

        [StringLength(50)]
        public string designation { get; set; }

        public int? deptid { get; set; }

        public virtual department department { get; set; }
    }
}
