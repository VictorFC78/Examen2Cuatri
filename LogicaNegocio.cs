using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen5BPJ
{
    public static class LogicaNegocio
    {

        /// <summary>
        /// Obtiene una lista completa de contenedores
        /// </summary>
        /// <returns>Devuelve una lista con todos los contenedores</returns>
        private static ObservableCollection<Contenedor> retValue;

        public static ObservableCollection<Contenedor> RetValue { get => retValue; set => retValue = value; }

        public static ObservableCollection<Contenedor> GetAllContenedores()
        {
            RetValue = new ObservableCollection<Contenedor>();
            RetValue.Add(new Contenedor("D0976", 72, 53, "IND"));
            RetValue.Add(new Contenedor("X9769", 52, 67, "IND"));
            RetValue.Add(new Contenedor("P0966", 74, 75, "FRA"));
            RetValue.Add(new Contenedor("D0980", 51, 15, "LIQ"));
            RetValue.Add(new Contenedor("F76435", 56, 27, "SOL"));
            RetValue.Add(new Contenedor("L7272", 77, 35, "FRA"));
            RetValue.Add(new Contenedor("K0962", 153, 46, "LIQ"));
            RetValue.Add(new Contenedor("J1021", 12, 46, "SOL"));
            RetValue.Add(new Contenedor("A4501", 24, 65, "IND"));
            return RetValue;
        }
        public static ObservableCollection<Contenedor> GetContenedoresTipoContenido(String  tipo) 
        { 
            ObservableCollection<Contenedor> lista= new ObservableCollection<Contenedor>();
            foreach(Contenedor c in RetValue)
            {
                if (c.TipoContenido.Equals(tipo)) lista.Add(c);
            }
            return lista;
        }
        public static double pesomedio(ObservableCollection<Contenedor> lista)
        {
            double pesoMedio = 0;
            foreach(Contenedor c in lista)
            {
                pesoMedio = pesoMedio + c.Peso;
            }
            return pesoMedio/lista.Count;
        }
    }
}
