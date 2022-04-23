using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myStore_PrestaShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            
            //Top responsive image
            top_responsive_image(Driver);
            Thread.Sleep(700);

            //Sign-in button
            sign_in(Driver);
            Thread.Sleep(700);

            //Authentication_page
            authentication_page(Driver);
            Thread.Sleep(700);

            //Personal Information page
            create_an_account_page(Driver);
            Thread.Sleep(700);

            //Sign-out button
            sign_out_BTN(Driver);
            Thread.Sleep(700);

            //already_Registered_coloumn
            already_Registered_coloumn(Driver);
            Thread.Sleep(700);

            //GO TO HOME 
            homeBTN(Driver);
            Thread.Sleep(700);


            Task.Delay(120000).Wait();

            Console.Write("Test Case Closed:");

            Driver.Close();
            Driver.Quit();
        }

        static void top_responsive_image(IWebDriver Driver)
        {
            IWebElement topIMG = Driver.FindElement(By.XPath("//img[@class='img-responsive']"));
            topIMG.Click();
            Thread.Sleep(1000);
        }

        static void sign_in(IWebDriver Driver)
        {
            IWebElement signinBTN = Driver.FindElement(By.XPath("//a[@class='login']"));
            signinBTN.Click();
            Thread.Sleep(1000);
        }

        static void authentication_page(IWebDriver Driver)
        {
            string email = "xyz1@gmail.com";

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);

            IWebElement emailBOX = Driver.FindElement(By.XPath("//input[@name='email_create']"));
            emailBOX.Click();
            emailBOX.SendKeys(email);
            Thread.Sleep(1000);

            IWebElement submitBTN = Driver.FindElement(By.XPath("//*[@id='SubmitCreate']"));
            submitBTN.Click(); 
        }

        static void create_an_account_page(IWebDriver Driver)
        {
            #region YOUR PERSONAL INFORMATION
            string fname = "Vidya";
            string lname = "Kumari";
            string Password = "Vidya@12345";
            string company = "Bassetti India";
            string address1 = "A-1(1544)";
            string address2 = "Graduation Ln";
            string city = "Middleburg";
            string zipCode = "32068";
            string addinfo = "Not Applicable";
            string homePhone = "0";
            string mobPhone = "9113355779";
            string refAddress = " is same.";


            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0,150)");
            Thread.Sleep(2000);

            IWebElement title_radioBTN = Driver.FindElement(By.XPath("//input[@id='id_gender2']"));
            title_radioBTN.Click();
            Thread.Sleep(1500);

            IWebElement fnameBOX = Driver.FindElement(By.XPath("//input[@id='customer_firstname']"));
            fnameBOX.Click();
            fnameBOX.SendKeys(fname);
            Thread.Sleep(1500);

            IWebElement lnameBOX = Driver.FindElement(By.XPath("//input[@id='customer_lastname']"));
            lnameBOX.Click();
            lnameBOX.SendKeys(lname);
            Thread.Sleep(1500);

            IWebElement emailBOX = Driver.FindElement(By.XPath("//input[@id='email']"));
            emailBOX.Click();
            Thread.Sleep(1500);

            IWebElement passwordBOX = Driver.FindElement(By.XPath("//input[@id='passwd']"));
            passwordBOX.Click();
            passwordBOX.SendKeys(Password);
            Thread.Sleep(1500);

            IWebElement dayBTN = Driver.FindElement(By.XPath("//select[@id='days']"));
            dayBTN.Click();
            Thread.Sleep(500);
            Driver.FindElement(By.XPath("//*[@id='days']/option[30]")).Click();
            Thread.Sleep(1500);

            IWebElement monthBTN = Driver.FindElement(By.XPath("//select[@id='months']"));
            monthBTN.Click();
            Thread.Sleep(500);
            Driver.FindElement(By.XPath("//*[@id='months']/option[7]")).Click();
            Thread.Sleep(1500);

            IWebElement yearBTN = Driver.FindElement(By.XPath("//select[@id='years']"));
            yearBTN.Click();
            Thread.Sleep(500);
            Driver.FindElement(By.XPath("//*[@id='years']/option[24]")).Click();
            Thread.Sleep(1500);

            IWebElement checkBOX_1 = Driver.FindElement(By.XPath("//input[@id='newsletter']"));
            checkBOX_1.Click();
            Thread.Sleep(1000);
            checkBOX_1.Click();
            Thread.Sleep(1500);

            IWebElement checkBOX_2 = Driver.FindElement(By.XPath("//input[@id='optin']"));
            checkBOX_2.Click();
            Thread.Sleep(1000);
            checkBOX_2.Click();
            Thread.Sleep(1500);

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);
            #endregion

            #region YOUR ADDRESS

            //This box is already filled, if we want to change this pre-filled box then, use this code.
            //IWebElement fnameBOX_2 = Driver.FindElement(By.XPath("//input[@id='firstname']"));
            //fnameBOX_2.Click();
            //fnameBOX_2.SendKeys(fname);
            //Thread.Sleep(1500);

            //This box is already filled, if we want to change this pre-filled box then, use this code.
            //IWebElement lnameBOX_2 = Driver.FindElement(By.XPath("//input[@id='lastname']"));
            //lnameBOX_2.Click();
            //lnameBOX_2.SendKeys(lname);
            //Thread.Sleep(1500);

            IWebElement companyBOX = Driver.FindElement(By.XPath("//input[@id='company']"));
            companyBOX.Click();
            companyBOX.SendKeys(company);
            Thread.Sleep(1500);

            IWebElement addressBOX_1 = Driver.FindElement(By.XPath("//input[@id='address1']"));
            addressBOX_1.Click();
            addressBOX_1.SendKeys(address1);
            Thread.Sleep(1500);

            js.ExecuteScript("window.scrollBy(0,150)");
            Thread.Sleep(2000);

            IWebElement addressBOX_2 = Driver.FindElement(By.XPath("//input[@id='address2']"));
            addressBOX_2.Click();
            addressBOX_2.SendKeys(address2);
            Thread.Sleep(1500);

            IWebElement cityBOX = Driver.FindElement(By.XPath("//input[@id='city']"));
            cityBOX.Click();
            cityBOX.SendKeys(city);
            Thread.Sleep(1500);

            js.ExecuteScript("window.scrollBy(0,150)");
            Thread.Sleep(2000);

            IWebElement state_selectBTN = Driver.FindElement(By.XPath("//select[@id='id_state']"));
            state_selectBTN.Click();
            Thread.Sleep(500);
            Driver.FindElement(By.XPath("//*[@id='id_state']/option[11]")).Click();
            Thread.Sleep(1500);

            IWebElement zipCodeBOX = Driver.FindElement(By.XPath("//input[@id='postcode']"));
            zipCodeBOX.Click();
            zipCodeBOX.SendKeys(zipCode);
            Thread.Sleep(1500);

            IWebElement country_selectBTN = Driver.FindElement(By.XPath("//select[@id='id_country']"));
            country_selectBTN.Click();
            Thread.Sleep(500);
            Driver.FindElement(By.XPath("//*[@id='id_country']/option[2]")).Click();
            Thread.Sleep(1500);

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);

            IWebElement addInfoBOX = Driver.FindElement(By.XPath("//textarea[@id='other']"));
            addInfoBOX.Click();
            addInfoBOX.SendKeys(addinfo);
            Thread.Sleep(1500);

            IWebElement homePhoneBOX = Driver.FindElement(By.XPath("//input[@id='phone']"));
            homePhoneBOX.Click();
            homePhoneBOX.SendKeys(homePhone);
            Thread.Sleep(1500);

            IWebElement mobPhoneBOX = Driver.FindElement(By.XPath("//input[@id='phone_mobile']"));
            mobPhoneBOX.Click();
            mobPhoneBOX.SendKeys(mobPhone);
            Thread.Sleep(1500);

            IWebElement refAddressBOX = Driver.FindElement(By.XPath("//input[@id='alias']"));
            refAddressBOX.Click();
            refAddressBOX.SendKeys(refAddress);
            Thread.Sleep(1500);

            IWebElement registerBTN = Driver.FindElement(By.XPath("//span[normalize-space()='Register']"));
            registerBTN.Click();
            Thread.Sleep(1500);
            #endregion
        }

        static void sign_out_BTN(IWebDriver Driver)
        {
            IWebElement signoutBTN = Driver.FindElement(By.XPath("//a[@title='Log me out']"));
            signoutBTN.Click();
            Thread.Sleep(1000);
        }

        static void already_Registered_coloumn(IWebDriver Driver)
        {
            string email = "xyz1@gmail.com";
            string Password = "Vidya@12345";

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);

            IWebElement emailBOX = Driver.FindElement(By.XPath("//input[@id='email']"));
            emailBOX.Click();
            emailBOX.SendKeys(email);
            Thread.Sleep(1000);

            IWebElement passwordBOX = Driver.FindElement(By.XPath("//input[@id='passwd']"));
            passwordBOX.Click();
            passwordBOX.SendKeys(Password);
            Thread.Sleep(1000);

            IWebElement signinBTN = Driver.FindElement(By.XPath("//span[normalize-space()='Sign in']"));
            signinBTN.Click();
        }

        static void homeBTN(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);

            IWebElement homeBTN = Driver.FindElement(By.XPath("//span[normalize-space()='Home']"));
            homeBTN.Click();
            Thread.Sleep(1000);
        }
    }
}
