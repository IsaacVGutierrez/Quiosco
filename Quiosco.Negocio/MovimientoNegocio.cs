using Quiosco.BD;
using Quiosco.Entidades;
using System.Data;

namespace Quiosco.Negocio
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


        public DataSet listarMovimientoBuscar(string cual)
        {
            return objDatosMovimiento.listarMovimientoBuscar(cual);
        }

        public DataSet ListarMovimientoEliminar(string id)
        {
            return objDatosMovimiento.ListarMovimientoEliminar(id);
        }
    }
}
