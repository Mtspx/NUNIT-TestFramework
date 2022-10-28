using Calculadora.models;

namespace TesteCalculadora;

public class Tests
{
    Operacoes operacoes = new Operacoes();

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        float resultado = operacoes.Somar(2,2);
        if(resultado == 4)
        {
            Assert.Pass();
        }
        else
        {
            Assert.Fail();
        }
    }

    [Test]
    public void Test2()
    {
        float resultado = operacoes.Multiplicar(6,5); 
        if(resultado == 25)
        {
            Assert.Pass();
        }
        else
        {
            Assert.Fail();
        }
    }

}