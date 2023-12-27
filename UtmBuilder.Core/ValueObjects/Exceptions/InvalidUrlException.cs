using System.Net;
using System.Text.RegularExpressions;

namespace UtmBuilder.Core.ValueObjects.Exceptions;

public partial class InvalidUrlException : Exception
{
    private const string DefaultErrorMessage = "Formato da Url inválido";
    private const string UrlRegexPattern = @"^(http|https):\/\/[^\s\/$.?#].[^\s]*$";

    public InvalidUrlException(string message = DefaultErrorMessage) : base(message)
    { }

    public static void ThrowIfInvalid(string address)
    {
        if(string.IsNullOrEmpty(address))
            throw new InvalidUrlException("Url vazia");

        if (!UrlRegex().IsMatch(address))
            throw new InvalidUrlException();
    }

    [GeneratedRegex(UrlRegexPattern)]
    private static partial Regex UrlRegex();
}
