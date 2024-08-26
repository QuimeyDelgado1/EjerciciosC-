using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        protected int edad;

        public void Saludar()
        {
            Console.WriteLine("Hola");
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
    }
}
