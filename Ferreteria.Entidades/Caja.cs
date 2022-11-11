namespace Ferreteria.Entidades
{
    public class Caja
    {
        private int idCaja;

        private string tipoComprobante;

        private int Cant_Cobrar;//para validar en un metodo la cantidad total que se va a cobrar segun el precio

        private bool Entrega_Comprobante;

        public int IdCaja { get => idCaja; set => idCaja = value; }
        public string TipoComprobante { get => tipoComprobante; set => tipoComprobante = value; }
        public bool EntregaComprobante { get=>Entrega_Comprobante; set=>Entrega_Comprobante=value; }

        public Caja() { }

    }
}
