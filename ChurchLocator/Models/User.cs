using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChurchLocator.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { set; get; }        
        public string FirstName { get; set; }        
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        [NotMapped]
        public string ConfirmPassword { get; set; }
       // public int UserID { get; internal set; }


        //public User() { }


    }
}

