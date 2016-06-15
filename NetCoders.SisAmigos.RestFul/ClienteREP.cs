﻿using NetCoders.SisAmigos.RestFul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetCoders.SisAmigos.RestFul
{
    public static class ClienteREP
    {
        private static IList<ClienteEntity> _clientes = new List<ClienteEntity>();

        private static Int32 _codigo = 1;

        public static IList<ClienteEntity> GetAll()
        {
            return _clientes;
        }

        public static void Create(ClienteEntity cliente)
        {
            cliente.Codigo = _codigo++;
            _clientes.Add(cliente);
        }


    }
}