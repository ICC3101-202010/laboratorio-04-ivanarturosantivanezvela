using System;

namespace Laboratorio4
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            IProcesos recepcion = new Recepcion("Recepcion", 2);
            IProcesos almacenamiento = new Almacenamiento("Almacenamiento", 5);
            IProcesos ensamblaje = new Ensamblaje("Ensamblaje", 7);
            IProcesos verificacion = new Verificacion("Verificacion", 8);
            IProcesos empaque = new Empaque("Empaque", 10);
            IProcesos encargado = new Encargado("Manuel");

            Centralmachine central = new Centralmachine();

            central.Agregarproceso(recepcion);
            central.Agregarproceso(almacenamiento);
            central.Agregarproceso(ensamblaje);
            central.Agregarproceso(verificacion);
            central.Agregarproceso(empaque);
            central.Agregarproceso(encargado);

            central.Iniciarsimulacion();


        }
    }
}

