using System;
namespace Laboratorio4
{
    public class Ensamblaje : Maquina
    {



        public Ensamblaje(string nombre, int memoria) : base(nombre, memoria)
        {


        }

        public override void Apagado()
        {
            Console.WriteLine("Apagar Ensamblaje");

        }
        public override void Encendido()
        {
            Console.WriteLine("Encender Ensamblaje");
        }
        public override bool Reinicio()
        {
            if (Informacion_de_piezas == Memoria)
            {
                this.Memoria = 0;
                Console.WriteLine("Reinicio de memoria de Ensamblaje");
                return true;

            }
            else
            {
                return false;
            }


        }
        public override int Orden()
        {
            Ordendeprocesos = 3;
            return Ordendeprocesos;


        }
        public override void Agregarpiezas()
        {
            Console.WriteLine("Pasando a verificacion");
            Informacion_de_piezas++;
        }





    }
}
