﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string PictureProfileUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships

        List<Movie> Movies { get; set; }
    }
}