// 1 - bibliotecas
using NUnit.Framework;
using Calc; // namespace da calculadora

// 2 - namespace
namespace Calculadora139.Tests;

// 3 - CLasses

[TestFixture] // Marcação de que a classe trabalha com testes parametrizados
public class Tests
{
    // 3.1 - Atributos
  
    // 3.1 - Funções e Métodos - Função retorna algo, método apenas executa algo

    
    // Função de Leitura de Dados a partir de um arquivo CSV 
    public static IEnumerable<TestCaseData> lerDadosDeTeste(string operacao)
    {
        string caminhoMassa = @"C:\iterasys\ProjetoCalculadora\Calculadora139.Tests\fixtures\"; //caminho do arquivo CSV

        switch(operacao)
        {
            case "+":
                caminhoMassa += @"massaSomar.csv";
                break;

            case "-":
                caminhoMassa += @"massaSubtrair.csv"; //exemplo
                break; 
        }

        using (var leitor = new StreamReader(caminhoMassa))
        {
            // pular a primeira linha - cabeçalho
            leitor.ReadLine();


            // Repetir as ações ate a condição se realizar.
            // nesse caso, seria ate o arquivo CSV terminar.
            // repita enquanto não for o final
            while(!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine(); // lendo uma linha 
                var valores = linha.Split(","); // dividir em campos

                yield return new TestCaseData(int.Parse(valores[0]), int.Parse(valores[1]), int.Parse(valores[2]));

            }
          

        }

    }

    [Test] // Método de teste
    public void testSomarDoisNumeros()
    {
        // Triple A = AAA

        // Configura
            // Dados de entrada
        int num1 = 15;
        int num2 = 35;

           // Resultado esperado/ Saida
        int resultadoEsperado = 50;

        // Executa
           // Chama a função de somar e grava o resultado na variavel
        int resultadoAtual = Calculadora.somarDoisNumeros(num1, num2);

        // Valida
        Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual));
    } // Fecha o teste da soma


    [Test]
    public void testSubtratirDoisNumeros()
    {
        int num1 = 20; //Entrada
        int num2 = 8; //Entrada
        int resultadoEsperado = 12; //Saida
        int resultadoAtual = Calculadora.subtrairDoisNumeros(num1, num2); // Subtrai e grava o resultado

        Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual)); //Testa

    }

    [Test]
    public void testMultiplicarDoisNumeros()
    {
        int num1 = 20;
        int num2 = 4;
        int resultadoEsperado = 80;
        int resultadoAtual = Calculadora.multiplicarDoisNumeros(num1, num2);

        Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual));
    }

     [Test]
    public void testDividirDoisNumeros()
    {
        int num1 = 20;
        int num2 = 4;
        int resultadoEsperado = 5;
        int resultadoAtual = Calculadora.dividirDoisNumeros(num1, num2);

        Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual));
    }

     [Test]
    public void testDividirPorZero()
    {
        int num1 = 20;
        int num2 = 0;
        int resultadoEsperado = 0;
        int resultadoAtual = Calculadora.dividirDoisNumeros(num1, num2);

        Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual));
    }


// Configura
[TestCase(5,8,13)]
    public void testSomarDoisNumerosTC(int num1, int num2, int resultadoEsperado)
    {
        // Executa
    int resultadoAtual = Calculadora.somarDoisNumeros(num1, num2);
        // Valida
    Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual));
    }

    // Configura
[TestCase(5,8,13)]
    public void testSomarDoisNumerosTC2(int num1, int num2, int resultadoEsperado)
    {
        // Executa / Valida
    Assert.That(Calculadora.somarDoisNumeros(num1, num2), Is.EqualTo(resultadoEsperado));
    }


// Teste Data Driven (leitura de arquivo de massa)
[Test, TestCaseSource("lerDadosDeTeste", new object[] { "+" })]
    public void testSomarDoisNumerosDD(int num1, int num2, int resultadoEsperado)
    {
        // Executa / Valida
    Assert.That(Calculadora.somarDoisNumeros(num1, num2), Is.EqualTo(resultadoEsperado));
    }
   
}

