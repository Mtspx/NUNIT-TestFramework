using ValidadorCPF.models;

namespace TesteValidadorCPF;

public class Tests
{
    Usuario usuario = new Usuario("mateus","5555555555");

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ValidarCPF()
    {
        string cpf = ("11111111100");

        if(usuario.ValidarCPF(cpf))
        {
            Assert.Pass();
        }
        else
        {
            Assert.Fail();
        }
    }

    [Test]
    public void ValidarCPFInvalido()
    {
        string cpf = ("11111110");

        if(usuario.ValidarCPF(cpf))
        {
            Assert.Pass();
        }
        else
        {
            Assert.Fail();
        }
    }
}