using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleProgramDEMODocument
{
    /// <summary>
    /// Klasa odpowiedzialna za naglowek dokumentu
    /// </summary>
    public class headerClient :Document
    {
        #region własności
        public decimal Id { get;  set; }
        public string Signature { get; set; } 
        public string CustomerName { get; set; }
        public string CustomerNIP { get; set; }
        public decimal ItemsTotal { get; set; }
        public decimal ItemsValueTotal { get; set; }
        public DateTime DocumentDate { get; set; }
        public string Type { get; set; }
        #endregion

        #region metody_headerClient
        public headerClient() { }
        public headerClient( string customerName, string customerNIP , DateTime documentDate , string type)
        {
            
            this.CustomerName = customerName;
            this.CustomerNIP = customerNIP;
            this.DocumentDate = documentDate;
            this.Type = type;
            
        }
        
        public void GenerateSignature(string Type)
        {
            if (Type == "Faktura")
            {
                this.Signature = "FA/"+DateTime.Now.ToString("yyyy-MM-dd") +"/" + Id;
            }
        }
        public decimal CalculateItemsTotal(decimal itemsTotal) => this.ItemsTotal+= itemsTotal;
        public decimal CalculateItemsValueTotal(decimal itemsValueTotal ) => this.ItemsValueTotal += itemsValueTotal;
        public string GenereteQueryInsert(string syg, string nazwaKlienta, string nip, decimal sumaPozycji, decimal wartoscPozycji, DateTime data,string typ)
            => "INSERT INTO NaglowekDokumentu (Sygnatura,NazwaKlienta,NIPKlienta,SumaPozycji,WartoscPozycji,Data, Typ) VALUES ( '" + syg + "' , '"+ nazwaKlienta + "', '"+ nip + "' , '"+ sumaPozycji + "', '"+ wartoscPozycji + "', '"+ data.ToString("yyyy-MM-dd") + "', '"+ typ + "' )";

        #endregion
    }
}
