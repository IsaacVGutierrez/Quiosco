
namespace Ferreteria.Entidades
{
    public class Producto
    {
        #region Atributos

        protected int IdProducto;

        protected Categoria_Producto CategoriaProd;

        protected bool ExisteProducto;//relacionar con la busqueda del id para ver si existe este producto

        protected string NombreProducto;

        protected decimal PrecioProducto;

        #endregion



        #region Propiedades

        public int IdProd
        {
            get { return IdProducto; }
        }

        public Categoria_Producto CategoriaProducto //posiblemente recursion infinita
        {
            get { return CategoriaProd; }//porque no se puede modificar exteriormente, por eso solo tiene modificar de acceso get
        }

        public bool ExisteElProducto
        {
            get { return ExisteProducto; }
            set { ExisteProducto = value; }
        }


        public string NombreProd
        {
            get { return NombreProducto;}
            set { NombreProducto = value;}
        }

        public decimal Precio
        {
            get {return PrecioProducto;}
            set {PrecioProducto=value;}
         
        }
        #endregion

        #region MetodosValidaciones

        /*
         * Aca en esta parte, encapsulado bajo una region irian los metodos
         * para hacer las validaciones respectivas
         */

        #endregion




        public Producto() { }
       

    }

    public enum Categoria_Producto
    {

        Clavos = 1,

        Tornillos = 2,

        Alicates = 3,

        Cepillos_metálicos = 4,

        Cutters = 5,

        Destornilladores=6,

        Extractores = 7,

        LimasYescofinas=8,

        Llaves_ajustables = 9,

        Llaves_allen = 10,
    }
}