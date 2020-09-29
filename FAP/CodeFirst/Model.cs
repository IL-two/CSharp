using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CodeFirst
{
    public class Model
    {
    }

    public class User
    {        
        public int userID { get; set; }
        [Required]
        [MaxLength(15)]
        public string userLogin { get; set; }
        [Required]
        [MaxLength(10)]
        public string userPassword { get; set; }
        public int userMaxScore { get; set; }
    }
}
