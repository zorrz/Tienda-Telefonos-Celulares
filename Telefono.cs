using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Telefonos_Celulares
{
    internal class Telefono
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
       
        public Telefono(string marca, string modelo, decimal precio, int stock)
        {
            Marca = marca;
            Modelo = modelo;
            Precio = precio;
            Stock = stock;
        }

        public void MostrarInformacion ()
        {
            Console.WriteLine($"Marca: {Marca} \nModelo: {Modelo} \nPrecio: {Precio} \nStock: {Stock}");
           
        }
    }
}
