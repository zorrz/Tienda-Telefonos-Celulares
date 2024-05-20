using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Telefonos_Celulares
{
    internal class Menuuuu_Independiente
    {
        public static Telefono[] TelefonoINV = new Telefono[4];
        public static int count=0;
        
        public static void MostrarMenu()
        {
            Console.WriteLine("\nMenu:" + "\n1. Registrar telefono" + "\n2. Mostrar telefonos registrados" + 
                "\n3. Consultar stock de un telefono" +
                 "\n4. Salir" + "\n\nSeleccione una opcion:");
        }
        public static void ValidarOpcion()
        {
            string opc;

           
            do
            {
                MostrarMenu();
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        RegistrarTelefono();
                        break;

                    case "2":
                        MostrarTelefonosRegistrados();
                        break;

                    case "3":
                        ConsultarStockDeUnTelefono();
                        break;

                    case "4":
                        Console.WriteLine("----Saliendo del programa----");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\n--Error, Seleccione una opcion--");
                        break;
                }
            }
            while (opc != "4");


        }

        public static void RegistrarTelefono()
        {
            if (count < TelefonoINV.Length)
            {

                int TipoDeTelefono = ValidarEntero("\nSeleccione el tipo de telefono a registrar:"
                    + "\n1.Telefono Basico"
                    + "\n2.Telefono Inteligente\n");

                switch (TipoDeTelefono)
                {

                    case 1:
                        Console.WriteLine($"---Inserte los siguientes datos del Telefono a registrar---\n");
                        string Marca = ValidarString("Marca:");
                        string Modelo = ValidarString("Modelo:");
                        decimal Precio = ValidarDecimal("Precio:");
                        int Stock = ValidarEntero("Stock:");

                        bool TieneRadioFM = ValidarBool("El telefono tiene radio FM? (si/no):");

                        bool TieneLinterna = ValidarBool("El telefono tiene linterna? (si/no):");

                        TelefonoINV[count] = new Telefono_Basicos(Marca, Modelo, Precio, Stock, TieneLinterna, TieneRadioFM);
                        Console.WriteLine($"\n----Telefono Basico Registrado Exitosamente----");

                        count++;
                        break;

                    case 2:
                        Console.WriteLine($"---Inserte los siguientes datos del Telefono a registrar---\n");
                        string Marca2 = ValidarString("Marca:");
                        string Modelo2 = ValidarString("Modelo:");
                        decimal Precio2 = ValidarDecimal("Precio:");
                        int Stock2 = ValidarEntero("Stock:");

                        string Sistemaoperativo = ValidarString("Ingrese el sistema operativo:");
                        int MemoriaRAM = ValidarEntero("Memoria RAM en GB: ");

                        TelefonoINV[count] = new Telefono_Inteligente(Marca2, Modelo2, Precio2, Stock2, Sistemaoperativo, MemoriaRAM);
                        Console.WriteLine($"\n----Telefono Inteligente Registrado Exitosamente----");

                        count++;
                        break;

                    default:
                        Console.WriteLine("\n--Error, Seleccione una opcion--");
                        break;
                }

            }
            else
            {
                Console.WriteLine("\n--El inventario está lleno, no se pueden agregar mas telefonos--");
                Console.WriteLine("-----------------------------------------------");
            }
            int opcSeguimiento = ValidarEntero("\nSeleccione: \n1.Desea volver al menu \n2.salir\n");

            switch (opcSeguimiento)
            {

                case 1:
                    Console.WriteLine("--------------------------------------------");
                    return;
                case 2:
                    Console.WriteLine("----Saliendo del programa----");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("\n--Error, Seleccione una opcion--");
                    break;

            }
        }
            public static void MostrarTelefonosRegistrados(){
            if (count == 0)
            {
                Console.WriteLine("\n--No se han ingresado telefonos--");
                return;
            }
            int itemTelefono =0;
            foreach (Telefono telefono in TelefonoINV)
            {
                
                if (telefono != null)
                {
                    Console.WriteLine($"---Telefono #{itemTelefono+1}---");

                    if (telefono is Telefono_Basicos)
                    {
                        ((Telefono_Basicos)telefono).MostrarInformacionBasico();
                    }
                    else if (telefono is Telefono_Inteligente)
                    {
                        ((Telefono_Inteligente)telefono).MostrarInformacionInteligente();
                        Console.WriteLine();
                    }

                    itemTelefono++;
                }
            }
            Console.WriteLine($"En total: {itemTelefono}");
            Console.WriteLine($"--------------------------------------------");

            int opcSeguimiento= ValidarEntero("\nSeleccione: \n1.Desea volver al menu \n2.salir\n");
            
            switch( opcSeguimiento)
            {
               
                case 1: 
                    Console.WriteLine("--------------------------------------------");
                return;
                case 2:
                    Console.WriteLine("----Saliendo del programa----");
                    Environment.Exit(0);
                break;

                default:
                    Console.WriteLine("\n--Error, Seleccione una opcion--");
                    break;
                
            }
        }
        public static void ConsultarStockDeUnTelefono()
        {
          
            if (count == 0)
            {
               Console.WriteLine("\n--No se han ingresado telefonos--");
               return;
            }

             string modeloAencontrar = ValidarString("\nIngrese el modelo del telefono: ");

            bool encontrado = false;

             foreach (Telefono telefono in TelefonoINV)
             {
                 if (telefono != null && telefono.Modelo.Equals(modeloAencontrar, StringComparison.OrdinalIgnoreCase))
                 {
                        Console.WriteLine($"\n--Telefono encontrado-- \nModelo: {telefono.Modelo}, Stock: {telefono.Stock}");
                    Console.WriteLine("\n--------------------------------------------");
                        encontrado = true;
                        break;
                 }
             }

             if (!encontrado)
             {
                    Console.WriteLine("--No se encontro el telefono--");
             }
            int opcSeguimiento = ValidarEntero("\nSeleccione: \n1.Desea volver al menu \n2.salir\n");

            switch (opcSeguimiento)
            {

                case 1:
                    Console.WriteLine("--------------------------------------------");
                    return;
                case 2:
                    Console.WriteLine("----Saliendo del programa----");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("\n--Error, Seleccione una opcion--");
                    break;
            }
        }
            public static int ValidarEntero(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("\nError: ¡Digite un valor!");
                    continue;
                }
                else if (int.TryParse(entrada, out int valor))
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("\nError: ¡Por favor, Digite un entero!");
                }
            }
        }
        public static bool ValidarBool(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine().Trim().ToLower();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("\n--Error: Ingrese si o no--");
                    continue;
                }
                else if (entrada== "si")
                {
                    return true;
                }
                else if (entrada == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("--Error: Ingrese si o no--");
                }
            }
        }
        public static string ValidarString(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("--Error: Espacio en blanco, ingrese un valor--");
                    continue;
                }
           
                else
                {
                    return entrada;
                }
            }
        }
        public static decimal ValidarDecimal(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("--Error: No ha ingresado un valor--");
                    continue;
                }
                else if (decimal.TryParse(entrada, out decimal valor))
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("--Error: Ingrese un valor numérico entero--");
                }
            }
        }

    }
}
