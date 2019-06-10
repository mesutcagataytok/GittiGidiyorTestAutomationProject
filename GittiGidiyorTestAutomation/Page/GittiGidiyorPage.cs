using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace GittiGidiyorTestAutomation.Page
{
    [Binding]
    [TestFixture]
    public class GittiGidiyorPage : Base
    {
        [FindsBy(How = How.Id, Using = "later-subscription-button")]
        public IWebElement BtnCloseSubscription { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".profile-icon-container~.profile-icon-title")]
        public IWebElement BtnProfileIcon { get; set; }

        [FindsBy(How = How.Id, Using = "SignIn")]
        public IWebElement BtnSignin { get; set; }

        [FindsBy(How = How.Id, Using = "L-UserNameField")]
        public IWebElement TxtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "L-PasswordField")]
        public IWebElement TxtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "gg-login-enter")]
        public IWebElement BtnLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='horizontal-menu-item-link'][contains(text(),'Moda')]")]
        public IWebElement BtnMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "/html//div[@id='header_wrapper']/div//a[@title='Erkek Ayakkabı']")]
        public IWebElement BtnAyakkabi { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#filter-spec-2-3~.checkmark")]
        public IWebElement ChkFilterEldiven{ get; set; }

        [FindsBy(How = How.Id, Using = "search-page-tab-free-shipping")]
        public IWebElement ChkFilterKargo{ get; set; }

        [FindsBy(How = How.Id, Using = "item-info-block-435506294")]
        public IWebElement BtnFirstItem { get; set; }

        [FindsBy(How = How.ClassName, Using = "spec-select-0")]
        public IWebElement SlctSize { get; set; }

        [FindsBy(How = How.ClassName, Using = "spec-select-1")]
        public IWebElement SlctColor { get; set; }

        [FindsBy(How = How.Id, Using = "buyitnow_adet")]
        public IWebElement SlctAmount { get; set; }

        [FindsBy(How = How.Id, Using = "add-to-basket")]
        public IWebElement BtnBasket { get; set; }

        [FindsBy(How = How.ClassName, Using = "btn-pay")]
        public IWebElement BtnPay { get; set; }

        [FindsBy(How = How.Id, Using = "AddNew")]
        public IWebElement BtnAddNewAddress { get; set; }

        [FindsBy(How = How.Name, Using = "Name")]
        public IWebElement TxtName { get; set; }

        [FindsBy(How = How.Name, Using = "SurName")]
        public IWebElement TxtSurName { get; set; }

        [FindsBy(How = How.Name, Using = "City")]
        public IWebElement SlctCity { get; set; }

        [FindsBy(How = How.Name, Using = "District")]
        public IWebElement SlctDistrict { get; set; }

        [FindsBy(How = How.Name, Using = "Address")]
        public IWebElement TxtAddress { get; set; }

        [FindsBy(How = How.Name, Using = "phone-number")]
        public IWebElement TxtPhone { get; set; }

        [FindsBy(How = How.ClassName, Using = "post-address")]
        public IWebElement BtnSaveAndContinue { get; set; }

        [FindsBy(How = How.Id, Using = "post-address-form")]
        public IWebElement BtnContinue { get; set; }

        [FindsBy(How = How.Id, Using = "P-PayViaBKM")]
        public IWebElement BtnPayMethod { get; set; }



        public GittiGidiyorPage(IWebDriver webDriver)
        {
            Base.Driver = webDriver;
            PageFactory.InitElements(Driver, this);
        }

        public IWebElement Find(By by)
        {
            return Base.Driver.FindElement(by);
        }

        public void Click(IWebElement btn)
        {
            WebDriverWait wait = new WebDriverWait(Base.Driver, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(btn));
            btn.Click();
        }

        public void Hover(IWebElement btn)
        {
            Actions action = new Actions(Base.Driver);
            action.MoveToElement(btn).Build().Perform();
        }

        public void SetText(IWebElement txt, string text)
        {
            txt.SendKeys(text);
        }
        
        public void SelectOptionByText(IWebElement slct, string text)
        {
            SelectElement selectElement = new SelectElement(slct);
            selectElement.SelectByText(text);
            WebDriverWait wait = new WebDriverWait(Base.Driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement(slct, text));
        }

        public void ScrollTo(IWebElement el)
        {
            string jsStmt = String.Format("window.scrollTo({0},{1})", el.Location.X, el.Location.Y);
            GetScriptExecutor().ExecuteScript(jsStmt, true);
        }

        public IJavaScriptExecutor GetScriptExecutor()
        {
            return (IJavaScriptExecutor)Base.Driver;
        }



        public void CloseSubscriptionPopUp()
        {
            Click(BtnCloseSubscription);
        }

        public void HoverLogin()
        {
            Hover(BtnProfileIcon);
        }

        public void FillLoginInfo(string email, string password)
        {
            SetText(TxtEmail, email);
            SetText(TxtPassword, password);
        }

        public void ClickSigninButton()
        {
            Click(BtnSignin);
        }

        public void ClickLoginButton()
        {
            Click(BtnLogin);
        }

        public void HoverMenuItem()
        {
            Hover(BtnMenu);
        }

        public void ClickMenuItem()
        {
            Click(BtnAyakkabi);
        }

        public void ClickFirstItem()
        {
            Click(BtnFirstItem);
        }

        public void ChooseSize(string size)
        {
            SelectOptionByText(SlctSize, size);
        }

        public void ChooseNumber(string size)
        {
            SelectOptionByText(SlctSize, size);
        }
        
        public void ChooseColor(string color)
        {
            SelectOptionByText(SlctColor, color);
        }
        
        public void EnterAmount(string amount)
        {
            SlctAmount.Clear();
            SetText(SlctAmount, amount);
        }
        
        public void ClickAddToBasket()
        {
            ScrollTo(BtnBasket);
            Click(BtnBasket);
        }
        
        public void ClickPay()
        {
            Click(BtnPay);
        }

        public void ClickAddNewAddress()
        {
            Click(BtnAddNewAddress);
        }

        public void SetName(string name)
        {
            SetText(TxtName, name);
        }

        public void SetSurname(string surname)
        {
            SetText(TxtSurName, surname);
        }

        public void ChooseCity(string city)
        {
            SelectOptionByText(SlctCity, city);
        }

        public void ChooseDistrict(string dist)
        {
            SelectOptionByText(SlctDistrict, dist);
        }

        public void SetAddress(string address)
        {
            SetText(TxtAddress, address);
        }

        public void SetPhone(string phone)
        {
            SetText(TxtPhone, phone);
        }

        public void ClickSaveAndContinue()
        {
            Click(BtnSaveAndContinue);
        }
        
        public void ClickContinue()
        {
            Click(BtnContinue);
        }

        public void ClickPayMethod()
        {
            Click(BtnPayMethod);
        }

    }
}
