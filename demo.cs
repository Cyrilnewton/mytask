using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium
{
    internal class demo
    {
        public void Demo()
        {
           IWebDriver driver= new ChromeDriver();
           driver.Navigate().GoToUrl("https://www.letskodeit.com/practice");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();

          IWebElement radio = driver.FindElement(By.XPath("//input[@id='benzradio']"));
              radio.Click();      
              IWebElement checkbox = driver.FindElement(By.XPath("//input[@id='hondacheck']"));
              checkbox.Click();

              SelectElement select = new SelectElement(driver.FindElement(By.XPath("//select[@id='carselect']"))); 
              select.SelectByIndex(1);

              SelectElement sel =new SelectElement(driver.FindElement(By.XPath("//select[@id='multiple-select-example']")));
              sel.SelectByValue("orange");

             IWebElement enable = driver.FindElement(By.XPath("//input[@id='enabled-button']"));
              bool a = enable.Enabled;
             Console.WriteLine(a);

              IWebElement display = driver.FindElement(By.XPath("//input[@id='show-textbox']"));
              bool b = display.Displayed;
              Console.WriteLine(b);


              IWebElement al = driver.FindElement(By.XPath("//input[@id='alertbtn']"));
              al.Click();
              IAlert alert = driver.SwitchTo().Alert();
              alert.Accept();
              Thread.Sleep(2000);

          /*  Actions act = new Actions(driver);
              IWebElement h = driver.FindElement(By.Id("mousehover"));
              act.MoveToElement(h).Perform();
              act.Click(h).Perform();
              Thread.Sleep(3000);
          
           driver.SwitchTo().Frame(driver.FindElement(By.Name("iframe-name")));
            IWebElement java = driver.FindElement(By.XPath("//a[@href=\"/courses/javascript-for-beginners\"]"));
            java.Click();
            
            driver.SwitchTo().DefaultContent();*/

            
         //   IWebElement wind = driver.FindElement(By.Id("openwindow"));
         //   wind.Click();
           
        }
       
    }
}
