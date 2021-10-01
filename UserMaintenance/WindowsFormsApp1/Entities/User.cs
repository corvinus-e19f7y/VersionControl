﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
     public  class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Firstname { get; set; }
        public string LastName { get; set; }
        private int myVar;

        public string FullName
        {
            get 
            {
                return string.Format(
                    "{0} {1}",
                    LastName,
                    Firstname); 
            }
        }

    }
}
