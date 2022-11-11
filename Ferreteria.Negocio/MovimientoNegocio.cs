using Ferreteria.BD;
using Ferreteria.Entidades;

namespace Ferreteria.Negocio
{
    public class MovimientoNegocio
    {
        ListaMovimiento NegocioMov = new ListaMovimiento();

        public List<Movimiento> ObtenerMovimiento ()
        {
            return NegocioMov.ObtenerMovimiento();
        }
    }
}
