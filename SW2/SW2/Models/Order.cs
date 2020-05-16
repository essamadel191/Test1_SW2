using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SW2.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("Medicine")]
        public int medicine_id { get; set; }
        public virtual Medicine Medicine { get; set; }


        [ForeignKey("Customers")]
        public int customer_id { get; set; }
        public virtual Customers Customers { get; set; }


        public bool accept { get; set; }

    }
}