using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formulario_Basico_MVC.Models
{
    public class Ordenes
    {
       

        public string? Instrumento {get;set;}
        public decimal? Precio {get;set;}
        public int? Cantidad {get;set;} 
        public decimal Costo {get;set;}
        public decimal Tax {get;set;}
        public decimal Total {get;set;}       
      
        public void CalcularOrden(){
            this.Costo=(decimal)(this.Precio*this.Cantidad);
            this.Tax = this.Costo * 0.18m;
            this.Total = this.Costo + this.Tax;
        }
        
    }
}