using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        //Implementado: Variável "texto" e "resultadoEsperado" da seção Arrange corrigidas!

        // Arrange
        var texto = "a";
        var resultadoEsperado = 1;

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        //Implementado: Chamada do método "ContemCaractere" da seção Act corrigida!
        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //Implementado: Assert.True corrigido com base no retorno da chamada ao método!
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //Implementado: Assert.False corrigido com base no retorno da chamada ao método!
        Assert.False(resultado);
    }

    //Implementado:Anotação [Fact] corrigida!
    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        //Implementado: Variável "textoProcurado" na seção Arrange corrigida!

        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}
