namespace Ferreteria.Entidades
{
    public class Caja
    {
        private int idCaja;

        private string tipoComprobante;

        private int ProductoId;

        private int MovimientoId;


        public int Id
        {
            get { return idCaja; }
            set { idCaja = value; }

        }
        public string TipoComprobante
        {
            get { return tipoComprobante; }
            set { tipoComprobante = value; }
        }


        public int productoId
        {
            get { return ProductoId; }
            set { ProductoId = value; }
        }


        public int movimientoId
        {
            get { return MovimientoId; }
            set { MovimientoId = value; }
        }


        public Caja() { }

        public Caja(string tipoComprob)
        {
            tipoComprobante = tipoComprob;
        }
    }
}
