﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public  class pokemon
    {
       public int Numero { get; set; }
       public string Nombre  { get; set; }

       public string Descripcion { get; set;  }

       public string UrlImagen { get; set; }

       public Elemento Tipo { get; set; }

       public Elemento Debilidad { get; set; }
       
       
    }
}
