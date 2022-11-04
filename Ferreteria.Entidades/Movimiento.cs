namespace Ferreteria.Entidades
{
    public class Movimiento
    {

        #region Atributos
        protected int IdMovimiento;

        protected decimal TotalMovimiento;

        protected bool Escliente;

        protected string NombreCliente;

        #endregion


        #region Propiedades


        public int idMov
        {
            get { return IdMovimiento; }
        }

        public decimal TotalMov
        {
            get { return TotalMovimiento; }
            set { TotalMovimiento = value; }
        }

        public bool Es_Cliente   
        {
            get {return Escliente;}
            set {Escliente=value;}
        }

        public string nombrecliente
        {
            get {return NombreCliente;}
            set {NombreCliente=value;}
        }

        #endregion


        #region Cliente

        public bool Es_cliente(int Ides_cliente)//ver que sale y muestra esto
        {
            string nombre = string.Empty;
            bool cliente = false;

            try
            {
                if (Escliente.Equals(Ides_cliente))
                {
                    nombrecliente = nombre;
                    return cliente;
                }
            }
            catch (Exception)
            {

                throw new Exception("Introduzca una persona que sea cliente de la ferreteria");
                
            }

            return cliente;

        }
        #endregion 



    }
}