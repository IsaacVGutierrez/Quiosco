using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiosco.Entidades
{
    public class Venta
    {

        private int idVenta;

        private SqlMoney subtotalVenta;

        private DateTime fechaVenta;

        private string metodoDePagoVenta;

        private int idCliente;

        private SqlMoney saldoVenta;




        public int IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }

        }
        public SqlMoney SubtotalVenta
        {
            get { return subtotalVenta; }
            set { subtotalVenta = value; }
        }


        public DateTime FechaVenta
        {
            get { return fechaVenta; }
            set { fechaVenta = value; }
        }


        public string MetodoDePagoVenta
        {
            get { return metodoDePagoVenta; }
            set { metodoDePagoVenta = value; }
        }


        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public SqlMoney SaldoVenta
        {
            get { return saldoVenta; }
            set { saldoVenta = value; }
        }

        public Venta() { }

        public Venta(  SqlMoney subtotalVent,  DateTime fechaVent, string metodoDePagoVent, SqlMoney saldoVent)
        {
            subtotalVenta = subtotalVent;
            fechaVenta = fechaVent;
            metodoDePagoVenta = metodoDePagoVent;
            saldoVenta = saldoVent;
          

        }

    }
}
