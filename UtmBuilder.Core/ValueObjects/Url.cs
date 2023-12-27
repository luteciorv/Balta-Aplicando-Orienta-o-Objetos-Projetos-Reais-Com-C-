using System.Text.RegularExpressions;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects;

public class Url : ValueObject
{

    /// <summary>
    /// Cria uma nova URL
    /// </summary>
    /// <param name="address">Endereço da URL (link do website)</param>
    public Url(string address)
    {
        Address = address;

        InvalidUrlException.ThrowIfInvalid(address);
    }

    public string Address { get; }
}
