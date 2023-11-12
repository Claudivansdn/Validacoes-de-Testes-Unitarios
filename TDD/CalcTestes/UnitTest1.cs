namespace CalcTestes;
using Calculadora.Models;

public class UnitTest1
{
    public Calculadora ConstruirClasse(){
        string data = "12/11/2023";
        Calculadora calc = new Calculadora(data);
        return calc;
    }


    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData(5, 4, 9)]
    public void TestSomar(int val1, int val2, int resultado)
    {
        Calculadora calc = ConstruirClasse();

        int resultCalc = calc.Somar(val1, val2);

        Assert.Equal(resultado, resultCalc);
    }

    [Theory]
    [InlineData (2, 1, 1)]
    [InlineData(5, 4, 1)]
    public void TestSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calc = ConstruirClasse();

        int resultCalc = calc.Subtrair(val1, val2);

        Assert.Equal(resultado, resultCalc);
    }

    [Theory]
    [InlineData (2, 1, 2)]
    [InlineData(5, 4, 20)]
    public void TestMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calc = ConstruirClasse();

        int resultCalc = calc.Multiplicar(val1, val2);

        Assert.Equal(resultado, resultCalc);
    }

    [Theory]
    [InlineData (2, 1, 2)]
    [InlineData(5, 5, 1)]
    public void TestDividir(int val1, int val2, int resultado)
    {
        Calculadora calc = ConstruirClasse();

        int resultCalc = calc.Dividir(val1, val2);

        Assert.Equal(resultado, resultCalc);
    }

    [Fact]
    public void TestDividirPorZero()
    {
        Calculadora calc = ConstruirClasse();

        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3,0));
    }

    [Fact]
    public void TestHistoricoVazio()
    {
        Calculadora calc = ConstruirClasse();
        calc.Somar(2,5);
        calc.Somar(2,8);
        calc.Somar(4,8);
        calc.Somar(8,8);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}