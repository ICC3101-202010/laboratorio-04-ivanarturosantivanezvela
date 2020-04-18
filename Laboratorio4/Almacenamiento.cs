using System;
namespace Laboratorio4
{
    public class Almacenamiento : Maquina
    {



        public Almacenamiento(string nombre, int memoria) : base(nombre, memoria)
        {


        }

        public override void Apagado()
        {
            Console.WriteLine("Apagar Almacenamiento");

        }
        public override void Encendido()
        {
            Console.WriteLine("Encender Almacenamiento");
        }
        public override bool Reinicio()
        {
            if (Informacion_de_piezas == Memoria)
            {
                this.Memoria = 0;
                Console.WriteLine("Reinicio de memoria de Almacenamiento");
                return true;

            }
            else
            {
                return false;
            }


        }
        public override int Orden()
        {
            Ordendeprocesos = 2;
            return Ordendeprocesos;


        }
        public override void Agregarpiezas()
        {
            Console.WriteLine("Pasando a ensamblaje");
            Informacion_de_piezas++;
        }





    }
}
