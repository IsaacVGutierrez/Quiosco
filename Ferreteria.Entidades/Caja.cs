namespace Ferreteria.Entidades
{
    public class Caja
    {
        private int idCaja;

        private string tipoComprobante;

        private int movimientoId;

        private int productoId;

        protected int IdCaja { get => idCaja; set => idCaja = value; }
        protected string TipoComprobante { get => tipoComprobante; set => tipoComprobante = value; }
        protected int MovimientoId { get => movimientoId; set => movimientoId = value; }
        protected int ProductoId { get => productoId; set => productoId = value; }
    }
}
