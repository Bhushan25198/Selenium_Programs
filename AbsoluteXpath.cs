using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteXpathDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Everyone");
            IWebDriver driver = new ChromeDriver("C:\\SeleniumProjects\\chromedriver_win32");

            driver.Manage().Window.Maximize();

            driver.Url = "https://www.google.co.in/";

            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input")).SendKeys("Selenium");



            // driver.Close();
        }
    }
}
