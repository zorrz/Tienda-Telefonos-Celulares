using System.Reflection.Metadata.Ecma335;

namespace Tienda_Telefonos_Celulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono_Basicos TetelefonoBasico1 = new Telefono_Basicos("Huawei","M16P",200,40,true);
            Telefono_Inteligente TelefonoInteligente1= new Telefono_Inteligente("Samsung","Kt56",300,60,"Android",8);

            Menuuuu_Independiente.TelefonoINV[0] = TetelefonoBasico1 ;
            Menuuuu_Independiente.TelefonoINV[1] = TelefonoInteligente1 ;
            Menuuuu_Independiente.count = 2;

            Menuuuu_Independiente.ValidarOpcion();

           
        }

       

    }

}
