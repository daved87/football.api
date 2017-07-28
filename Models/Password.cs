using System;
using System.Collections.Generic;

namespace footballApi.Models
{
    public class Password 
    {
        public int Id { get; set; }
        public string EncryptedPassword { get; set; }
        public DateTime DateCreated { get; set; }
    }
}