using System;

namespace bank_account
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Marcos");

            Console.WriteLine(minhaConta.ToString());
        }
    }
}
