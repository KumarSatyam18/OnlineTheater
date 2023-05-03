﻿using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Register 
    {
        [Key]

        public string FullName { get; set; }
        public string EmailAddress {get;set;}
        public string Password { get;set;}
        public string Confirmpassword { get;set;}
       
    }
}
