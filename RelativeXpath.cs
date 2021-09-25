using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relative_Xpath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Everyone");
            IWebDriver driver = new ChromeDriver("C:\\SeleniumProjects\\chromedriver_win32");

            driver.Manage().Window.Maximize();

            driver.Url = "https://www.google.co.in/";

            driver.FindElement(By.XPath("//input[@role='combobox']")).SendKeys("Selenium");


            
            //driver.Close();
        }
    }
}
