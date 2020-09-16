﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Twitter.Data
{
    public class Tweet
    {
        public int Id { get; set; }      
        public string Text { get; set; }
        public DateTime CreateOn { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
