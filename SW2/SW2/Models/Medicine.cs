using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SW2.Models
{
    public class Medicine
    {

        [Key]
        public int id { get; set; }

        public string name { get; set; }
        public DateTime Date { get; set; }
        public int price { get; set; }
        public int amount { get; set; }
        public string vendor_by { get; set; }
        public string effictive_sub { get; set; }
        public string special_instruction { get; set; }


    }
}