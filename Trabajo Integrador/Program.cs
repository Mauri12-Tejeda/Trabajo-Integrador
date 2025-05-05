using System;
using System.Collections;

namespace Trabajo_integrador
{

    class Club
    {
        static void Main(string[] args)
        {
            //AGREGUE PRIPIEDADES... NO PUSE NINGUN CONSTRUCTOR POR QUE NO SE COMO VA SER EL GUARDADO DE LAS PERSONAS


        }
    }


    class Deportes
    {
        private string nombreEntrenador, dniEntrenador;
        private int cupo, cantInscriptos;
        private double costoCuota;
        private string dias, horarios;


        //PROPIEDADES
        public string NombreEntrenador
        {
            set{nombreEntrenador = value;}
            get{return nombreEntrenador;}
        }
        public string DniEntrenador
        {
            set{dniEntrenador=value;}
            get{return dniEntrenador;}
        }
        public int Cupo
        {
            set{cupo = value;}
            get{return cupo;}
        }
        public int CantInscriptos
        {
            set{cantInscriptos = value;}
            get{return cantInscriptos;}
        }
        public double CostoCuota
        {
            set{costoCuota = value;}
            get{return costoCuota;}
        }
        public string Dias
        {
            set{dias = value;}
            get{return dias;}
        }
        public string Horarios
        {
            set{horarios = value;}
            get{return horarios;}
        }

    }

    class Personas
    {
        private string nombrePer, dniPer;
        private int edadPer, categoriaPer, ultMesPago;
        private double descuentoCuota;

        //PROPIEDADES

        public string NombrePer
        {
            set
            {
                nombrePer = value;
            }
            get
            {
                return nombrePer;
            }
        }

        public string DniPer
        {
            set
            {
                dniPer = value;
            }
            get
            {
                return dniPer;
            }

        }

        public int EdadPer
        {
            set
            {
                edadPer = value;
            }
            get
            {
                return edadPer;
            }
        }

        public int CategoriaPer 
        {
            set
            {
                categoriaPer = value;
            }
            get
            {
                return categoriaPer;
            }

        }

        public int UltMesPago
        {
            set
            {
                ultMesPago = value;
            }
            get
            {
                return ultMesPago;
            }
        }

        public double DecuentoCuota
        {
            get
            {
                return descuentoCuota;
            }
        }
    }
}
