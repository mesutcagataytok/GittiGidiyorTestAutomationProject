using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using System.IO;

namespace GittiGidiyorTestAutomation.Page
{
    public class Base
    {

        public static IWebDriver Driver { get; set; }

        public static void Setup()
        {

            string driverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("start-maximized");
            chromeOptions.AddArguments("test-type");
            chromeOptions.AddArguments("disable-popup-blocking");
            chromeOptions.AddArguments("ignore-certificate-errors");
            chromeOptions.AddArguments("disable-translate");
            chromeOptions.AddArguments("disable-automatic-password-saving");
            chromeOptions.AddArguments("allow-silent-push");
            chromeOptions.AddArguments("disable-infobars");

            Driver = new ChromeDriver(driverPath, chromeOptions);



        }

    }
}
