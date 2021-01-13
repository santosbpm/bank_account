using System;

namespace bank_account
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }

        private string Nome { get; set; }

        private double Saldo { get; set; }

        private double Credito { get; set; }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome) 
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }

        public bool Sacar(double valorSaque) 
        {
            // Validação de saldo suficiente

            if(this.Saldo - valorSaque < (this.Credito *-1)) {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            } else {
                this.Saldo -= valorSaque;
                Console.WriteLine($"Saldo atual da conta de {this.Nome} é {this.Saldo}");
                return true;
            }
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine($"Saldo atual da conta de {this.Nome} é {this.Saldo}");
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if(this.Sacar(valorTransferencia)) {
                contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "saldo " + this.Saldo + " | ";
            retorno += "Crédito " + this.Credito;
            return retorno;
        }
    }
}