﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    internal abstract class Text
    {
        //common properties
        public string? Title { get; set; }
        public string? Author { get; set; }
        protected int? PublishYear { get; set; }
    }
}
