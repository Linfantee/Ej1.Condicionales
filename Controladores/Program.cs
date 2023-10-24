using Ej1.Condicionales.Servicios;

namespace Ej1.Condicionales
{

    class Program
    {

        static void Main(string[] args) {

  
          

            PeticionInterfaz ao = new PeticionImplementacion();
            int NumeroRecogido;
            NumeroRecogido = ao.PeticionNumero();
            
            if ((NumeroRecogido % 2)== 0 ) 
            {
                Console.WriteLine("Número par");
            }
            else 
            {
                Console.WriteLine("Número impar");
            }
        
        }


    }

}

