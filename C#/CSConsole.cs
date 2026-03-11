using System;
using System.IO;

public class Program
{

    public static void Main()
    {
        Util util = new Util();
        Ficha[] fichas = new Ficha[25];
        FicheiroTexto ficheiro = new FicheiroTexto();

        char op;

        do
        {
            util.MenuGeral();
            util.InicializarArray(fichas);
            Console.WriteLine("Qual a opção?");
            op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
				case 'A':
                    Console.Clear();
                    ficheiro.MostrarFichaPos();
					Console.ReadLine();
                    break;
					
				case 'B':
					Console.Clear();
					ficheiro.MaiorNome();
					Console.ReadLine();
					break;
					
                case 'L':
                    Console.Clear();
                    util.Listar(fichas);
					Console.ReadLine();
                    break;

                case 'E':
                    Console.Clear();
                    ficheiro.EscreverArray(fichas);
					Console.ReadLine();
                    break;
					
					
				case 'J':
					Console.Clear();
					ficheiro.ListarDadosFicheiro();
					Console.ReadLine();
					break;
					
					
				case 'K':
					Console.Clear();
					ficheiro.ListarDadosFicheiroIndividual();
					Console.ReadLine();
					break;
						
				case 'S':
					Console.Clear();
					ficheiro.ContarSexos();
					Console.ReadLine();
					break;


                case '0':
                    Console.Clear();
                    Console.WriteLine("Programa a terminar...");
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Opcao invalida");
                    break;
            }

        } while (op != '0');

    }



    // Classe para utlidades ( Menu, Incializações )
    class Util
    {
        public void MenuGeral()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("L. Listar Array");
            Console.WriteLine("E. Escrever Array num ficheiro");
			Console.WriteLine("J. Listar Dados do Ficheiro");
            Console.WriteLine("K. Listar Dados do Ficheiro Individual");
			Console.WriteLine("S. Mostrar número de Mulheres e Homens");
			Console.WriteLine("A. Mostrar ficha em posição escolhida");
			Console.WriteLine("B. Mostrar maior nome");
            Console.WriteLine("																		   0 para terminar");
            Console.WriteLine("------------------------------------------------------------------------------------------");
        }

		
		// Inicializar o Array
        public void InicializarArray(Ficha[] fichas)
        {

            fichas[0] = new Ficha();    fichas[0].nome = "Ana";         fichas[0].sexo = 'F';   fichas[0].freguesia = "Maximinos";  fichas[0].anoNascimento = 1980;
            fichas[1] = new Ficha();    fichas[1].nome = "Bela";        fichas[1].sexo = 'F';   fichas[1].freguesia = "Gualtar";    fichas[1].anoNascimento = 1982;
            fichas[2] = new Ficha();    fichas[2].nome = "Carlos";      fichas[2].sexo = 'M';   fichas[2].freguesia = "Lomar";      fichas[2].anoNascimento = 1981;
            fichas[3] = new Ficha();    fichas[3].nome = "Celso";       fichas[3].sexo = 'M';   fichas[3].freguesia = "Lomar";      fichas[3].anoNascimento = 1980;
            fichas[4] = new Ficha();    fichas[4].nome = "Daniel";      fichas[4].sexo = 'M';   fichas[4].freguesia = "Espinho";    fichas[4].anoNascimento = 1980;
            fichas[5] = new Ficha();    fichas[5].nome = "Diogo";       fichas[5].sexo = 'M';   fichas[5].freguesia = "Ferreiros";  fichas[5].anoNascimento = 1977;
            fichas[6] = new Ficha();    fichas[6].nome = "Elvira";      fichas[6].sexo = 'F';   fichas[6].freguesia = "Maximinos";  fichas[6].anoNascimento = 1977;
            fichas[7] = new Ficha();    fichas[7].nome = "Fernanda";    fichas[7].sexo = 'F';   fichas[7].freguesia = "Lamas";      fichas[7].anoNascimento = 1983;
            fichas[8] = new Ficha();    fichas[8].nome = "Filipe";      fichas[8].sexo = 'M';   fichas[8].freguesia = "Maximinos";  fichas[8].anoNascimento = 1989;
            fichas[9] = new Ficha();    fichas[9].nome = "Guilherme";   fichas[9].sexo = 'M';   fichas[9].freguesia = "Espinho";    fichas[9].anoNascimento = 1980;
            fichas[10] = new Ficha();   fichas[10].nome = "Hilda";      fichas[10].sexo = 'F';  fichas[10].freguesia = "Cabreira";  fichas[10].anoNascimento = 1981;
            fichas[11] = new Ficha();   fichas[11].nome = "Ivo";        fichas[11].sexo = 'M';  fichas[11].freguesia = "Espinho";   fichas[11].anoNascimento = 1982;
            fichas[12] = new Ficha();   fichas[12].nome = "Jaime";      fichas[12].sexo = 'M';  fichas[12].freguesia = "Gualtar";   fichas[12].anoNascimento = 1975;
            fichas[13] = new Ficha();   fichas[13].nome = "Maria";      fichas[13].sexo = 'F';  fichas[13].freguesia = "Gualtar";   fichas[13].anoNascimento = 2001;
            fichas[14] = new Ficha();   fichas[14].nome = "Alice";      fichas[14].sexo = 'F';  fichas[14].freguesia = "Gualtar";   fichas[14].anoNascimento = 1988;
            fichas[15] = new Ficha();   fichas[15].nome = "Rui";        fichas[15].sexo = 'M';  fichas[15].freguesia = "Maximinos"; fichas[15].anoNascimento = 1987;
            fichas[16] = new Ficha();   fichas[16].nome = "Samuel";     fichas[16].sexo = 'M';  fichas[16].freguesia = "Maximinos"; fichas[16].anoNascimento = 1999;
            fichas[17] = new Ficha();   fichas[17].nome = "Teodoro";    fichas[17].sexo = 'M';  fichas[17].freguesia = "Maximinos"; fichas[17].anoNascimento = 1985;
            fichas[18] = new Ficha();   fichas[18].nome = "Zacarias";   fichas[18].sexo = 'M';  fichas[18].freguesia = "Gualtar";   fichas[18].anoNascimento = 1986;
            fichas[19] = new Ficha();   fichas[19].nome = "Tiago";      fichas[19].sexo = 'M';  fichas[19].freguesia = "Lindoso";   fichas[19].anoNascimento = 1995;
            fichas[20] = new Ficha();   fichas[20].nome = "Laura";      fichas[20].sexo = 'F';  fichas[20].freguesia = "Lanheses";  fichas[20].anoNascimento = 2002;
            fichas[21] = new Ficha();   fichas[21].nome = "Clara";      fichas[21].sexo = 'F';  fichas[21].freguesia = "Amonde";    fichas[21].anoNascimento = 1986;
            fichas[22] = new Ficha();   fichas[22].nome = "Ariel";      fichas[22].sexo = 'F';  fichas[22].freguesia = "Amonde";    fichas[22].anoNascimento = 2012;
            fichas[23] = new Ficha();   fichas[23].nome = "Sofia";      fichas[23].sexo = 'F';  fichas[23].freguesia = "Montaria";  fichas[23].anoNascimento = 1999;
            fichas[24] = new Ficha();   fichas[24].nome = "Orlando";    fichas[24].sexo = 'M';  fichas[24].freguesia = "Outeiro";   fichas[24].anoNascimento = 2000;
        }
		
		
		// Listar o array
		public void Listar(Ficha[] fichas)
		{
            Console.WriteLine("N. NOME                          LOCAL            SEXO  ANO");
            Console.WriteLine("-------------------------------------------------------------");

            for (int i = 0; i < fichas.Length; i++)
            {
                Console.Write(
                    $"{(i + 1).ToString().PadLeft(4)}: " +
                    $"{fichas[i].nome.PadRight(28, '.')}  " +
                    $"{fichas[i].freguesia.PadRight(15, '.')}  " +
                    $"{fichas[i].sexo}     " +
                    $"{fichas[i].anoNascimento}\n"
                );

            }

            Console.WriteLine("  -------------------------------------------------------------");

        }
    }


    // Classe para a ficha
    class Ficha
    {
        public string nome;
        public string freguesia;
        public char sexo;
        public int anoNascimento;

    }


    class FicheiroTexto
    {
		
		// Escrever o array num ficheiro
        public void EscreverArray(Ficha[] fichas)
        {				
            using (StreamWriter ficheiro = new StreamWriter("Fichas.txt"))
            {
                for (int i = 0; i < fichas.Length; i++)
                {
                    ficheiro.WriteLine(fichas[i].nome + ";" + fichas[i].freguesia + ";" + fichas[i].sexo + ";" + fichas[i].anoNascimento);
                }

                Console.WriteLine("Ficheiro criado com sucesso");
            }
			
        }
		
		
		// Listar os dados do Ficheiro
		public void ListarDadosFicheiro()
		{
			if (File.Exists("Fichas.txt"))
				{
					
					// Chama a função para ler o ficheiro e escrever no ecrâ
					using (StreamReader ficheiro = new StreamReader ("Fichas.txt"))
					{
						string linhaFicheiro;
						
						while ((linhaFicheiro = ficheiro.ReadLine()) != null) 
						{
                			Console.WriteLine(linhaFicheiro);
						}
					}
				}	
				
				else 
				{
					Console.WriteLine("Ficheiro vazio ou inexistente");
				}
		}
		
		
		// Listar dados individuais do ficheiro	
		public void ListarDadosFicheiroIndividual()	
		{
			Stringuice stringuice = new Stringuice();
			
			using (StreamReader ficheiro = new StreamReader ("Fichas.txt"))
			{
				string linhaFicheiro = ficheiro.ReadLine();
				
				Console.WriteLine(stringuice.SacaNome(linhaFicheiro));
				Console.WriteLine(stringuice.SacaFreguesia(linhaFicheiro));
				Console.WriteLine(stringuice.SacaSexo(linhaFicheiro));
				Console.WriteLine(stringuice.SacaAno(linhaFicheiro));
				
			}
				
		}
		
		
		// Conta o numero de pessoas de cada sexo
		public void ContarSexos()
		{
			Stringuice stringuice = new Stringuice();
			int f = 0;
			int m = 0;
			string linha;
			using (StreamReader ficheiro = new StreamReader ("Fichas.txt"))
			{
				while ((linha = ficheiro.ReadLine()) != null) 
				{
                	if (stringuice.SacaSexo(linha) == "F")
					{
						f++;
					}
					
					else
					{
						m++;
					}
				}
				
				Console.WriteLine("O total de Mulheres é " + f + " e o total de de Homens é " + m);
			}	
		}

		// Solicita ao utilizador uma posicao e mostra a ficha dessa posicao
        public void MostrarFichaPos()
        {
            Console.WriteLine("Qual a posição do ficheiro a verificar");
            int pos = Convert.ToInt32(Console.ReadLine());
            int contador = 0;
            string linha;
            Stringuice stringuice = new Stringuice();
            
			if (File.Exists("Fichas.txt"))
			{
				using (StreamReader ficheiro = new StreamReader("Fichas.txt"))
				{
					while((linha = ficheiro.ReadLine()) != null)
					{
						if(pos-1 == contador)
						{
						Console.WriteLine("Na posição " + pos + "está a seguinte ficha:\n");
						Console.WriteLine("Nome: " + stringuice.SacaNome(linha));
						Console.WriteLine("Freguesia: " + stringuice.SacaFreguesia(linha));
						Console.WriteLine("Sexo: " + stringuice.SacaSexo(linha));
						Console.WriteLine("Ano Nascimento: " + stringuice.SacaAno(linha));
						break;
						}
						contador++;
					}
				}
			}	
			
			else
			{
				Console.WriteLine("Ficheiro vazio ou inexistente");
			}
        }
		
		// Verificar qual o maior nome
		public void MaiorNome()
		{
			Stringuice stringuice = new Stringuice();
			string maiorNome = ""; 
			string linha;
			int nLetras = 0;
			
			using (StreamReader ficheiro = new StreamReader("Fichas.txt"))
				   {
					   while ((linha = ficheiro.ReadLine()) != null)
					   {
						   if (stringuice.SacaNome(linha).Length > nLetras)
						   {
							   maiorNome = stringuice.SacaNome(linha);
							   nLetras = stringuice.SacaNome(linha).Length;
						   }
					   }						   
				   }
			Console.WriteLine("O maior nome é " + maiorNome + " que tem " + nLetras + " letras");		   
				   
		}
			
	}
		
		
	class Stringuice()
			
		{
			
			// Saca Nome
			public string SacaNome(string linha)
			{
                // Usando o metodo substring com indexOf
				return linha.Substring(0, linha.IndexOf(';'));		
			}
			
			
			
			// Saca Freguesia
			public string SacaFreguesia(string linha)
			{
                // usando o metodo Split 
				return linha.Split(";")[1];
				
			}
			
			
			// Saca Sexo
			public string SacaSexo(string linha)
			{
				return linha.Split(";")[2];
			}
			
			
			// Saca AnoNascimento
			public string SacaAno(string linha)
			{
				return linha.Split(";")[3];
			}
		}	
	
	
}
