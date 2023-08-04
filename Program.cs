using System;

namespace VerificaVotos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veja se você é obrigado a votar, digitando seu ano de nascimento abaixo: ");
            int respostaUser = Convert.ToInt32(Console.ReadLine());

            int idade = verificaIdade(2023, respostaUser); 

            if (idade <= 17)
            {
                Console.WriteLine("Você tem " + idade + " anos. Portanto, seu voto é opcional!"); 
            } 
            else if (idade <= 65)
            {
                Console.WriteLine("Você tem " + idade + " anos. Portanto, seu voto é obrigatório!");
            } else
            {
                Console.WriteLine("Você tem " + idade + " anos. Portanto, seu voto é opcional!");
            }
        }

        public static int verificaIdade(int anoAtual, int dataNascimento)
        {
            return anoAtual - dataNascimento;
        }
        
    }
}

