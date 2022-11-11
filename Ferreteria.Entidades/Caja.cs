namespace Ferreteria.Entidades
{
    public class Caja
    {
        private int idCaja;

        private string tipoComprobante;

        private int CantCobrar;

        private bool EntregaComprobante;

        public int IdCaja { get => idCaja; set => idCaja = value; }
        public string TipoComprobante { get => tipoComprobante; set => tipoComprobante = value; }
        public int Cant_cobrar { get=>CantCobrar; set=>CantCobrar=value;}

        public bool Entrega_Comprob { get=>EntregaComprobante; set=>EntregaComprobante=value; }

    }
}
