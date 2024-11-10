using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FitnessTrackerAPI.Models {

    public class User {
        public int id { get; set; }
 
        public string Username { get; set; }
        
 
        public string Email { get; set;}


        public string Phone { get; set; } 


        public string Password { get; set; }
    }
}



