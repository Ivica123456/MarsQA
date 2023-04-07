using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectQA.Pages
{
    public class ProfilePage
    {
     public void CreateProfile(IWebDriver driver)
     {
            IWebElement description = driver.FindElement(By.XPath("//h3[@class='ui dividing header']//i[@class='outline write icon']"));
            description.Click();
            Thread.Sleep(4000);


            //Write Description

            IWebElement putDescription = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            putDescription.Clear();
            Thread.Sleep(4000);
            putDescription.SendKeys("An organized candidate is a detail-oriented person an employer can trust to meet deadlines.");

            Thread.Sleep(4000);

            //Click save button on Description
            IWebElement saveButton = driver.FindElement(By.XPath("//button[@type='button']"));
            saveButton.Click();

            Thread.Sleep(4000);

            //Click on SkillS Button

            IWebElement skillsButton = driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
            skillsButton.Click();

            Thread.Sleep(4000);

            //Click on Skills addNew Button 
           
            IWebElement addNewButton = driver.FindElement(By.XPath("//div[@class='ui teal button']"));
            addNewButton.Click();

            // Input add Skills

            IWebElement inputSkill = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            inputSkill.SendKeys("Deep breathing");
            Thread.Sleep(4000);

            //Select dropdown in Skills

            IWebElement selectDropDown = driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"));
            selectDropDown.Click();
            Thread.Sleep(4000);

            // Select level in Skills
            IWebElement addskillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            addskillLevel.Click();
            Thread.Sleep(4000);

            // Save Skills click on add button

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//body/div[@id='account-profile-section']/div/section/div[@class='ui fluid container']/div[@class='ui grid']/div[@class='row']/div[1]")));


            IWebElement saveSkillButton = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div/section/div[@class='ui fluid container']/div[@class='ui grid']/div[@class='row']/div[1]"));
            saveSkillButton.Click();




            ////Click on Languages button

            //IWebElement Languageesbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            //Languageesbutton.Click();
            //Thread.Sleep(4000);


            //// ADD language button

            //IWebElement addlanguage = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
            //addlanguage.Click();
            //Thread.Sleep(4000);

            //// Input languages in textBox

            //IWebElement inputLanguagesTextBox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            //inputLanguagesTextBox.SendKeys("English");
            //Thread.Sleep(4000);
            //// Choose language level

            //IWebElement levelLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
            //levelLanguage.Click();
            //Thread.Sleep(4000);

            
            // Click on Education button
           
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[normalize-space()='Education']")));

            IWebElement educationButton = driver.FindElement(By.XPath("//a[normalize-space()='Education']"));
            educationButton.Click();

            //Click on Education add new Button

            IWebElement EdnewButton = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
            EdnewButton.Click();
            Thread.Sleep(7000);

            // Input College/University name

            IWebElement universityName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            universityName.SendKeys("CCNP Cisco EduNet");
            Thread.Sleep(4000);
            
            // Click on Country of College/University dropdown

            IWebElement universityDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            universityDropdown.Click();

            // Select Country of College/University dropdown

            IWebElement countryCollege = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[36]"));
            countryCollege.Click();
            Thread.Sleep(4000);

            // Click on title dropdown

            IWebElement titleDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            titleDropdown.Click();
            Thread.Sleep(2000);

            // Select title

            IWebElement selectTitle = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]"));
            selectTitle.Click();

            // Input degree

            IWebElement inputDegree = driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
            inputDegree.SendKeys("Pro");

            // Select Year of graduation dropdown

            IWebElement YearOfgraduation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            YearOfgraduation.Click();

            // Choose year in dropdown list

            IWebElement chooseYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[12]"));
            chooseYear.Click();
            Thread.Sleep(5000);

            // Click on certification button

            IWebElement certificationButon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButon.Click();
            Thread.Sleep(5000);

            //Click on add new Button to create Certification

            IWebElement addnewButton = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[@class='ui teal button '][normalize-space()='Add New']"));
            addnewButton.Click();
            Thread.Sleep(7000);

            // Input Award into textBox Certification

            IWebElement awardsTextBox = driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
            awardsTextBox.SendKeys("NetRiders Challenge 2011");
            Thread.Sleep(7000);

            //Input Cerfication form into textBox

            IWebElement formTextBox = driver.FindElement(By.Name("certificationFrom"));
            formTextBox.SendKeys("pdf");
            Thread.Sleep(7000);
            //Select certification Year dropdown

            IWebElement certificationYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            certificationYear.Click();
            Thread.Sleep(7000);
           
            //Input cerfication year

            IWebElement selectYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[14]"));
            selectYear.Click();
            Thread.Sleep(7000);

            // Click on add button to save Certification

            IWebElement ADDButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            ADDButton.Click();
            Thread.Sleep(7000);




        
        
        
            //Click on Languages button

            IWebElement Languageesbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            Languageesbutton.Click();
            Thread.Sleep(4000);


            // ADD language button

            IWebElement addlanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            addlanguage.Click();
            Thread.Sleep(4000);

            // Input languages in textBox

            IWebElement inputLanguagesTextBox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            inputLanguagesTextBox.SendKeys("English");
            Thread.Sleep(4000);
            // Choose language level

            IWebElement levelLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
            levelLanguage.Click();
            Thread.Sleep(4000);


            




     }
        public string newLanguage(IWebDriver driver)
        {
            IWebElement updateLanguage = driver.FindElement(By.XPath("//td[normalize-space()='English']"));
            return updateLanguage.Text;




        }
     public void editProfile(IWebDriver driver) 
     {
            // EDIT Certification

            // Click on certification button

            IWebElement certificationButon1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButon1.Click();
            Thread.Sleep(5000);

            //Edit certification

            IWebElement pancilclick = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[4]/span[1]/i[1]"));
            pancilclick.Click();

            Thread.Sleep(5000);

            //Updated awords

            IWebElement editAwords = driver.FindElement(By.Name("certificationName"));
            editAwords.Clear();
            Thread.Sleep(2000);
            editAwords.SendKeys("NetRiders Challenge 2012");
            Thread.Sleep(2000);
            //Click update button

            IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateButton.Click();
            Thread.Sleep(5000);





        }



    }
}
