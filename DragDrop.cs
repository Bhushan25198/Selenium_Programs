using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Drag_Drop_assignment
{
    class DragDrop
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:\\SeleniumProjects\\chromedriver_win32");

            driver.Manage().Window.Maximize();

            driver.Url = "https://www.globalsqa.com/demo-site/draganddrop/";

            Thread.Sleep(2000);

            driver.SwitchTo().Frame(driver.FindElement(By.CssSelector("iframe.demo-frame")));

            IWebElement drag = driver.FindElement(By.XPath("//ul[@id='gallery']//li[1]"));

            IWebElement drop = driver.FindElement(By.Id("trash"));

            Actions action = new Actions(driver);

            action.DragAndDrop(drag, drop).Perform();
        }
    }
}
