namespace SubtleArtOfUnitTesting
{
    public class EmailValidator
    {
        public bool IsValid(string emailAddress)
        {
            return !string.IsNullOrWhiteSpace(emailAddress);
        }
    }
}