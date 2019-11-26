using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Review
    {
        [Key]
        public int PK_Review_ID { get; set; }
        public Knife Knife { get; set; }

        [ForeignKey("Knife")]
        public int FK_Knife_ID { get; set; } //Привязка отзывов к ножу
        public User User { get; set; }

        [ForeignKey("User")]
        public int FK_User_ID { get; set; } //Привязка имени пользователя к отзыву
        public DateTime Review_Date { get; set; }
        public string Review_Content { get; set; }
    }
}
