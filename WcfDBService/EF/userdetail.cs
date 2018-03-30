using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WcfDBService.EF
{
    [Table("usermodel")]
    public class userdetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        
        public int UserID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string email { get; set; }



        public int Deptid { get; set; }

        public virtual department department { get; set; }
    }
}