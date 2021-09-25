using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nukari.com_assignment
{
    class NaukariAssisnment
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Everyone");

            IWebDriver driver = new ChromeDriver("C:\\SeleniumProjects\\chromedriver_win32");

            driver.Manage().Window.Maximize();


            driver.Url = "https://www.naukri.com/account/register/basicdetails?sid=";

            driver.FindElement(By.TagName("button.action-btn.fresh")).Click();



          driver.FindElement(By.XPath("/ html / body / main / div / div / form / div[1] / div[1] / div / input")).SendKeys("Bhushan Ravindra Patil");

           
     


            driver.FindElement(By.XPath("/html/body/main/div/div/form/div[3]/div[1]/div/input")).SendKeys("1254875");

            driver.FindElement(By.XPath("/html/body/main/div/div/form/div[4]/div[1]/div/input[2]")).SendKeys("8956554625565");


            driver.FindElement(By.XPath("/html/body/main/div/div/form/resman-location/div/div/div[1]/suggestor/div/div/input")).SendKeys("Dhule");

            driver.FindElement(By.XPath("/html/body/main/div/div/form/resman-location/div/div/div[2]/div/div[1]/ul/li/div/label/input")).SendKeys("Maharashtra");

            driver.FindElement(By.Name("basicDetailSubmit")).Click();





        }
    }
}
