﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CategoriaEntity : DBEntity
    {
        public int? IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
    }
}
