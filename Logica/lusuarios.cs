using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDusuarios.Logica
{
    class lusuarios
    {
        private int idusuario;
        private string ususario;
        private string contrasena;
        private byte[] icono;
        private string estado;

        public int Idusuario
        {
            get { return Idusuario; }
            set { Idusuario = value; }
        }
        public string Usuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }
        public string Contrasena
        {
            get { return Contrasena; }
            set { Contrasena = value; }
        }
        public byte[] Icono
        {
            get { return Icono; }
            set { Icono = value; }
        }
        public string Estado
        {
            get { return Estado; }
            set { Estado = value; }
        }
        public lusuarios ()
        {

        }
        public lusuarios (int idusuario,string ususario,string contrasena,byte[] icono,string estado)
        {
            Idusuario = idusuario;
            Usuario = ususario;
            Contrasena = contrasena;
            Icono = icono;
            Estado = estado;
        }
    }
}
