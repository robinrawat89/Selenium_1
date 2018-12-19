using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IndustryConnect_Automation
{
    class Program
    {
        static void Main(string[] args)
        {
            // launch browser
            IWebDriver driver = new ChromeDriver();

            // Enter the URL
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //Locate username textbox

            IWebElement Username = driver.FindElement(By.Id("UserName"));
            Username.SendKeys("hari");

            //Locate password textbox
            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("123123");

            //LOcate Login button
            IWebElement Login = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            Login.Click();

            //Verify login
            IWebElement hello_hari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (hello_hari.Text == "Hello hari") 
            {
                Console.Write("test passed");
            }
            else;
            {
                Console.WriteLine("Test Failed");
            }


            //Navuiagte to Time and Materials page

            IWebElement ClickAdmin = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            ClickAdmin.Click();


            //Click time and material from dropdown
             driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();



            //Click on NEw Time and MAterial
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();


            //Click TypeCode

            //driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            //Thread.Sleep(500);
            //CLick on Value
            //driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']")).Click();


            //Value in Code 

            driver.FindElement(By.Id("Code")).SendKeys("test");

            //Value in Description

            driver.FindElement(By.Id("Description")).SendKeys("testtest");

            //Value in Price per unit

            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("5");

            //save time and material
            driver.FindElement(By.Id("SaveButton")).Click();
        }


    }
}
