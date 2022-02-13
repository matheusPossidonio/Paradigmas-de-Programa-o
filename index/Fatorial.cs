using System;

namespace index
{
    class Fatorial
    {
        public static Int32 fatorial (Int32 num) {
			if (num == 1) {
				return 1;
			}
			return num * fatorial (num - 1);
		}

	/*
        static void Main(string[] args)
        {
            Int32 num;
			String entrada;

			Console.Write ("Insira um numero inteiro para ser calculado seu fatorial: ");
			entrada = Console.ReadLine ();
			num = Convert.ToInt32 (entrada);

			Console.WriteLine("Fatorial de " + num + " é: " + fatorial(num));
           }
		   */
    }
}