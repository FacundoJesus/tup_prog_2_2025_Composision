using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Tarjeta
    {
        public int Nro {  get; set; }

        public Persona Dueño;

        public DateTime FechaIngreso;
        public DateTime FechaSalida;

        public double Saldo;

        public Tarjeta(int numero, string nombre, int dni)
        {
            Dueño = new Persona(nombre,dni);
            this.Nro = numero;
            this.Saldo = 0;
            this.FechaIngreso = DateTime.Now;
            
        }

        public bool CargarJuego(double monto)
        {
            bool pudoJugar  = false;

            if (this.Saldo >= monto) {
                Saldo -= monto;
                pudoJugar = true;
            }
            return pudoJugar;
        }
    }

}
