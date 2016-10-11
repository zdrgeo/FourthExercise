﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FourthExercise.DataServices.Entity.Models
{
    public class JobRole
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}