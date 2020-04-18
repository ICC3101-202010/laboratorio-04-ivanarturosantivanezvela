using System;
namespace Laboratorio4
{
    public abstract class Maquina : IProcesos
    {


        protected string Nombre;
        protected int Memoria;
        protected int Informacion_de_piezas = 0;
        protected int Ordendeprocesos;


        public Maquina(string nombre, int memoria)
        {
            this.Nombre = nombre;
            this.Memoria = memoria;
        }
        public virtual int Orden()
        {
            return 0;

        }

        public virtual void Agregarpiezas()
        {


        }

        public virtual void Apagado()
        {

        }

        public virtual void Encendido()
        {

        }

        public virtual bool Reinicio()
        {

            return false;

        }




    }
}
