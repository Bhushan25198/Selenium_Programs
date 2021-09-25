using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseActionDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hell Everyone");

            IWebDriver driver = new ChromeDriver("C:\\SeleniumProjects\\chromedriver_win32");

                driver.Manage().Window.Maximize();

            driver.Url = "https://www.google.co.in/";
            IWebElement gmail = driver.FindElement(By.LinkText("Gmail"));

            Actions action = new Actions(driver);

            //Click using Mouse
           // action.MoveToElement(gmail).Click().Perform();

            //Hover on the Element
           // action.MoveToElement(gmail).Build().Perform();

            //Right click the element
           action.MoveToElement(gmail).ContextClick().Perform();

            //double click
          // action.MoveToElement(gmail).DoubleClick().Perform();

            driver.Close();
        }
    }
}
