namespace _Introducao_Heranca.Class
{
    public class PessoaFisica : Pessoa
    {

        //Atributos
        public string rg;
        public string cpf;


        //Métodos

        /* Validar valores de entrada CPF */
        public bool ValidarCPF() {

            if ( cpf != "" )
            {
                return true;
            }

            return false;
        }

        /* Validar valores de entrada RG */
        public bool ValidarRG() {

            if ( rg != "" )
            {
                return true;
            }

            return false;
        }
    }
}