﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public String Key { get; set; }
        public String Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
