namespace Atividade_Banco
{
    public class ContaBancaria
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(int numero, double saldo) {
            this.Numero = numero;
            this.Saldo = saldo;
        }

        public void Depositar(double valor) {
            this.Saldo += valor;
            Extrato(1, valor);
        }

        public void Sacar(double valor) {
            if (this.Saldo >= valor) {
                this.Saldo -= valor;
                Extrato(2, valor);
            } else {
                Console.WriteLine("Saldo insuficiente, você tentou sacar R$" + valor);
            }
        }

        public void Extrato(int operacao, double valor) {
            switch (operacao) {
                case 1:
                    Console.WriteLine($"Depósito de R${valor} efetuado com sucesso!");
                    break;
                case 2:
                    Console.WriteLine($"Saque de R${valor} efetuado com sucesso!");
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }
            Console.WriteLine("Saldo atual: R$" + this.Saldo);
        }
    }
}