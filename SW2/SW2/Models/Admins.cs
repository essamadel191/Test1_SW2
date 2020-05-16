using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SW2.Models
{
    public class Admins
    {
        [Key]
        public int id { get; set; }

        public string fname { get; set; }
        public string lname { get; set; }
        public int phone_namber { get; set; }
        public string date_birth { get; set; }
        public string email  { get; set; }
        public int card_id { get; set; }



    }
}