using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton
{
    public class Problema1
    {
		public string DecaBin(int a)
		{

			string res = "";
			while (a != 0)
			{
				res = (a % 2).ToString() + res;
				a /= 2;
			}
			return res;
		}

		public int BinaDec(int a)
        {
			int res=0;
			res=binadec(a);

			return res;
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

		public string dechex(int a)
        {	
			if (a < 1) return "0";

			int b = a;
			string res = "";

			while (a > 0)
			{
				b = a % 16;

				if (b < 10)
					res = res.Insert(0, Convert.ToChar(b + 48).ToString());
				else
					res = res.Insert(0, Convert.ToChar(b + 55).ToString());

				a /= 16;
			}

			return res;

		}
		public int hexdec(string a)
		{
			int b = 0;
			

			for(int i= 0; i < a.Length; i++)
            {
				if (a.Length == 1 && a[i]!='A' && a[i] != 'B' && a[i] != 'C' && a[i] != 'D' && a[i] != 'E' && a[i] != 'F')
				{
					b += Convert.ToInt32(a[i].ToString());
				}
				else if (a[i] == 'A' )
                {
					b += 10;
                }
				else if(a[i] == 'B')
                {
					b += 11;
				}
				else if (a[i] == 'C')
				{
					b += 12;
				}
				else if (a[i] == 'D')
				{
					b += 13;
				}
				else if (a[i] == 'E')
				{
					b += 14;
				}
				else if (a[i] == 'F')
				{
					b += 15;
				}
                else
                {
					b += Convert.ToInt32(a[i].ToString())*16;
                }
			}
			
			return b;
		}

		//End
	}
	class Problema2
	{
		public Problema2()
		{

		}

		public void main()
		{

			string cadena;
			Console.Write("Problema 2");
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
			Console.WriteLine("El numero de vocales encontradas es: "+cont);
			
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

			Console.Write("Problema 3");
			Console.Write("Ingrese un numero para el factorial: ");
			num = int.Parse(Console.ReadLine());

			Console.WriteLine("El factorial es: " + factorial(num));
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

		public void main()
		{
			Console.Write("Problema 4");
			int numAmigos, numPorciones;
			Console.Write("Ingrese la cantidad de amigos: ");
			numAmigos = int.Parse(Console.ReadLine());

			Console.Write("Ingrese la cantidad de porciones que quiere cada uno: ");
			numPorciones = int.Parse(Console.ReadLine());
			double cant = cantPasteles(numAmigos, numPorciones);

			Console.WriteLine("La cantidad mínima de pasteles es de: " + cant);
			Console.ReadKey();
		}

		public double cantPasteles(int cantAmigos, int cantPorciones)
		{
			double totalP = cantAmigos * cantPorciones;

			double r = totalP / 4;

			double cantPast = Math.Ceiling(r);
			return cantPast;
		}
	}


	internal class Program
    {

	
        static void Main(string[] args)
        {

			Console.WriteLine("Integrantes");
			Console.WriteLine("Roberto Alfredo Moya Noack - 1273020");
			Console.WriteLine("Julio Andrés Agustin Gabriel - 1299720");
		

			int keyMenu = 0;
			Problema1 p1 = new Problema1();
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
					Console.Clear();

					int keyP1 =1;
					int keyMenuP1 = 0;
					int keyBaseP1 = 0;
					int num1,num2 = 0;
					string Num1, Num2="";
					int res = 0;
					while (keyP1!=0)
                    {
						Console.WriteLine("Problema 1");
						Console.WriteLine("1) Sumar");
						Console.WriteLine("2) Restar");
						Console.WriteLine("3) Salir");
						keyMenuP1 =Convert.ToInt32(Console.ReadLine());

						if(keyMenuP1==1)//Quiere sumar
                        {
							Console.WriteLine("Seleccione la base");
							Console.WriteLine("1) Decimal");
							Console.WriteLine("2) Binario");
							Console.WriteLine("3) Hexadecimal");
							Console.WriteLine("4) Salir");
							keyBaseP1 =Convert.ToInt32(Console.ReadLine());

							if(keyBaseP1==1)//Sumas decimales
                            {
								Console.WriteLine("Ingrese los dos numeros");
								Console.WriteLine("Ingrese el primer nuemero");
								num1 = Convert.ToInt32(Console.ReadLine());
								Console.WriteLine("Ingrese el segundo nuemero");
								num2 = Convert.ToInt32(Console.ReadLine());
								res = num1 + num2;

								Console.WriteLine("\nEl resultado en Decimal es: " + res);
								Console.WriteLine("El resultado en Binario es: " + p1.DecaBin(res));
								Console.WriteLine("El resultado en Hexadecimal es: "+p1.dechex(res));


							}
							else if (keyBaseP1 == 2)//Sumas Binario
							{
								Console.WriteLine("Ingrese los dos numeros");
								Console.WriteLine("Ingrese el primer nuemero");
								Num1 = Console.ReadLine();
								Console.WriteLine("Ingrese el segundo nuemero");
								Num2 = Console.ReadLine();

								num1 = p1.BinaDec(Convert.ToInt32(Num1));
								num2 = p1.BinaDec(Convert.ToInt32(Num2));
								res=num1 + num2;

								Console.WriteLine("\nEl resultado en Decimal es: " + res);
								Console.WriteLine("El resultado en Binario es: " + p1.DecaBin(res));
								Console.WriteLine("El resultado en Hexadecimal es: " + p1.dechex(res));


							}
							else if (keyBaseP1 == 3)//Sumas Hexadecimal
							{
								Console.WriteLine("Ingrese los dos numeros");
								Console.WriteLine("Ingrese el primer nuemero");
								Num1 = Console.ReadLine();
								Console.WriteLine("Ingrese el segundo nuemero");
								Num2 = Console.ReadLine();

								num1 = p1.hexdec(Num1);
								num2 = p1.hexdec(Num2);
								res = num1 + num2;

								Console.WriteLine("\nEl resultado en Decimal es: " + res);
								Console.WriteLine("El resultado en Binario es: " + p1.DecaBin(res));
								Console.WriteLine("El resultado en Hexadecimal es: " + p1.dechex(res));


							}
							else if(keyBaseP1 == 4)//Salir
                            {
								break;
                            }
                                


						}
						else if (keyMenuP1 == 2)//Quiere restar
						{
							Console.WriteLine("Seleccione la base");
							Console.WriteLine("1) Decimal");
							Console.WriteLine("2) Binario");
							Console.WriteLine("3) Hexadecimal");
							Console.WriteLine("4) Salir");
							keyBaseP1 = Convert.ToInt32(Console.ReadLine());

							if (keyBaseP1 == 1)//Resta decimal
							{
								Console.WriteLine("Ingrese los dos numeros: ");
								Console.Write("Ingrese el primer numero: ");
								num1 = Convert.ToInt32(Console.ReadLine());
								Console.Write("Ingrese el segundo numero: ");
								num2 = Convert.ToInt32(Console.ReadLine());

								res = num1 - num2;

								Console.WriteLine("\nEl resultado en Decimal es: " + res);
								Console.WriteLine("El resultado en Binario es: " + p1.DecaBin(res));
								Console.WriteLine("El resultado en Hexadecimal es: " + p1.dechex(res));
							}
							else if (keyBaseP1 == 2)//Resta binaria
							{
								Console.WriteLine("Ingrese los dos numeros: ");
								Console.Write("Ingrese el primer numero: ");
								num1 = Convert.ToInt32(Console.ReadLine());
								Console.Write("Ingrese el segundo numero: ");
								num2 = Convert.ToInt32(Console.ReadLine());

								int dec1 = p1.BinaDec(num1);
								int dec2 = p1.BinaDec(num2);

								res = dec1 - dec2;

								Console.WriteLine("\nEl resultado en Decimal es: " + res);
								Console.WriteLine("El resultado en Binario es: " + p1.DecaBin(res));
								Console.WriteLine("El resultado en Hexadecimal es: " + p1.dechex(res));

							}
							else if(keyBaseP1 == 3)
							{
								
								Console.WriteLine("Ingrese los dos numeros: ");
								Console.Write("Ingrese el primer numero: ");
								Num1 = Console.ReadLine();
								Console.Write("Ingrese el segundo numero: ");
								Num2 = Console.ReadLine();

								int dec1 = p1.hexdec(Num1);
								int dec2 = p1.hexdec(Num2);

								res = dec1 - dec2;


								Console.WriteLine("\nEl resultado en Decimal es: " + res);
								Console.WriteLine("El resultado en Binario es: " + p1.DecaBin(res));
								Console.WriteLine("El resultado en Hexadecimal es: " + p1.dechex(res));
							}
							else if (keyBaseP1 == 4)//Salir
							{
								break;
							}

						}
						else if(keyMenuP1 == 4)
                        {
							break;
                        }
						



					}
				}
				else if(keyMenu==2)//Problema 2
                {
					Console.Clear();
					Problema2 p2 = new Problema2();
					p2.main();
					
                }
				else if (keyMenu == 3)//Problema 3
				{
					Console.Clear();
					Problema3 p3 = new Problema3();
					p3.main();
				}
				else if (keyMenu == 4)//Problema 4
				{
					Console.Clear();
					Problema4 p4 = new Problema4();
					p4.main();

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
