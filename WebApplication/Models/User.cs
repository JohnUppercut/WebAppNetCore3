using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class User
    {
        [Key]
        public int PK_User_ID { get; set; }
        public string User_Name { get; set; }
        public string User_Password { get; set; }
        public string User_FIO { get; set; }
        public DateTime User_Birthday { get; set; }
        public string User_Email { get; set; }
        public string User_Telephone { get; set; }
        public List<Review> Reviews { get; set; }

    }
}
