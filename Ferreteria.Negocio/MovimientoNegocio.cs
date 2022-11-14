using Ferreteria.BD;
using Ferreteria.Entidades;
using System.Data;

namespace Ferreteria.Negocio
{
    public class MovimientoNegocio
    {
        ListaMovimiento objDatosMovimiento = new ListaMovimiento();




        public int abmMovimiento(string accion, Movimiento objMovimiento)
        {
            return objDatosMovimiento.abmMovimiento(accion, objMovimiento);
        }
        public DataSet listadoMovimiento(string cual)
        {
            return objDatosMovimiento.listadoMovimiento(cual);
        }


        public List<Movimiento> ObtenerMovimiento ()
        {
            return objDatosMovimiento.ObtenerMovimiento();
        }
    }
}
