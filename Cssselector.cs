using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSSSelectorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Everyone");

            IWebDriver driver = new ChromeDriver("C:\\SeleniumProjects\\chromedriver_win32");

            driver.Manage().Window.Maximize();

            driver.Url = "https://www.google.co.in/";
            driver.FindElement(By.CssSelector("input[role$='box']")).SendKeys("Selenium");

            Thread.Sleep(3000);

            driver.Close();

        }
    }
}
