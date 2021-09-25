using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Hello Everyone");

            IWebDriver driver = new ChromeDriver("C:\\SeleniumProjects\\chromedriver_win32");

            driver.Manage().Window.Maximize();

            driver.Url = "https://formstone.it/components/dropdown/demo/";

            IWebElement select_box = driver.FindElement(By.Id("demo_basic"));
            SelectElement select = new SelectElement(select_box);
            //select.SelectByIndex(1);
            select.SelectByValue("2");

            //select.SelectByText("Two");

           // driver.Close();

        }
    }
}
