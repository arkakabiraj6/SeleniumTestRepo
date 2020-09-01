using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;



namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
           
          ChromeOptions options = new ChromeOptions();

          IWebDriver driver = new ChromeDriver(@"C:\Users\ARKA-PC\Downloads\chromedriver_win32", options, TimeSpan.FromSeconds(180));

         driver.Url="https://www.google.com";

        driver.FindElement(By.XPath("//*[@class='gLFyf gsfi']")).Click();

         driver.FindElement(By.XPath("//*[@class='gLFyf gsfi']")).SendKeys("Test");

        }
    }
}
