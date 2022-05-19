using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseConstructores
{
    public class Celular
    {
        public string Nombre { get; set; } = string.Empty;

        public Celular()
        {
            Console.WriteLine("Constructor Celular()");
        }

        public Celular(string nombre)
        {
            Console.WriteLine(nombre);
        }


        public virtual void SonarNoti()
        {
            //suena
        }
    }
    
    public class CelularLiberado : Celular
    {
        public override void SonarNoti()
        {
            //suena liberado
        }

        public CelularLiberado(string nombre) //esto va a llamar al constructor por defecto, osea a Celular(). Si borramos Celular() va a fallar, vamos a tener que definir que llame al otro constructor.
        {
            Console.WriteLine(nombre);
        }
        public CelularLiberado(string nombre, string marca) : base(nombre)
        {
            Console.WriteLine(marca);
        }

    }
}
