// 1 - Namespace = Conjunto de Classes
using System.Diagnostics.Contracts;

namespace Calc;
// 2 - Bibliotecas = Conjunto de funções prontas

// 3 - Classe = entidade que vamos criar
public class Calculadora
{
    // 3.1 - Atributos = Caracteristicas / campos

    // 3.2 - Funções e Métodos
    public static int somarDoisNumeros(int num1, int num2)
    {
        return  num1 + num2;      
    } // Fim da função somarDoisNumeros

    public static int subtrairDoisNumeros(int num1, int num2)
    {
        return num1 - num2;
    }// Fim da função subtrairDoisNumeros

    public static int multiplicarDoisNumeros(int num1, int num2)
    {
        return num1 * num2;
    }// Fim da função multiplicarDoisNumeros

    public static int dividirDoisNumeros(int num1, int num2)
    {

        try // tentar realizar as seguintes operacões
        {
            return num1 / num2;
        }
        catch(System.DivideByZeroException) // se der erro faça isso
        {
            Console.WriteLine("Não é possivel dividir por zero");
            return 0;
        }
       
    }// Fim da função subtrairDoisNumeros

    public static void Main() // void é um metodo, ou seja, apenas faz alguma coisa e não retorna nada.
    {
    // chamar as 4 operações
    Console.WriteLine("5 + 7 = " + somarDoisNumeros(5, 7));
    Console.WriteLine("5 - 7 = " + subtrairDoisNumeros(5, 7));
    Console.WriteLine("5 * 7 = " + multiplicarDoisNumeros(5, 7));
    Console.WriteLine("5 / 7 = " + dividirDoisNumeros(5, 7));
    }

} // Fim da classe calculadora