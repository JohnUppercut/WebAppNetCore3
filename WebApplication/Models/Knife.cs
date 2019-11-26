using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Knife
    {
        [Key]
        public int PK_Knife_ID { get; set; }
        public string Knife_Name { get; set; }
        public string Knife_Info { get; set; }
        public float Knife_Cost { get; set; }
        public string Knife_Description { get; set; }
        public string Knife_Characteristic { get; set; }
        public string Knife_Brand { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
