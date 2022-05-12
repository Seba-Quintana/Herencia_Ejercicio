using System;
using System.Collections;
using System.Collections.Generic;

namespace PII_Herencia
{
    public class UcuRideShare
    {
        private List<Usuario> listaUsuarios;
        public void Add(Usuario usuario)
        {
            listaUsuarios.Add(usuario);
        }
        public List<Usuario> ListaUsuarios {get;}
    }
}