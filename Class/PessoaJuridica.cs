namespace _Introducao_Heranca.Class
{
    public class PessoaJuridica:Pessoa
    {
        //Atributos
        public string cnpj;
        public string nomeDaEmpresa;


        //Métodos
        public string dadosExtraJur()
        {

            return $"cnpj: {cnpj}\nNome da Empresa: {nomeDaEmpresa}";

        }
    }
}