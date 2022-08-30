using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco_
{
	class Program
	{
		static void Main(string[] args)
		{
			/*ingresar 5 edades y organizarla de menor a mayor*/
			/*
			Console.WriteLine("Ingrese las 5 edades");

			int[] edades = new int[5];

			edades[0] = int.Parse(Console.ReadLine());
			edades[1] = int.Parse(Console.ReadLine());
			edades[2] = int.Parse(Console.ReadLine());
			edades[3] = int.Parse(Console.ReadLine());
			edades[4] = int.Parse(Console.ReadLine());

			int t;

			for(int i=0;i<5;i++)
			{
				for(int j = 4 ; j>0;j--)
				{
					if(edades[j-1]>edades[j])
					{
						t = edades[j];
						edades[j] = edades[j-1];
						edades[j-1] = t;
					}
				}
			}

			for(int i=0; i<5; i++)
			{
				Console.WriteLine("Las edades organizadas son " + edades[i]);
			}*/


			/*un banco tiene la  necesidad de edesarrollar un sistema que le permite ingresar 3 clientes su nombre, hacer depositos
			, hace retiros , calcular la cantidad de dinero que hay depositado en total en el banco y lo que le corresponde
			a cada cliente de ese total
			*/

			Persona Fernando = new Persona("Fernando","Perez","123456789","zapato",1000000);
			Persona Juliana = new Persona("Juliana", "Gomez", "987654321","moño", 200);
			Persona Juanito = new Persona("Juanito", "Ossa", "3254761234","perro", 1500000);
			Persona Raul = new Persona("Raul", "Hernandez", "45671234", "gato", 700500000);

			Banco ELDORADO = new Banco(Fernando, Juliana, Juanito,Raul);

			int x = 0;

			while (x == 0)
			{
				Console.WriteLine("Ingresa el nombre y la contraseña");
				string name = Console.ReadLine().Trim();
				string contra = Console.ReadLine().Trim();

				if (Fernando.Nombre == name && Fernando.Contra1 == contra)
				{

					while (x == 0)
					{
						Console.WriteLine("Hola Fernando");
						Console.WriteLine("Ingresa 1 para recargar, 2 para retirar, 3 para ver saldo");
						int z = int.Parse(Console.ReadLine());
						int c = 0;
						if (z == 1)
						{
							Console.WriteLine("Ingrese el valor a recargar");
							c = int.Parse(Console.ReadLine());

							Banco.Recargar(Fernando, c);

						}
						else if (z == 2)
						{
							Console.WriteLine("Ingrese el valor a retirar");
							c = int.Parse(Console.ReadLine());

							Banco.Retirar(Fernando, c);
						}
						else if (z == 3) 
						{
							Banco.ImprimirUB(Fernando);
						}else
						{
							Console.WriteLine("Error, digite de nuevo");
						}

						Console.WriteLine("Si deseas continuar ingresa x, sino y");
						string v = Console.ReadLine().Trim();
						if (v == "x")
						{
							x = 0;
						}
						else
						{
							x = 1;
						}
					}



				}
				else if (Juliana.Nombre == name && Juliana.Contra1 == contra)
				{

					while (x == 0)
					{
						Console.WriteLine("Hola Juliana");
						Console.WriteLine("Ingresa 1 para recargar, 2 para retirar, 3 para ver saldo");
						int z = int.Parse(Console.ReadLine());
						int c;
						if (z == 1)
						{
							Console.WriteLine("Ingrese el valor a recargar");
							c = int.Parse(Console.ReadLine());

							Banco.Recargar(Juliana, c);

						}
						else if (z == 2)
						{
							Console.WriteLine("Ingrese el valor a retirar");
							c = int.Parse(Console.ReadLine());

							Banco.Retirar(Juliana, c);
						}
						else if (z == 3) 
						{
							Banco.ImprimirUB(Juliana);
						}else
						{
							Console.WriteLine("Error, digite de nuevo");
						}

						Console.WriteLine("Si deseas continuar ingresa x, sino y");
						string v = Console.ReadLine();
						if (v == "x")
						{
							x = 0;
						}
						else
						{
							x = 1;
						}





					}
				}
				else if (Juanito.Nombre == name && Juanito.Contra1 == contra)
				{
					while (x == 0)
					{
						Console.WriteLine("Hola Juanito");
						Console.WriteLine("Ingresa 1 para recargar, 2 para retirar, 3 para ver saldo");
						int z = int.Parse(Console.ReadLine());
						int c = 0;
						if (z == 1)
						{
							Console.WriteLine("Ingrese el valor a recargar");
							c = int.Parse(Console.ReadLine());

							Banco.Recargar(Juanito, c);

						}
						else if (z == 2)
						{
							Console.WriteLine("Ingrese el valor a retirar");
							c = int.Parse(Console.ReadLine());

							Banco.Retirar(Juanito, c);
						}
						else if (z ==3) 
						{
							Banco.ImprimirUB(Juanito);
						}else
						{
							Console.WriteLine("Error, digite de nuevo");
						}

						Console.WriteLine("Si deseas continuar ingresa x, sino y");
						string v = Console.ReadLine();
						if (v == "x")
						{
							x = 0;
						}
						else
						{
							x = 1;
						}





					}
				} else if (Raul.Nombre == name && Raul.Contra1 == contra) 
				{
					while (x == 0) 
					{
                        Console.WriteLine("Ingresa 1 para ver total de las bolsas, 2 para ver tu bolsa");
						int z = int.Parse(Console.ReadLine());

						if (z == 1)
						{
							Banco.ImprimirB(Fernando, Juliana, Juanito);
						}
						else if (z == 2)
						{
							Banco.ImprimirUB(Raul);
						}
						else
						{
                            Console.WriteLine("Error en la digitacion");
						}

						Console.WriteLine("Si deseas continuar ingresa x, sino y");
						string v = Console.ReadLine();
						if (v == "x")
						{
							x = 0;
						}
						else
						{
							x = 1;
						}
					}
				}else
				{
					Console.WriteLine("Si deseas continuar ingresa x, sino y");
					string v = Console.ReadLine();
					if (v == "x")
					{
						x = 0;
					}
					else
					{
						x = 1;
					}
				}

				

			}
			Console.ReadKey();
		}

		public class Persona
		{
			private string nombre;
			private string apellido;
			private string cc;
			private string Contra;
			private int bolsa;

            public Persona(string nombre, string apellido, string cc, string contra, int bolsa)
            {
                this.Nombre = nombre;
                this.Apellido = apellido;
                this.Cc = cc;
                Contra1 = contra;
				this.Bolsa = bolsa;

            }

            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido { get => apellido; set => apellido = value; }
            public string Cc { get => cc; set => cc = value; }
            public string Contra1 { get => Contra; set => Contra = value; }
            public int Bolsa { get => bolsa; set => bolsa = value; }
        }

		public class Banco
		{
			public Persona usuario;
			
			public Persona usuario1;
			
			public Persona usuario2;

			public Persona admin;


			public Banco(Persona usuario, Persona usuario1, Persona usuario2,Persona admin)
            {
                this.usuario = usuario;
                this.usuario1 = usuario1;
                this.usuario2 = usuario2;
				this.admin = admin;
            }

			static public void Recargar(Persona U, int total) 
			{
				U.Bolsa += total;
                Console.WriteLine("Recarga exitosa");

			}

			 static public void Retirar(Persona U, int total)
			{
				U.Bolsa -= total;
				Console.WriteLine("Retiro exitoso");
			}

			static public void ImprimirB(Persona A, Persona B, Persona C)
			{
				Console.WriteLine($"La bolsa de {A.Nombre} es {A.Bolsa}");
				Console.WriteLine($"La bolsa de {B.Nombre} es {B.Bolsa}");
				Console.WriteLine($"La bolsa de {C.Nombre} es {C.Bolsa}");
				Console.WriteLine($"EL total del banco es {A.Bolsa + B.Bolsa + C.Bolsa}");
			}

			static public void ImprimirUB(Persona A) 
			{
                Console.WriteLine($"Tu bolsa tiene un total de {A.Bolsa}");
			}
		}
    } 
}
