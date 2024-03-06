using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiosco.Entidades
{
    public class Proveedor
    {
        private int idProveedor;

        private string nombreProveedor;

        private int telefonoProveedor;

        private string direccionProveedor;

        private DateTime horarioProveedor;

        private string diasProveedor;
      
        


        public int IdProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }

        }
        public string NombreProveedor
        {
            get { return nombreProveedor; }
            set { nombreProveedor = value; }
        }


        public int TelefonoProveedor
        {
            get { return telefonoProveedor; }
            set { telefonoProveedor = value; }
        }


        public string DireccionProveedor
        {
            get { return direccionProveedor; }
            set { direccionProveedor = value; }
        }


        public DateTime HorarioProveedor
        {
            get { return horarioProveedor; }
            set { horarioProveedor = value; }
        }

        public string DiasProveedor
         {
            get { return diasProveedor; }
            set { diasProveedor = value; }
        }


        public Proveedor() { }

        public Proveedor( string nombreProv, int telefonoProv,string direccionProv, DateTime horarioProv, string diasProv)
        {
            nombreProveedor = nombreProv;
            telefonoProveedor = telefonoProv;
            direccionProveedor = direccionProv;
            horarioProveedor = horarioProv;
            diasProveedor = diasProv;

        }




    }
}
