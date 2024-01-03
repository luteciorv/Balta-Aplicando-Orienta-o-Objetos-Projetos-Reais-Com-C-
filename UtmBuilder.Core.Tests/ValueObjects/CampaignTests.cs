using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class CampaignTests
{
    [TestMethod]
    [ExpectedException(typeof(InvalidCampaignException))]
    public void Dado_um_source_invalido_deve_levantar_excecao()
    {
        new Campaign(string.Empty, "Medium", "Name");
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidCampaignException))]
    public void Dado_um_medium_invalido_deve_levantar_excecao()
    {
        new Campaign("Source", string.Empty, "Name");
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidCampaignException))]
    public void Dado_um_name_invalido_deve_levantar_excecao()
    {
        new Campaign("Source", "Medium", string.Empty);
    }

    [TestMethod]
    public void Dado_as_informacoes_validas_a_campanha_deve_ser_criada()
    {
        new Campaign("Source Válido", "Medium Válido", "Name Válido");
    }
}
