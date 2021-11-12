﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemoncode.Books.Application.Models
{
    public class BookUpdate
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }        
        public string Description { get; set; }
    }
}
