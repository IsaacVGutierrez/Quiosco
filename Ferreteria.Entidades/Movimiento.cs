namespace Ferreteria.Entidades
{
    public class Movimiento
    {
        private int idMovimiento;

        private string nombreCliente;

        private string apellidoCliente;

        private string medioPago;

        protected int IdMovimiento { get => idMovimiento; set => idMovimiento = value; }
        protected string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        protected string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        protected string MedioPago { get => medioPago; set => medioPago = value; }
    }
}