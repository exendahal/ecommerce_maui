using EcommerceMAUI.Helpers;
using EcommerceMAUI.Helpers.ExtensionMethods;
using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Model
{
    public class CardInfoModel : BaseViewModel
    {
        public string CardNumber { get; set; }
        public string NameOnCard { get; set; }
        public string CardValidationCode { get; set; }
        public string ExpirationDate { get; set; }

        private bool _IsSelected = false;
        public bool IsSelected
        {
            get => _IsSelected;
            set => SetProperty(ref _IsSelected, value);
        }
        public string CardType
        {
            get
            {
                var normalizedCardNumber = CardNumber.Replace("-", string.Empty);
                if (CreditCardTypeRegexHelper.AmericanExpress.IsMatch(normalizedCardNumber))
                {
                    return "American Express";
                }
                else if (CreditCardTypeRegexHelper.DinersClub.IsMatch(normalizedCardNumber))
                {
                    return "Diners Club";
                }
                else if (CreditCardTypeRegexHelper.Discover.IsMatch(normalizedCardNumber))
                {
                    return "Discover";
                }
                else if (CreditCardTypeRegexHelper.JCB.IsMatch(normalizedCardNumber))
                {
                    return "JCB";
                }
                else if (CreditCardTypeRegexHelper.MasterCard.IsMatch(normalizedCardNumber))
                {
                    return "Master Card";
                }
                else if (CreditCardTypeRegexHelper.Visa.IsMatch(normalizedCardNumber))
                {
                    return "Visa";
                }
                else
                {
                   return "Unknown";
                }
            }
        }

        public Color CardColor
        {
            get
            {
                switch (CardType)
                { 
                     case "American Express":
                        return "AmericanExpress".ToColorFromResourceKey();
                     case "Diners Club":
                        return "DinersClub".ToColorFromResourceKey();
                     case "Discover":
                        return "Discover".ToColorFromResourceKey();
                     case "JCB":
                        return "JCB".ToColorFromResourceKey();
                     case "Master Card":
                        return "MasterCard".ToColorFromResourceKey();
                    case "Visa":
                        return "Visa".ToColorFromResourceKey();
                     default:
                        return "Default".ToColorFromResourceKey();
                }
            }
        }

        public string Icon
        {
            get
            {
                switch (CardType)
                {
                    case "American Express":
                        return "\uf1f3";
                    case "Diners Club":
                        return "\uf24c";
                    case "Discover":
                        return "\uf1f2";
                    case "JCB":
                        return "\uf24b";
                    case "Master Card":
                        return "\uf1f1";
                    case "Visa":
                        return "\uf1f0";
                    default:
                        return "\uf09d";
                }
            }
        }
        public string FontFamily
        {
            get
            {
                if (CardType == "American Express" ||
                    CardType == "Diners Club" ||
                    CardType == "Discover" ||
                    CardType == "JCB" ||
                    CardType == "Master Card" ||
                    CardType == "Visa")
                {
                    return "FA6Brands";
                }
                else
                {
                    return "FA6Regular";
                }                
            }
        }
        public string MaskedCardNumber
        {
            get
            {
                if (string.IsNullOrEmpty(CardNumber) || CardNumber.Length < 4)
                {
                    return "**** **** **** ****";
                }

                var normalizedCardNumber = CardNumber.Replace("-", string.Empty).Replace(" ", string.Empty);
                var lastFourDigits = normalizedCardNumber[^4..];
                return $"**** **** **** {lastFourDigits}";
            }
        }


    }
}
