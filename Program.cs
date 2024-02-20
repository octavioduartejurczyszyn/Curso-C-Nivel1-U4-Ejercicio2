using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la
            //cantidad de litros vendidos según la siguiente escala:
            //Si vende menos de 100 litros, no hay descuento.
            //Si vende entre 101 y 300 litros, el descuento es del 10%.
            //Si vende entre 301 y 500 litros, el descuento es del 15%.
            //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de 
            //litros vendidos y calcule y emita el importe con el descuento  aplicado..

            float iTotal, cLitros;
            
            Console.WriteLine("Ingrese el importe total de la venta:");
            iTotal = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros vendidos:");
            cLitros = float.Parse(Console.ReadLine());
                if(cLitros > 500)
                iTotal *= 0.75F;
                else if(cLitros > 300)
                iTotal *= 0.85F;
                else if(cLitros > 100)
                iTotal *= 0.90F;
                
                Console.WriteLine("Importe Final:" + iTotal);

        }
    }
}
