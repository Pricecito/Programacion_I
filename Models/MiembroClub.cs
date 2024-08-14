using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formulario_Basico_MVC.Models
{
    public class MiembroClub
    {
        public string? Nombre{ get; set; }
        public int? Edad{ get; set; }
        public string? Genero{ get; set; }  
        public DateTime? FechaNacimiento{ get; set; }
        public string? Direccion{ get; set; }
        public string? Distrito {get; set; } 
        public string? Membresia{ get; set; }    

        public double CalcularIGV(){
            switch(this.Membresia.ToLower()){
                case "basica": return 500*0.18;
                case "premium": return 1000*0.18;
                default: return 0;
            }
        }
        public string toString(){
            return $"Nombre: {this.Nombre.ToUpper()},\nEdad: {this.Edad},\nGenero: {this.Genero},\nDirección: {this.Direccion}, Fecha de Nacimiento {this.FechaNacimiento}";
        }
    }
}