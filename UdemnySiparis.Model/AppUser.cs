﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemnySiparis.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; }
        public string  Adress { get; set; } 
        public string PostalCode { get; set; }
        public string CellPhone { get; set; }

        [NotMapped]
        public int Role { get; set; }
    }
}
