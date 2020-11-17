using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir a operacao
            // Pedir o 1° numero
            // pedir o 2° numero

            Console.WriteLine("Digite a operação que deseja fazer \n Soma, Subtracao, Multiplicacao, Divisao");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o 1º numero");
            float num1 = float.Parse(Console.ReadLine());

            // ALT + SHIFT + Seta para baixo
            Console.WriteLine("Digite o 2º numero");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0;
            
            // if(operacao == "Soma"){

            // }else if(operacao == "Subtracao"){
            //     resultado = num1 / num2;
            // }else if(operacao == "Multiplicacao"){
            //     resultado = num1 - num2;
            // }else if(operacao == "Divisao"){
            //     resultado = num1 / num2;
            // }else{
            //     Console.WriteLine("Operação invalida!");
            // }

            switch(operacao){

                case "Soma":
                    resultado = num1+num2;
                    break;

                case "Subtracao":
                    resultado = num1-num2;
                    break;

                case "Multiplicacao":
                    resultado = num1*num2;
                    break;

                case "Divisao":
                    resultado = num1/num2;
                break;

                default:
                    Console.WriteLine("Operacao invalida");


                    
                 break;



                // Concatenação
                //Console.WriteLine("Calculo : "+num1" e "+num2+" = Resultado : "+resultado");

                // Interpolação
          
                
            }
            Console.WriteLine($"Calculo: {num1} e {num2} = Resultado : {resultado}");          
        }
    }
}
