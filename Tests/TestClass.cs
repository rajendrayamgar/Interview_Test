using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Project.Utilities;

namespace Test_Project.Tests
{
    [TestFixture]
    public class TestClass : Base
    {
        
        [Test]
        public void HomePage()
        {
            
            //Accessibility of "Home" logo field
            IWebElement element1 = driver.FindElement(By.Id("//a[@class='logo']"));
            if (element1.Enabled)
            {
                String text= element1.Text;
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Home Logo not accessible");
            }

            //Accessibility of "Our Story" field
            IWebElement element2 = driver.FindElement(By.Id("//a[text()='Our Story']"));
            if (element1.Enabled)
            {
                String text = element2.Text;
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Our Story field not accessible");
            }

            //Accessibility of "Our Solution" field
            IWebElement element3 = driver.FindElement(By.Id("//a[text()='Our Solution']"));
            if (element1.Enabled)
            {
                String text = element3.Text;
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Our Solution field not accessible");
            }


            //Accessibility of "Why Tendable?" field
            IWebElement element4 = driver.FindElement(By.Id("//a[text()='Why Tendable?']"));
            if (element1.Enabled)
            {
                String text = element4.Text;
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Why Tendable? field not accessible");
            }



            //Visibility of "Request A Demo'" button
            IWebElement element5 = driver.FindElement(By.Id("//a[text()='Request A Demo']"));
            if (element1.Displayed)
            {
                element1.Click();
            }
            else
            {
                Console.WriteLine("Request A Demo' button not present");
            }



        }

    }
}
