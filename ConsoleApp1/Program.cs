using System;
using System.Security.Cryptography;
using System.Text;
namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            var programa = new Program();
            string codificado = "LVm0weGQxSXhWWGhTV0d4VVYwZG9WMWxYY3pGVmJGcHlWV3RLVUZWVU1Eaz0=tz4";
            Console.WriteLine( programa.decodificador(codificado));
        }
        public string decodificador(string baseCadena)
        {
            var programa = new Program();
            var aws = baseCadena;
            var longitud = aws.Length;
            int cont = programa.keyItera(aws.Substring(0, 1));
            string cadena1 = aws.Substring(longitud - 3);
            var primerDigito = cadena1[0];
            var segundoDigito = cadena1[1];
            var valor1 = programa.key(primerDigito.ToString());
            var valor2 = programa.key(segundoDigito.ToString());
            var cadenaLongitud = (valor1 * 10) + valor2;
            var cadenaComplementaria = aws.Substring(cadenaLongitud + 1);
            longitud = cadenaComplementaria.Length;
            string ultimoCaracter = cadenaComplementaria.Substring(longitud-1,1);
            cadenaComplementaria = cadenaComplementaria.Remove(longitud - 3, 3);
            string cadenaAiterar = aws.Substring(1, cadenaLongitud);
            string nuevaCadena = cadenaAiterar;
            string decodedString = "";

            for (int i = 0; i <= (cont - 1); i++)
            {
                byte[] data = Convert.FromBase64String(nuevaCadena);
                nuevaCadena = Encoding.UTF8.GetString(data);
            }

            var cadenaReal = nuevaCadena + cadenaComplementaria + ultimoCaracter;
            byte[] data2 = Convert.FromBase64String(cadenaReal);
            decodedString = Encoding.UTF8.GetString(data2);
            return decodedString;
        }
        public int key(string llave)
        {
            int valor = 0;
            switch (llave)
            {
                case "Q":
                    valor = 9;
                    break;
                case "r":
                    valor = 8;
                    break;
                case "S":
                    valor = 7;
                    break;
                case "t":
                    valor = 6;
                    break;
                case "U":
                    valor = 5;
                    break;
                case "v":
                    valor = 4;
                    break;
                case "W":
                    valor = 3;
                    break;
                case "x":
                    valor = 2;
                    break;
                case "Y":
                    valor = 1;
                    break;
                case "z":
                    valor = 0;
                    break;
                default:
                    valor = 0;
                    break;
            }
            return valor;
        }
        public int keyItera(string llave)
        {
            int valor = 0;
            switch (llave)
            {       
                case "e":
                    valor = 3;
                    break;
                case "A":
                    valor = 4;
                    break;
                case "r":
                    valor = 5;
                    break;
                case "M":
                    valor = 6;
                    break;
                case "z":
                    valor = 7;
                    break;
                case "L":
                    valor = 8;
                    break;
                case "S":
                    valor = 9;
                    break;
                default:
                    valor = 0;
                    break;
            }
            return valor;
        }
    }
}
