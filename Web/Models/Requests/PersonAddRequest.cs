﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Goody.Web.Models.Requests
{
    public class PersonAddRequest
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}