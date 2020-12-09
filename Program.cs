using System;
using _Introducao_Heranca.Class;

namespace _Introducao_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variaveis
            char pestype;
            
            Console.WriteLine("OLÁ USUARIO");
            Console.WriteLine("Por favor preencha alguns dados...");

            //Instanciando Objetos

            PessoaFisica p1 = new PessoaFisica();

            Console.Write("Insira seu nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Insira seu sobrenome: ");
            p1.sobrenome = Console.ReadLine();
            Console.Write("Insira o numero do cartão (somente números): ");
            p1.numCartao = Console.ReadLine();
            Console.Write("Insira o CVV do cartão: ");
            p1.cvv = Console.ReadLine();
            Console.Write("Insira a data de validade do cartão (dd/mm/yyyy): ");
            p1.validade = Console.ReadLine();

            Console.WriteLine("Você é uma Pessoa (1)Fisica ou (2)Jurídica? ");
            pestype = char.Parse( Console.ReadLine() );

            if (pestype == '1') 
            {
                

                Console.Write("Insira o seu CPF: ");
                p1.cpf = Console.ReadLine();

                p1.ValidarCPF();

                Console.Write("Insira o seu RG: ");
                p1.rg = Console.ReadLine();

                p1.ValidarRG();

                Console.WriteLine($"\n\n {p1.nome}" );
                Console.WriteLine($" {p1.sobrenome}" );
                Console.WriteLine($" {p1.numCartao}" );
                Console.WriteLine($" {p1.cvv}" );
                Console.WriteLine($" {p1.validade}" );
                Console.WriteLine($" {p1.rg}" );
                Console.WriteLine($" {p1.cpf}" );

            } else if ( pestype == '2' )
            {
                PessoaJuridica p1j = new PessoaJuridica();

                Console.Write("Insira o CNPJ: ");
                p1j .cnpj = Console.ReadLine();
                Console.Write("Insira o nome da sua empresa: ");
                p1j.nomeDaEmpresa = Console.ReadLine();

                Console.WriteLine($"\n\n {p1.nome}" );
                Console.WriteLine($" {p1.sobrenome}" );
                Console.WriteLine($" {p1.numCartao}" );
                Console.WriteLine($" {p1.cvv}" );
                Console.WriteLine($" {p1.validade}" );
                Console.WriteLine($" {p1j.cnpj}" );
                Console.WriteLine($" {p1j.nomeDaEmpresa}" );

            }




        }
    }
}
