﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHojasDeVida.Models
{
     interface Login
    {

        void Autenticar(string username, string password);
        void Crear();

    }
}
