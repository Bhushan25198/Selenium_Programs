using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locate_By_LinkText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Everyone");
            IWebDriver driver = new ChromeDriver("C:\\SeleniumProjects\\chromedriver_win32");

            driver.Manage().Window.Maximize();

            driver.Url = "https://www.google.co.in/";

           String gmailText= driver.FindElement(By.LinkText("Gmail")).Text;

            Console.WriteLine(gmailText);

            driver.Close();
        }
    }
}
