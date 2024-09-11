﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework.Models {
    public class Book {
        public string Id { get; set; }
        public string Title { get; set; }
        public string PublishedYear { get; set; }
        public virtual Author Author { get; set; }

    }
}
