using System.Net;
using System.Text.RegularExpressions;

namespace UtmBuilder.Core.ValueObjects.Exceptions;

public class InvalidUrlException : Exception
{
    private const string UrlRegexPattern = @"^(http|https):\/\/[^\s\/$.?#].[^\s]*$";

    public InvalidUrlException(string message = "Formato da Url inválido") : base(message)
    { }

    public static void ThrowIfInvalid(string address)
    {
        if(string.IsNullOrEmpty(address))
            throw new InvalidUrlException("Url vazia");

        if (!Regex.IsMatch(address, UrlRegexPattern))
            throw new InvalidUrlException();
    }
}
