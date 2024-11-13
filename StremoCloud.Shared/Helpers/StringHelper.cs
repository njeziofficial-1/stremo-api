using System.ComponentModel.DataAnnotations;

namespace StremoCloud.Shared.Helpers
{
    public class StringHelper
    {
        public static bool IsValidEmail(string email)
        {
            EmailAddressAttribute emailValidator = new();    
            return emailValidator.IsValid(email);
        }
    }
}
