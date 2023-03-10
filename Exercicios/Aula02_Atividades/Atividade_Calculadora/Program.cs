/*Crie uma classe chamada "Calculadora" que tenha dois métodos: "Somar" e "Subtrair". 
O método "Somar" deve receber dois números como parâmetros e retornar a soma desses números. 
O método "Subtrair" deve receber dois números como parâmetros e retornar a subtração desses números. 
Crie um objeto dessa classe e utilize os métodos para realizar operações matemáticas.*/

using Atividade_Calculadora;

Calculadora calculadora = new Calculadora();
Console.WriteLine(calculadora.Somar(2, 4));
Console.WriteLine(calculadora.Subtrair(6, 2));
