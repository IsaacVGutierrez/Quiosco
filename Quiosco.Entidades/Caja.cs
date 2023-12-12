namespace Quiosco.Entidades
{
    public class Caja
    {
        private int idCaja;

        private string tipoComprobante;

        private DateTime fechaCaja;

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


        public DateTime FechaCaja
        {
            get { return fechaCaja; }
            set { fechaCaja = value; }
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

        public Caja(string tipoComprob, DateTime fechaC)
        {
            tipoComprobante = tipoComprob;
            fechaCaja = fechaC;
        }
    }
}
