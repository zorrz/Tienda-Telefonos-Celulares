using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Telefonos_Celulares
{
    internal class Telefono_Basicos: Telefono
    {

        public bool TieneRadioFM {  get; set; }
        public bool TieneLinterna { get; set; }
       
        public Telefono_Basicos(string marca, string modelo, decimal precio, int stock, bool tieneLinterna = false, bool tieneRadioFM= false) : 
            base(marca, modelo, precio, stock)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Precio = precio;
            TieneRadioFM = tieneRadioFM;
            TieneLinterna = tieneLinterna;
        }

        

        public void MostrarInformacionBasico()
        {
            MostrarInformacion();
            Console.WriteLine($"Tiene Radio FM: {TieneRadioFM} \nTiene Linterna: {TieneLinterna}\n");
        }
    }
}
