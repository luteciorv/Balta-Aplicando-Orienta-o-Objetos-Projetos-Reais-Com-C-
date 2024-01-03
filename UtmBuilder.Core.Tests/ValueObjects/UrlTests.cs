using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    private const string InvalidUrl = "banana";
    private const string ValidUrl = "https://balta.io";

    [TestMethod]
    [ExpectedException(typeof(InvalidUrlException))]
    public void Dado_uma_url_invalida_deve_levantar_uma_excecao()
    {
        new Url(InvalidUrl);
    }

    [TestMethod]
    public void Dado_uma_url_valida_nao_deve_levantar_uma_excecao()
    {
        new Url(ValidUrl);
        Assert.IsTrue(true);
    }
}
