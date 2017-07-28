using System;
using System.Collections.Generic;

namespace footballApi.Models
{
    public class User 
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public ICollection<Password> Passwords { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}