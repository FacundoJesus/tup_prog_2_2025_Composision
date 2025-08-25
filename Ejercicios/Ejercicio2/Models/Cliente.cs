using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Cliente
    {
        public int Nro {  get; set; }
        public long Cuit {  get; set; }

        List <Cuenta> cuentas = new List<Cuenta> ();

        public Cliente (long cuit)
        {
            this.Cuit = cuit;

        }

        public bool CrearCuenta(string tipo, string moneda)
        {
            Cuenta cuenta = new Cuenta(this.Nro,moneda);

            Cuenta cuentaExistente = VerCuenta(cuenta.Nro);
            if(cuentaExistente == null) {
                cuentas.Add(cuenta);
                Nro++;
                return true;
            }
            return false;
            
        }

        public Cuenta VerCuenta(int numero)
        {
            Cuenta cuenta = null;
            int i = 0;
            int pos = -1;

            while(pos==-1 && i < cuentas.Count)
            {
                if (cuentas[i].Nro == numero)
                {
                    pos = i;
                }
                i++;
            }
            if (pos != -1)
            {
                cuenta = cuentas[pos];
            }
            return cuenta;
        }

        public List<Cuenta> ListaDeCuentas()
        {
            return cuentas;
        }
    }
}
