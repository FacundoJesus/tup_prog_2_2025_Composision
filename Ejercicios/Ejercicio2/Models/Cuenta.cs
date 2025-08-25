using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Cuenta
    {
        public int Nro {  get; private set; }
        public string Moneda { get; private set; }
        public double Saldo { get; private set; }

        public Cuenta(int nro, string moneda)
        {
            this.Nro = nro;
            this.Moneda = moneda;
        }


    }
}
