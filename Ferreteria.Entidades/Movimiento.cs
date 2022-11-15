namespace Ferreteria.Entidades
{
    public class Movimiento
    {
        private int idMovimiento;

        private string nombreCliente;

        private string apellidoCliente;

        private string medioPago;

       /* private bool Es_Cliente; */



       


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

        //public bool EsCliente
        //{
        //    get { return Es_Cliente; }
        //    set { Es_Cliente = value;}
        //}

        public Movimiento() { }

        public Movimiento(string nomClient, string apellClient, string medipago /* bool esClient*/)
        {
           
            nombreCliente =       nomClient;        
            apellidoCliente =     apellClient;
            medioPago =          medipago;
           /* Es_Cliente =           esClient;*/
        }
        

       /*
        public void RetiradoM(bool retiradoM)
        {
            if (retiradoM == true)
            {
                retirado = "si";
            }
            else
            {
                retirado = "no";
            }
        }*/
    }
}