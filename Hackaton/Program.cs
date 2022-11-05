using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton
{
    public class Problema1
    {
		int decabin(int a)
		{
			if (a < 2)
			{
				return a;
			}
			else
			{
				return a % 2 + (10 * decabin(a / 2));
			}
		}


		int binadec(int a)
		{
			if (a == 1 || a == 0)
			{
				return a;
			}
			else
			{
				return binadec(a / 10) * 2 + a % 10;
			}


			
		}

		string dechex(int a)
        {
			string hex = "";
			int b = 0;

			while (a != 0)
			{
				b = a % 16;
				if (b < 10)
					b = b + 48;
				else
					b = b + 55;

				hex += Convert.ToChar(b);
				a = a / 16;
			}
			return hex;
		}

		//End
	}


	class Problema2
	{
		public Problema2()
		{

		}

		public void vocales()
		{

			string cadena;
			Console.Write("Ingrese una cadena: ");
			cadena = Console.ReadLine().ToLower();
			int cont = 0;
			for (int i = 0; i < cadena.Length; i++)
			{
				char cad = cadena[i];
				if (cad == 'a' || cad == 'e' || cad == 'i' || cad == 'o' || cad == 'u')
				{
					cont++;
				}

			}
			Console.WriteLine(cont);
			Console.ReadKey();
		}


	}

	class Problema3
	{
		public Problema3()
		{

		}

		public void main()
		{

			int num;
			Console.Write("Ingrese un numero: ");
			num = int.Parse(Console.ReadLine());

			factorial(num);
		}

		public int factorial(int n)
		{
			if (n == 1)
			{
				return 1;
			}
			return n * factorial(n - 1);
		}
	}

	class Problema4
	{
		public Problema4()
		{

		}

		
	}






	/*class Problema2
	{
		class Problema2{

		}

		public void vocales()
		{
			char[] cadena = new char[]();
			Console.WriteLine("Ingrese una cadena");
			cadena = Console.ReadLine();
			int cont = 0;
			for (int i = 0; i < cadena.length; i++)
			{
				char cad = cadena[i];
				if (cad == "a" || cad == "e" || cad == "i" cade == "o" || cad == "u"){
				cont++;
			}

			}
			Console.WriteLine(cont);
		}
		
    }*/

	internal class Program
    {

		
        static void Main(string[] args)
        {
			int keyMenu = 0;
            while (true)
            {
				Console.WriteLine("MENU");
				Console.WriteLine("1) Problema 1");
				Console.WriteLine("2) Problema 2");
				Console.WriteLine("3) Problema 3");
				Console.WriteLine("4) Problema 4");
				Console.WriteLine("5) Salir");
				Console.WriteLine("\nSeleccione un número");
				keyMenu =Convert.ToInt32(Console.ReadLine());

				if(keyMenu==1)//Problema 1
                {

                }
				else if(keyMenu==2)//Problema 2
                {

                }
				else if (keyMenu == 3)//Problema 3
				{

				}
				else if (keyMenu == 4)//Problema 4
				{

				}
				else if (keyMenu == 5)//Salir
				{
					Environment.Exit(0);
				}
                else
                {
					Console.Clear();
					//no pasa nada
                }


			}
			
			

        }
    }
}
