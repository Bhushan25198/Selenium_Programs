using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LocateById
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Everyone");

            IWebDriver driver = new ChromeDriver("C:\\SeleniumProjects\\chromedriver_win32");

            driver.Manage().Window.Maximize();

            driver.Url = "https://accounts.google.com/signup/v2/webcreateaccount?service=mail&continue=https%3A%2F%2Fmail.google.com%2Fmail&hl=en-GB&dsh=S1510151552%3A1632067225536338&biz=true&flowName=GlifWebSignIn&flowEntry=SignUp";
            driver.FindElement(By.CssSelector("#firstName")).SendKeys("Bhushan");

            Thread.Sleep(3000);

            driver.Close();
        }
    }
}
