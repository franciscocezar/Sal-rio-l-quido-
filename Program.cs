/* O programa deve ler os dados de um 
 * funcionário (nome, salário bruto e imposto). 
 * Em seguida, mostrar os dados do funcionário (nome e salário líquido). 
 * E então, aumentar o salário do funcionário com base em uma 
 * porcentagem dada (somente o salário bruto é afetado pela porcentagem) 
 * e mostrar novamente os dados do funcionário.
 */

using System;

namespace SalarioL
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario f = new Funcionario();


            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(f);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine());
            f.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + f);


        }
    }
}
