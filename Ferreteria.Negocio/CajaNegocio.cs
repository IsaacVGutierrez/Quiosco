using Ferreteria.BD;
using Ferreteria.Entidades;

namespace Ferreteria.Negocio
{
    public class CajaNegocio
    {
        ListaCaja NegocioCaja = new ListaCaja();

        public List<Caja> ObtenerCaja()
        {
            return NegocioCaja.ObtenerCaja();
        }
    }
}
