using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Persona
    {
        private string nombre;
        private int dni;
        public DateTime FechaNac;
        
        public Persona(string nombre, int dni)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public string Datos()
        {
            return $"DNI: {this.dni} - Nombre: {this.nombre} - {this.FechaNac}";
        }
        

    }
}
