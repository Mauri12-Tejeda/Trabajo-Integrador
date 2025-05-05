using System;
using System.Collections;

namespace Trabajo_integrador
{

    class Club
    {
        static void Main(string[] args)
        {
            //prueba de guardado aaaaaa


        }
    }


    class Deportes
    {

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
