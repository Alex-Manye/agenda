using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Obj1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Agenda amigo; declaración de variable
            // Agenda amigo1, amigo2, amigo3;

            Agenda[] amigos = new Agenda[12];
            Agenda[] clientes = new Agenda[20];

            amigos[2].Edad = 25;
            amigos[2].Nombre = "Juan";
            amigos[2].Telefono = "94678322";
            amigos[2].Ciudad = "Vigo";
            amigos[2].Domicilio.Calle = "c/Mallorca";
            amigos[2].Domicilio.Num = 87;

            Console.WriteLine(amigos[2].Edad);


            Console.WriteLine(amigos[2].ToString());

            //Instanciamos una variable tipo Agenda
            Agenda amigo = new Agenda("Saul", "654897333", 27, "Valencia", "c/Mercado", 35);

            Console.WriteLine(amigo.ToString());

        }
        public struct Agenda
        {
            public String Nombre;
            public String Telefono;
            public int Edad;
            public String Ciudad;
            public Direccion Domicilio; //Agregamos la structura Dirección (1)

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Nombre:{Nombre}, Teléfono:{Telefono}, Edad:{Edad}, Ciudad:{Ciudad}");
                sb.Append(Domicilio.ToString());

                return (sb.ToString());
            }

            //Inicializamos el constructor

            public Agenda(String pNombre, String pTelefono, int pEdad, String pCiudad, String pCalle, int pNum) {
                Nombre = pNombre;
                Telefono = pTelefono;
                Edad = pEdad;
                Ciudad = pCiudad;
                //Instanciamos domicilio (2)
                Domicilio = new Direccion(pCalle, pNum);

            }

        }
        public struct Direccion
        {
            public String Calle;
            public int Num;


            public Direccion(String pCalle, int pNum)
            {
                Calle = pCalle;
                Num = pNum;
            }

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($", Dirección:{Calle}, #:{Num}");
                
                return (sb.ToString());
            }
        }
    }
}

