using System;
namespace Laboratorio4
{
    public interface IProcesos
    {
        int Orden();
        void Agregarpiezas();
        void Encendido();
        bool Reinicio();
        void Apagado();


    }
}

