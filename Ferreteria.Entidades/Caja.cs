namespace Ferreteria.Entidades
{
    public class Caja
    {
        private int idCaja;

        private string tipoComprobante;


        private int ProductoId;

        private int MovimientoId;


        /*private int Cant_Cobrar;  //para validar en un metodo la cantidad total que se va a cobrar segun el precio

        private bool Entrega_Comprobante;
        */



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





        //public bool EntregaComprobante
        //{
        //    get { return Entrega_Comprobante; }
        //    set { Entrega_Comprobante = value; }
        //}

        public Caja() { }



        public Caja(string tipoComprob  /*, bool entregaComprob*/)
        {
          
            tipoComprobante =          tipoComprob;
          /*Entrega_Comprobante =      entregaComprob;*/


        }
    }
}
