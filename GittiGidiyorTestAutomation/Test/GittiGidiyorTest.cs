using GittiGidiyorTestAutomation.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Threading;
using TechTalk.SpecFlow;

namespace GittiGidiyorTestAutomation.Test
{
    [TestFixture]
    [Binding, Scope(Feature = "GittiGidiyorTest")]
    public class GittiGidiyorTest
    {

        GittiGidiyorPage gittiGidiyorPage;
      

        public GittiGidiyorTest()
        {
            Base.Setup();
            gittiGidiyorPage = new GittiGidiyorPage(Base.Driver);

        }

        [StepDefinition(@"GittiGidiyor anasayfası açılır")]
        public void OpenHomePage()
        {
            Base.Driver.Navigate().GoToUrl("https://www.gittigidiyor.com");
        }

        [StepDefinition(@"Güncel fırsatlar pop-up'ında daha sonra butonu tıklanır")]
        public void ClosePopUp()
        {
            gittiGidiyorPage.CloseSubscriptionPopUp();
        }

        [StepDefinition(@"Giriş yap butonu üzerine gelinir")]
        public void HoverProfile()
        {
            gittiGidiyorPage.HoverLogin();
        }

        [StepDefinition(@"Giriş yap butonuna tıklanır")]
        public void ClickLogin()
        {
            gittiGidiyorPage.ClickSigninButton();
        }

        [StepDefinition(@"Email alanına '(.*)' şifre alanına '(.*)' yazılır")]
        public void FillLogin(string email, string password)
        {
            gittiGidiyorPage.FillLoginInfo(email, password);
        }

        [StepDefinition(@"Üye girişi ekranında giriş yap butonuna tıklanır")]
        public void Login()
        {
            gittiGidiyorPage.ClickLoginButton();
        }

        [StepDefinition(@"Menüden Moda üzerine gelinir")]
        public void HoverMenu()
        {
            gittiGidiyorPage.HoverMenuItem();
        }

        /*
         * 
	* Menüden Erkek Ayakkabı kategorisi seçilir
	* İlk ürün seçilir
	* Numara olarak '44' seçilir
	* Renk olarak 'Lacivert' seçilir
	* Adet olarak '1' seçilir
	* Sepete Ekle butonuna tıklanır
	* Alışverişi tamamla butonuna tıklanır
	* Devam Et butonuna tıklanır
	* Ad alanına 'İsim' yazılır
	* Soyad alanına 'Soyisim' yazılır
	* Şehir olarak 'Şehir' seçilir
	* İlçe olarak 'İlçe' seçilir
	* Adres alanına 'Adres' yazılır
	* Telefon-1 alanına '5314455500' yazılır
	* Kaydet ve Devam Et butonuna tıklanır
	* Ödeme yöntemi olarak BKM express seçilir
         * */
        [StepDefinition(@"Menüden Erkek Ayakkabı kategorisi seçilir")]
        public void ClickMenu()
        {
            gittiGidiyorPage.ClickMenuItem();
        }

       
        [StepDefinition(@"İlk ürün seçilir")]
        public void ChooseFirstItem()
        {
            gittiGidiyorPage.ClickFirstItem();
        }

        [StepDefinition(@"Numara olarak '(.*)' seçilir")]
        public void ChooseNumber(string s)
        {
            gittiGidiyorPage.ChooseNumber(s);
        }

        [StepDefinition(@"Renk olarak '(.*)' seçilir")]
        public void ChooseFirstItem(string c)
        {
            gittiGidiyorPage.ChooseColor(c);
        }

        [StepDefinition(@"Adet olarak '(.*)' seçilir")]
        public void ChooseAmount(string a)
        {
            gittiGidiyorPage.EnterAmount(a);

        }


        [StepDefinition(@"Sepete Ekle butonuna tıklanır")]
        public void ClickBasket()
        {
            gittiGidiyorPage.ClickAddToBasket();
        }

        [StepDefinition(@"Alışverişi tamamla butonuna tıklanır")]
        public void ClickPay()
        {
            gittiGidiyorPage.ClickPay();
        }

        [StepDefinition(@"Yeni Adres Ekle butonuna tıklanır")]
        public void ClickAddress()
        {
            gittiGidiyorPage.ClickAddNewAddress();
        }

        [StepDefinition(@"Ad alanına '(.*)' yazılır")]
        public void SetName(string name)
        {
            gittiGidiyorPage.SetName(name);
        }

        [StepDefinition(@"Soyad alanına '(.*)' yazılır")]
        public void SetSurname(string surname)
        {
            gittiGidiyorPage.SetSurname(surname);
        }

        [StepDefinition(@"Şehir olarak '(.*)' seçilir")]
        public void ChooseCity(string s)
        {
            gittiGidiyorPage.ChooseCity(s);
        }

        [StepDefinition(@"İlçe olarak '(.*)' seçilir")]
        public void ChooseDistrict(string s)
        {
            gittiGidiyorPage.ChooseDistrict(s);
        }

        [StepDefinition(@"Adres alanına '(.*)' yazılır")]
        public void SetAddress(string address)
        {
            gittiGidiyorPage.SetAddress(address);
        }

        [StepDefinition(@"Telefon-1 alanına '(.*)' yazılır")]
        public void SetPhone(string phone)
        {
            gittiGidiyorPage.SetPhone(phone);
        }

        [StepDefinition(@"Kaydet ve Devam Et butonuna tıklanır")]
        public void ClickSaveAndContinue()
        {
            gittiGidiyorPage.ClickSaveAndContinue();
        }

        [StepDefinition(@"Devam Et butonuna tıklanır")]
        public void ClickContinue()
        {
            gittiGidiyorPage.ClickContinue();
        }

       

        [AfterScenario]
        public void After()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Base.Driver.Quit();
        }
    }
}
