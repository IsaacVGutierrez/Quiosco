using Ferreteria.BD;
using Ferreteria.Entidades;
using System.Data;

namespace Ferreteria.Negocio
{
    public class CajaNegocio

    {
        ListaCaja objDatosCaja = new ListaCaja();



        public int abmCaja(string accion, Caja objCaja)
        {
            return objDatosCaja.abmCaja(accion, objCaja);
        }
        public DataSet listadoCaja(string cual)
        {
            return objDatosCaja.listadoCaja(cual);
        }

        public List<Caja> ObtenerCaja()
        {
            return objDatosCaja.ObtenerCaja();
        }

        public DataSet listarCajaBuscar(string cual)
        {
            return objDatosCaja.listarCajaBuscar(cual);
        }

        public DataSet ListarCajaEliminar(string id)
        {
            return objDatosCaja.ListarCajaEliminar(id);
        }

        public DataSet Union()
        {
            return objDatosCaja.Union();
        }


    }
}
