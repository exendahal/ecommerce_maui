using EcommerceMAUI.Helpers.ExtensionMethods;
using EcommerceMAUI.Helpers;
using System.Globalization;

namespace EcommerceMAUI.Controls;


public partial class CreditCardView : Frame
{
    public static readonly BindableProperty CardNumberProperty
        = BindableProperty.Create(nameof(CardNumber),
            typeof(string), typeof(CreditCardView), null,
            propertyChanged: OnCardNumberChanged);

    public string CardNumber
    {
        get => (string)GetValue(CardNumberProperty);
        set => SetValue(CardNumberProperty, value);
    }

    public static readonly BindableProperty ExpirationDateProperty
        = BindableProperty.Create(nameof(ExpirationDate),
            typeof(DateTime), typeof(CreditCardView), DateTime.Now,
            propertyChanged: OnExpirationDateChanged);

    public DateTime ExpirationDate
    {
        get => (DateTime)GetValue(ExpirationDateProperty);
        set => SetValue(ExpirationDateProperty, value);
    }

    public static readonly BindableProperty CardValidationCodeProperty
    = BindableProperty.Create(nameof(CardValidationCode),
        typeof(string), typeof(CreditCardView), "-",
        propertyChanged: OnCardValidationCodeChanged);

    public string CardValidationCode
    {
        get => (string)GetValue(CardValidationCodeProperty);
        set => SetValue(CardValidationCodeProperty, value);
    }

    private static void OnCardNumberChanged(BindableObject bindable,
        object oldValue, object newValue)
    {
        if (bindable is not CreditCardView creditCardView)
            return;

        creditCardView.SetCreditCardNumber();
    }

    private static void OnExpirationDateChanged(BindableObject bindable,
        object oldValue, object newValue)
    {
        if (bindable is not CreditCardView creditCardView)
            return;

        creditCardView.SetExpirationDate();
    }

    private static void OnCardValidationCodeChanged(BindableObject bindable,
        object oldValue, object newValue)
    {
        if (bindable is not CreditCardView creditCardView)
            return;

        creditCardView.SetCardValidationCode();
    }


    public CreditCardView()
    {
        InitializeComponent();

        BackgroundColor = "Default".ToColorFromResourceKey();

        CreditCardImageLabel.Text = "\uf09d";
        CreditCardImageLabel.FontFamily = "FA6Regular";

        ExpirationDateLabel.Text = "-";

        CardValidationCodeLabel.Text = "-";
    }

    private void SetCreditCardNumber()
    {
        if (string.IsNullOrEmpty(CardNumber))
        {
            BackgroundColor = (Color)Application.Current.Resources["Default"];
            CreditCardImageLabel.Text = "\uf09d";
            CreditCardImageLabel.FontFamily = "FA6Regular";
        }

        if (long.TryParse(CardNumber, out long cardNumberAsLong))
        {
            CreditCardNumber.Text =
                string.Format("{0:0000  0000  0000  0000}", cardNumberAsLong);
        }
        else
        {
            CreditCardNumber.Text = "-";
        }

        var normalizedCardNumber = CardNumber.Replace("-", string.Empty);

        if (CreditCardTypeRegexHelper.AmericanExpress.IsMatch(normalizedCardNumber))
        {
            BackgroundColor = "AmericanExpress".ToColorFromResourceKey();
            CreditCardImageLabel.Text = "\uf1f3";
            CreditCardImageLabel.FontFamily = "FA6Brands";
        }
        else if (CreditCardTypeRegexHelper.DinersClub.IsMatch(normalizedCardNumber))
        {
            BackgroundColor = "DinersClub".ToColorFromResourceKey();
            CreditCardImageLabel.Text = "\uf24c";
            CreditCardImageLabel.FontFamily = "FA6Brands";
        }
        else if (CreditCardTypeRegexHelper.Discover.IsMatch(normalizedCardNumber))
        {
            BackgroundColor = "Discover".ToColorFromResourceKey();
            CreditCardImageLabel.Text = "\uf1f2";
            CreditCardImageLabel.FontFamily = "FA6Brands";
        }
        else if (CreditCardTypeRegexHelper.JCB.IsMatch(normalizedCardNumber))
        {
            BackgroundColor = "JCB".ToColorFromResourceKey();
            CreditCardImageLabel.Text = "\uf24b";
            CreditCardImageLabel.FontFamily = "FA6Brands";
        }
        else if (CreditCardTypeRegexHelper.MasterCard.IsMatch(normalizedCardNumber))
        {
            BackgroundColor = "MasterCard".ToColorFromResourceKey();
            CreditCardImageLabel.Text = "\uf1f1";
            CreditCardImageLabel.FontFamily = "FA6Brands";
        }
        else if (CreditCardTypeRegexHelper.Visa.IsMatch(normalizedCardNumber))
        {
            BackgroundColor = "Visa".ToColorFromResourceKey();
            CreditCardImageLabel.Text = "\uf1f0";
            CreditCardImageLabel.FontFamily = "FA6Brands";
        }
        else
        {
            BackgroundColor = "Default".ToColorFromResourceKey();
            CreditCardImageLabel.Text = "\uf09d";
            CreditCardImageLabel.FontFamily = "FA6Regular";
        }
    }

    private void SetExpirationDate()
    {
        ExpirationDateLabel.Text = ExpirationDate.ToString("MM/yy",
            CultureInfo.InvariantCulture);
    }

    private void SetCardValidationCode()
    {
        CardValidationCodeLabel.Text = CardValidationCode;
    }
}