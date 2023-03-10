/*
Crie uma classe chamada "ContaBancaria" que tenha dois atributos: "Saldo" e "Numero".
Crie dois métodos: "Depositar" e "Sacar". O método "Depositar" deve receber 
um valor como parâmetro e acrescentar esse valor ao saldo da conta. O método 
"Sacar" deve receber um valor como parâmetro e subtrair esse valor do saldo da conta,
 desde que haja saldo suficiente. Crie um objeto dessa classe e 
 utilize os métodos para realizar transações bancárias.	*/


using Atividade_Banco;

ContaBancaria conta = new ContaBancaria(1, 1000);
conta.Depositar(100);
conta.Sacar(1200);