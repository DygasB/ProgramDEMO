using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleProgramDEMODocument
{
    /// <summary>
    /// Klasa służąca do odwzorowania produktu
    /// </summary>
    public class headerProduct
    {
        #region własności produktu
        public decimal Id { get; set; } 
        public string Signature { get; set; }
        public string Produnkt { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal Value { get; set; }
        public DateTime Data { get; set; }
        public DocumentType Type { get; set; }
        #endregion

        #region metody
        public headerProduct() { }
        public headerProduct( string sygnatura, string produnkt, decimal price, decimal quantity, DateTime data, DocumentType type)
        {
           
            this.Signature = sygnatura;
            this.Produnkt = produnkt;
            this.Price = price;
            this.Quantity = quantity;
            this.Data = data;
            this.Type = type;
        }
        public void AddValue(decimal price, decimal quantity) => this.Value += price * quantity;

       
        public string GenerateQueryInsert(string sygnatura, string produkt, decimal price, decimal quantity, decimal value, DateTime date, string type)
            => "INSERT INTO PozycjeDokumentu (Sygnatura, Produkt, Cena, Ilosc, Wartosc, Data, Typ) VALUES ('" + sygnatura + "', '"+ produkt + "', '"+ price + "', '"+ quantity + "', '"+ value + "' , '"+date.ToString("yyyy-MM-dd")+"', '"+type+"')";

        #endregion
    }
}
