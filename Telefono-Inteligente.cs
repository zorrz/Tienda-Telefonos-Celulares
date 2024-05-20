using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Telefonos_Celulares
{
    internal class Telefono_Inteligente : Telefono
    {
        

        public string SistemaOperativo { get; set; }
        public int MemoriaRAM { get; set; } // En GB

        public Telefono_Inteligente(string marca, string modelo, decimal precio, int stock, string sistemaOperativo, int memoriaRAM): 
            base(marca,modelo,precio,stock)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Precio = precio;
            this.Stock = stock;
            SistemaOperativo = sistemaOperativo;
            MemoriaRAM = memoriaRAM;
        }

        public void MostrarInformacionInteligente()
        {
            MostrarInformacion();
            Console.WriteLine($"Sistema Operativo: {SistemaOperativo} \nMemoria RAM: {MemoriaRAM} GB");
        }
}
}
