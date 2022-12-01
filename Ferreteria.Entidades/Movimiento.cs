namespace Ferreteria.Entidades
{
    public class Movimiento
    {
        private int idMovimiento;

        private string nombreCliente;

        private string apellidoCliente;

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

        public string MedioPago
        {
            get { return medioPago; }
            set { medioPago = value; } 
        
        }

        public Movimiento() { }

        public Movimiento(string nomClient, string apellClient, string medipago)
        {
           
            nombreCliente =       nomClient;        
            apellidoCliente =     apellClient;
            medioPago =          medipago;
        }
    }
}