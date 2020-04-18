using System;
namespace Laboratorio4
{
    public class Encargado : Persona
    {
        public Encargado(string nombre_persona) : base(nombre_persona)
        {


        }

        public override int Orden()
        {
            return 0;
        }

        public override bool Reinicio()
        {

            Console.WriteLine("Reinico hecho por parte del trabajador" + " " + this.Retorno_nombre());
            return true;

        }






    }
}


