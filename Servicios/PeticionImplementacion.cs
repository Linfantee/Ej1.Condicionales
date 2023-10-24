using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.Condicionales.Servicios
{
    internal class PeticionImplementacion : PeticionInterfaz
    {
        public int PeticionNumero()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Introduzca número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());


            return n1;
        }
    }
}
