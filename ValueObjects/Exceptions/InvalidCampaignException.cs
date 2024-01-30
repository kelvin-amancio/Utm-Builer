namespace UtmBuiler.Core.ValueObjects.Exceptions
{
    public class InvalidCampaignException : Exception
    {
        private const string DefaultErrorMessage = "Invalid UTM parametres";
        public InvalidCampaignException(string message = DefaultErrorMessage) : base(message)
        {
        }

        public static void ThrowifNull(string? item, string message = DefaultErrorMessage)
        {
            if(string.IsNullOrEmpty(item)) 
               throw new InvalidCampaignException(message);
        }
    }
}
