using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioDay6OOP
{
    internal class Prestito
    {
        public double Ammontare { get; set; }
        public double Rata { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public Cliente Intestatario { get; set; }  

        //public Prestito()
        //    {
        //    }
        public Prestito(double Ammontare, DateTime DataInizio, DateTime DataFine, Cliente Intestatario) 
        {
            this.Ammontare = Ammontare;            
            this.DataInizio = DataInizio;
            this.DataFine = DataFine;
            this.Intestatario = Intestatario;
            this.Rata = CalcoloRata();
        }
        public string StampaPrestito()
        {
            return $"Ammontare: {Ammontare}\nRata: {Rata}\nData Inizio: {DataInizio}\nData Fine: {DataFine}\nIntestatario: {Intestatario.StampaCliente()}";
        }

        private int NumeroDiMesi()
        {
            return (DataFine.Year - DataInizio.Year) * 12;
        }
        private double CalcoloRata()
        {
            return Ammontare / NumeroDiMesi();
        }
        
        //public double Calcolorata()
        //{
        //    //double rataRisultato = Ammontare/((DataFine.Year - DataInizio.Year) * 12 + DataFine.Month - DataInizio.Month);
        //    //return rataRisultato;
        //}
    }
}
