using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioDay6OOP
{
    public class Cliente
    {
        public string Nome {  get; set; }
        public string Cognome { get; set; }
        public string CodiceFisc { get; set; }
        public double Stipendio { get; set; }
        public Cliente() 
        {

        }
        public Cliente(string Nome, string Cognome, string CodiceFisc, double Stipendio)
        { 
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.CodiceFisc = CodiceFisc;
            this.Stipendio = Stipendio;
        }
        public string StampaCliente()
        {
            return $"Nome Completo: {Nome}{Cognome}\nCodice Fiscale: {CodiceFisc}\nStipendio: {Stipendio}";
        }
    }
}
