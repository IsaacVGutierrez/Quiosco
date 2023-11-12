namespace Quiosco.Entidades
{
    public class Movimiento
    {
        private int idMovimiento;

        private string nombreCliente;

        private string apellidoCliente;

        private int dniCliente;

        private string medioPago;

        public int Id
        {
            get { return idMovimiento; }
            set { idMovimiento = value; }
        }


        public string NombreCliente

        {
            get { return nombreCliente; }
            set { nombreCliente = value;}
        }

        public string ApellidoCliente
        {

            get { return apellidoCliente;}
            set { apellidoCliente = value; }
        
        }

        public int DniCliente
        {
            get { return dniCliente; }
            set { dniCliente = (int) value; }

        }

        public string MedioPago
        {
            get { return medioPago; }
            set { medioPago = value; } 
        
        }

        public Movimiento() { }

        public Movimiento(string nomClient, string apellClient, int dniClient , string medipago)
        {
           
            nombreCliente =       nomClient;        
            apellidoCliente =     apellClient;
            dniCliente = dniClient;
            medioPago =          medipago;
        }
    }
}