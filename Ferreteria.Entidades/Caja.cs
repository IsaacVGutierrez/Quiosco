

namespace Ferreteria.Entidades
{
    public class Caja
    {
        //aca tiene que ir la relacion de uno a muchos con Movimiento

        //y tambien con Producto

        //por lo que tendria dos claves foraneas

        #region Atributos

        protected int IdCaja;

        protected bool EntregaComprobante;

        TipoComprobante TipoComprobante;

        protected int CantProductosCobrar;

        TipoPago TipoPago;

        //relacion de un cliente para la compra de muchos productos segun la clave foranea y restricciones

        //Con la restriccion de IdMovimiento

        #endregion


        #region Propiedades

        public int Id_caja
        {
            get { return IdCaja; }
        }


        public bool ComprobanteEntrega
        {
            get {return EntregaComprobante;}
           // set {EntregaComprobante=value;}
        }

        public TipoComprobante Tipocomprobante 
        {
            get {return TipoComprobante;}
                
        }

        public int ProductosCantCobrar
        {
            get {return CantProductosCobrar;}
            set {CantProductosCobrar=value;}
        }

        public TipoPago Tipo_Pago 
        {
            get {return TipoPago;} 
        }
        #endregion


        #region MetodosValidacion

        //aca se van a hacer los metodos que validen el costo total de lo lleva o compra el cliente
        //entre otras operaciones

        #endregion

    }

    public enum TipoComprobante
    {

        FacturaA=1,

        FacturaB=2,

        FacturaC=3
    }

    public enum TipoPago
    {
        Efectivo=1,

        Tarjeta=2,

        Transferencia=3
    }

}
