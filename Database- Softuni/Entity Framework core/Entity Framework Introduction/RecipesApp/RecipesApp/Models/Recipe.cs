﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RecipesApp.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan CookingTime { get; set; }
    }
}
