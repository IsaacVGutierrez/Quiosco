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

        //public Caja BuscarAlumno(int id)
        //{
        //    objDatosCaja = new ListaCaja();

        //    DataTable datosTabla = new DataTable();

        //    Caja caja = new Caja();

        //    datosTabla = objDatosCaja.BuscarCaja(id);

        //    if (datosTabla.Rows.Count <1)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        caja.Id = datosTabla.Rows[0][1];
        //    }

        //}

    }
}
