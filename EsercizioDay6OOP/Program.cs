using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioDay6OOP
{
    internal class Program
    {
        
        static void Main(string[] args)
        {      
            Cliente Giorgio = new Cliente();
            #region            
            Giorgio.Nome = "Giorgio";
            Giorgio.Cognome = "ErBello";
            Giorgio.CodiceFisc = "RSSMRA85M01H501Z";
            Giorgio.Stipendio = 6590.20;
            #endregion

            Prestito Mutuo = new Prestito(450000.00,new DateTime(2024, 5, 27),new DateTime(2054, 5, 27),Giorgio);
            //#region
            //Mutuo.DataInizio = new DateTime(2024, 5, 27);
            //Mutuo.DataFine = new DateTime(2054, 5, 27);            
            //Mutuo.Ammontare = 450000.00;
            //Mutuo.Intestatario = Giorgio;
            //#endregion            

            Banca banca = new Banca("Banco Popolare Di Claudio");
            banca.AddPrestito(Mutuo);
            List<Prestito> prestiti = banca.SearchPrestiti("RSSMRA85M01H501Z");



            foreach (var item in banca.SearchPrestiti("RSSMRA85M01H501Z"))
            {                
                Console.Write("Cliente {0} {1} ",item.Intestatario.Nome, item.Intestatario.Cognome);
                Console.WriteLine(item.Ammontare);
                Console.WriteLine(item.Rata);

            }
            //Console.Write( JsonConvert.DeserializeObject<List<Prestito>>(banca.SearchPrestiti("RSSMRA85M01H501Z")));


            //Console.WriteLine("Cosa vorresti fare: \n1 per lista clienti.\n2 per lista prestiti.\n3 per aggiungere un cliente.\n4 per cercare un prestito.\n" +
            //    "per visionare i prestiti di un cliente.\n6 per cercare un cliente.\n7 per aggiungere un cliente.\n8 per eliminare un cliente.");

            //int selection = Convert.ToInt32(Console.ReadLine());

            
            Console.Read();
        }
    }
}
