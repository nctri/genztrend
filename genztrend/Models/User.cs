﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace genztrend.Models
{   
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public int IdRole { get; set; }

        public string Password { get; set; }
    }

}