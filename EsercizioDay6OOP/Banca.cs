using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioDay6OOP
{
    internal class Banca
    {

        public string Nome { get; set; }
        public List<Cliente> Clienti {  get; set; }
        public List<Prestito> Prestiti { get; set; }

        public Banca(string Nome)
        {
            this.Nome = Nome;
            this.Clienti = new List<Cliente>();
            this.Prestiti = new List<Prestito>();   
        }
        public void AddPrestito(Prestito prestito)
        {
            this.Prestiti.Add(prestito);
        }

        public double TotalePrestiti(string codiceFiscale)
        {
            //return this.Prestiti.FindAll(p=>p.Intestatario.CodiceFisc == codiceFiscale).Sum(s=>s.Ammontare);
            return SearchPrestiti(codiceFiscale).Sum(s => s.Ammontare);
        }

        public List<Prestito> SearchPrestiti(string codiceFiscale) 
        {
            return this.Prestiti.FindAll(p => p.Intestatario.CodiceFisc == codiceFiscale);
        }

        public void AddCliente(Cliente Cliente)
        {
            this.Clienti.Add(Cliente);
        }

        public void RemoveCliente(string CodiceFiscale)
        {
           this.Clienti.RemoveAll(x => x.CodiceFisc == CodiceFiscale);
        }

        public Cliente SearchCLiente(string CodiceFiscale)
        {
            return this.Clienti.Find(x => x.CodiceFisc == CodiceFiscale);
        }
        public void PrintName()
        {
            Console.WriteLine($"Benvenuto in {Nome}");
        }
    }
}
