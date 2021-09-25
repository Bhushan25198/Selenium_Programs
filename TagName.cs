using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TagName
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello Everyone");
            IWebDriver driver = new ChromeDriver("C:\\SeleniumProjects\\chromedriver_win32");

            driver.Manage().Window.Maximize();

            driver.Url = "https://www.google.co.in/";

            ReadOnlyCollection<IWebElement> Links = driver.FindElements(By.TagName("a"));

            Console.WriteLine(Links.Count);
            foreach (IWebElement Link in Links)
            {
                Console.WriteLine("Link.Text");
            }



            Thread.Sleep(3000);
            driver.Close();

        }
    }
}
