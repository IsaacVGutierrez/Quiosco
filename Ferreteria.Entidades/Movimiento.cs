namespace Ferreteria.Entidades
{
    public class Movimiento
    {
        private int idMovimiento;

        private string nombreCliente;

        private string apellidoCliente;

        private string medioPago;

        private bool Es_Cliente;

        public int IdMovimiento { get => idMovimiento; set => idMovimiento = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public string MedioPago { get => medioPago; set => medioPago = value; }
        public bool EsCliente { get=>Es_Cliente; set=>Es_Cliente=value;}

        public Movimiento() { }
    }
}