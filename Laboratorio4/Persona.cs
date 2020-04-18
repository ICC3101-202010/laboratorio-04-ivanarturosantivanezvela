using System;
namespace Laboratorio4
{
    public abstract class Persona : IProcesos
    {
        string Nombre_persona;

        public Persona(string nombre)
        {
            Nombre_persona = nombre;
        }


        public void Agregarpiezas()
        {

        }

        public void Apagado()
        {

        }

        public void Encendido()
        {

        }

        public virtual int Orden()
        {
            return 0;
        }

        public virtual bool Reinicio()
        {
            return true;
        }

        public string Retorno_nombre()
        {
            return Nombre_persona;


        }




    }
}
