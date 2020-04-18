using System;
namespace Laboratorio4
{
    public class Verificacion : Maquina
    {



        public Verificacion(string nombre, int memoria) : base(nombre, memoria)
        {


        }

        public override void Apagado()
        {
            Console.WriteLine("Apagar Verificacion");

        }
        public override void Encendido()
        {
            Console.WriteLine("Encender Verificacion");
        }
        public override bool Reinicio()
        {
            if (Informacion_de_piezas == Memoria)
            {
                this.Memoria = 0;
                Console.WriteLine("Reinicio de memoria de Verificacion");
                return true;

            }
            else
            {
                return false;
            }


        }
        public override int Orden()
        {
            Ordendeprocesos = 4;
            return Ordendeprocesos;


        }
        public override void Agregarpiezas()
        {
            Console.WriteLine("Pasando a Empaque");
            Informacion_de_piezas++;
        }





    }
}
