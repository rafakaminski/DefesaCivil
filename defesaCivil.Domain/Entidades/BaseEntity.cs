﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defesaCivil.Domain.Entidades
{
    public class BaseEntity
    {
        [Key]
        public long id {  get; set; }
    }
}