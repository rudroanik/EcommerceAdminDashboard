﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }      
        public string Address { get; set; }      
        public int MobileNumber { get; set; }  
        
        public bool isDeleted { get; set; }
    }
}
