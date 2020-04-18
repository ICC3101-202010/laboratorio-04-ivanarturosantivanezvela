using System;
namespace Laboratorio4
{
    public class Empaque : Maquina
    {



        public Empaque(string nombre, int memoria) : base(nombre, memoria)
        {


        }

        public override void Apagado()
        {
            Console.WriteLine("Apagar Empaque");

        }
        public override void Encendido()
        {
            Console.WriteLine("Encender Empaque");
        }
        public override bool Reinicio()
        {
            if (Informacion_de_piezas == Memoria)
            {
                this.Memoria = 0;
                Console.WriteLine("Reinicio de memoria de Empaque");
                return true;

            }
            else
            {
                return false;
            }


        }
        public override int Orden()
        {
            Ordendeprocesos = 5;
            return Ordendeprocesos;


        }
        public override void Agregarpiezas()
        {
            Console.WriteLine("Elemento despachado y finalizado");
            Informacion_de_piezas++;
        }





    }
}
