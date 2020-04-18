using System;
using System.Collections.Generic;
namespace Laboratorio4
{
    public class Centralmachine
    {

        List<IProcesos> procesos;


        public Centralmachine()
        {
            procesos = new List<IProcesos>();
        }

        public void Agregarproceso(IProcesos machines)
        {
            procesos.Add(machines);

        }


        public void Iniciarsimulacion()
        {
            for (int i = 1; i <= 24; i++) // simulacion de 24 horas
            {
                foreach (IProcesos simulacion in procesos)
                {
                    if (simulacion.Orden() == 1)
                    {
                        if (i == 24)
                        {
                            simulacion.Apagado();
                            continue;

                        }
                        if (i == 1)
                        {
                            simulacion.Encendido();
                        }
                        else
                        {
                            simulacion.Agregarpiezas();

                        }
                        foreach (IProcesos simulacion2 in procesos)
                        {
                            if (simulacion2.Orden() == 0 && simulacion.Reinicio())
                            {
                                simulacion2.Reinicio();


                            }

                        }





                    }
                    if (simulacion.Orden() == 2)
                    {
                        if (i == 24)
                        {
                            simulacion.Apagado();
                            continue;

                        }
                        if (i == 1)
                        {
                            simulacion.Encendido();
                        }



                        else
                        {
                            simulacion.Agregarpiezas();

                        }
                        foreach (IProcesos simulacion2 in procesos)
                        {
                            if (simulacion2.Orden() == 0 && simulacion.Reinicio())
                            {
                                simulacion2.Reinicio();


                            }

                        }





                    }

                    if (simulacion.Orden() == 3)

                    {

                        if (i == 24)
                        {
                            simulacion.Apagado();
                            continue;

                        }
                        if (i == 1)
                        {
                            simulacion.Encendido();
                        }



                        else
                        {
                            simulacion.Agregarpiezas();

                        }
                        foreach (IProcesos simulacion2 in procesos)
                        {
                            if (simulacion2.Orden() == 0 && simulacion.Reinicio())
                            {
                                simulacion2.Reinicio();


                            }

                        }



                    }
                    if (simulacion.Orden() == 4)

                    {

                        if (i == 24)
                        {
                            simulacion.Apagado();
                            continue;

                        }
                        if (i == 1)
                        {
                            simulacion.Encendido();
                        }
                        else
                        {
                            simulacion.Agregarpiezas();

                        }
                        foreach (IProcesos simulacion2 in procesos)
                        {
                            if (simulacion2.Orden() == 0 && simulacion.Reinicio())
                            {
                                simulacion2.Reinicio();


                            }

                        }



                    }
                    if (simulacion.Orden() == 5)

                    {

                        if (i == 24)
                        {
                            simulacion.Apagado();
                            continue;

                        }
                        if (i == 1)
                        {
                            simulacion.Encendido();
                        }


                        else
                        {
                            simulacion.Agregarpiezas();

                        }
                        foreach (IProcesos simulacion2 in procesos)
                        {
                            if (simulacion2.Orden() == 0 && simulacion.Reinicio())
                            {
                                simulacion2.Reinicio();


                            }

                        }



                    }





                }

            }





        }
    }

}
