using System;
namespace Laboratorio4
{
    public class Recepcion : Maquina
    {



        public Recepcion(string nombre, int memoria) : base(nombre, memoria)
        {


        }

        public override void Apagado()
        {
            Console.WriteLine("Apagar Recepcion");

        }
        public override void Encendido()
        {
            Console.WriteLine("Encender Recepcion");
        }
        public override bool Reinicio()
        {
            if (Informacion_de_piezas == Memoria)
            {
                this.Memoria = 0;
                Console.WriteLine("Reinicio de memoria de Recepcion");
                return true;

            }
            else
            {
                return false;
            }


        }
        public override int Orden()
        {
            Ordendeprocesos = 1;
            return Ordendeprocesos;


        }
        public override void Agregarpiezas()
        {
            Console.WriteLine("Llego pieza a recepcion");
            Console.WriteLine("Pasando a almacenamiento");
            Informacion_de_piezas++;
        }





    }
}
