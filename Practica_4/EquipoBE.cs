using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    public class EquipoBE
    {
        private string codigo;
        private DateTime fecha_alta;
        private DateTime fecha_baja;
        private int nro_compra;
        private bool uso;
        private decimal precio;

        public string Codigo { get => this.codigo; set => this.codigo = value; }
        public DateTime Fecha_Alta { get => this.fecha_alta; set => this.fecha_alta = value;}
        public DateTime Fecha_Baja {  get => this.fecha_baja; set => this.fecha_baja = value;}  
        public int Nro_Compra {  get => this.nro_compra; set => this.nro_compra = value;}
        public bool Uso { get => this.uso; set => this.uso = value;}
        public decimal Precio { get => this.precio; set => this.precio = value;}
    } 
    
}
