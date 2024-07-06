using System.Text.RegularExpressions;

namespace EcommerceMAUI.Helpers
{
    internal class CreditCardTypeRegexHelper
    {
        public static Regex AmericanExpress
            = new(@"^3[47][0-9]{13}$");

        public static Regex DinersClub
            = new(@"^3(?:0[0-5]|[68][0-9])[0-9]{11}$");

        public static Regex Discover
            = new(@"^6(?:011|5[0-9]{2})[0-9]{12}$");

        public static Regex JCB
           = new(@"^(?:2131|1800|35\d{3})\d{11}$");

        public static Regex MasterCard
            = new(@"^(?:5[1-5][0-9]{2}|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[01][0-9]|2720)[0-9]{12}$");

        public static Regex Visa
            = new(@"^4[0-9]{12}(?:[0-9]{3})?$");
    }
}
