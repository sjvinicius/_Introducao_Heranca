namespace _Introducao_Heranca.Class
{
    public class Pessoa
    {

        //Atributos
        public string nome;
        public string sobrenome;
        public string numCartao;
        public string cvv;
        public string validade;


        //Métodos
        public string Saudacoes()
        {

            return $"Olá {nome}, Seja Bem-Vindo. ";

        }

        //Exibir Dados
        public string Dados()
        {

            return $"Nome Completo: {nome} {sobrenome}\nNumero do Cartão: {numCartao}\nCVV: {cvv}\n Validade: {validade}";

        }

    }
}