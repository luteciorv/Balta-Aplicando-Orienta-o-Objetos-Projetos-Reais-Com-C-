namespace UtmBuilder.Core.ValueObjects.Exceptions;

public class InvalidCampaignException : Exception
{
    private const string DefaultErrorMessage = "Formato da Url inválido";

    public InvalidCampaignException(string message = DefaultErrorMessage) : base(message)
    { }

    public static void ThrowIfNull(string? item, string message)
    {
        if (string.IsNullOrEmpty(item))
            throw new InvalidCampaignException(message);
    }
}
