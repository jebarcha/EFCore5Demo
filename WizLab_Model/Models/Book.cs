using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizLab_Model.Models
{
    public class Book
    {
        [Required]
        [Key]
        public int Book_Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }
}
