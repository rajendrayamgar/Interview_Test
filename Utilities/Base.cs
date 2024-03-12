using AngleSharp;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Test_Project.Utilities
{
    public class Base
    {
        String browserName;
        protected IWebDriver driver;
        
        [SetUp]
        public void startBrowser()
        {
            browserName = TestContext.Parameters["browsername"];
            if(browserName == null)
            {
                browserName = ConfigurationManager.AppSettings["browsername"];
            }

            InitBrowser(browserName="Chrome");
            driver.Manage().Timeouts().ImplicitWait= TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.tendable.com/";

        }

        

        public void InitBrowser(String browserName)
        {
            switch (browserName)
            {
                case "Chrome":
                    {
                        new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                        driver = new ChromeDriver();
                        break;
                    }
                case "Firefox":
                    {
                        new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                        driver = new FirefoxDriver();
                        break;
                    }
            }
        }

        [TearDown]
        public void stopBrowser()
        {
            driver.Quit();
        }
    }
}
