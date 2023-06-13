using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsProjectQA.Utilities;
using System.Reflection.Emit;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;
using MarsProjectQA.Pages.model;

namespace MarsProjectQA.Pages
{
    public class ProfilePage : CommonDriver
    {
        WebDriverWait wait1;
        private IWebElement descriptionButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span"));
        private IWebElement putDescription => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
        private IWebElement saveButton => driver.FindElement(By.XPath("//button[@type='button']"));
        private IWebElement skillsButton => driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
        private IWebElement addNewButton => driver.FindElement(By.XPath("//div[@class='ui teal button']"));
        private IWebElement inputSkill => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        private IWebElement selectDropDown => driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"));
        private IWebElement addskillLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
        private IWebElement saveSkillButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        private IWebElement educationButton => driver.FindElement(By.XPath("//a[normalize-space()='Education']"));
        private IWebElement educationNewButton => driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
        private IWebElement universityName => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
        private IWebElement universityDropdown => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
        private IWebElement countryCollegeSelect => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
        private IWebElement titleDropdown => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
        private IWebElement selectTitle => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
        private IWebElement inputDegree => driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
        private IWebElement YearOfgraduation => driver.FindElement(By.XPath("//select[starts-with(@class,\"ui dropdown\") and contains(@name,\"yearOfGraduation\")]"));
        private IWebElement selectYear => driver.FindElement(By.XPath("//select[starts-with(@class,\"ui dropdown\") and contains(@name,\"yearOfGraduation\")]"));
        private IWebElement addnewButtun => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
        private IWebElement Languagebutton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        private IWebElement addlanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement inputLanguagesTextBox => driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        private IWebElement levelLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
        private IWebElement AddClick => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        private IWebElement editButton => driver.FindElement(By.XPath("//span[contains(@class,\"button\")]"));
        private IWebElement editLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        private IWebElement selectLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
        private IWebElement LanguageLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]"));
        private IWebElement updateButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
       

        public ProfilePage()
        {
         wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

        }

        public void CreateDescription()
        {
            // Click Description button
            Thread.Sleep(3000);
            descriptionButton.Click();
            // Description textbox
            Thread.Sleep(3000);
            putDescription.Clear();
            Thread.Sleep(3000);
            putDescription.SendKeys("nothing");
            Thread.Sleep(3000);
            // Click save button on Description
            Wait.WaitToBeClickable(driver, "XPath", "//button[@type='button']", 10);
            saveButton.Click();

        }

        public string getAddDescription()
        {
            
            return putDescription.Text;
        }

        public void UpdateDescription(string description)
        {
            // Description button
            Thread.Sleep(3000);
            descriptionButton.Click();
            // Description textbox
            Thread.Sleep(3000);
            putDescription.Clear();
            Thread.Sleep(3000);
            putDescription.SendKeys(description);
            Wait.WaitToBeClickable(driver, "XPath", "//button[@type='button']", 10);
            // Click save button on Description
            saveButton.Click();

        }
  

        public string getUpdatedDescription()
        {
            
            return putDescription.Text;
        }


        public void AddSkill()
        {
            //Click on SkillS Button
            skillsButton.Click();
            //Click on Skill ADD new button
            addNewButton.Click();
            // Add Skill textbox
            inputSkill.SendKeys("breathing");
            //Select dropdown in Skills
            selectDropDown.Click();
            // Select level in Skills
            addskillLevel.Click();
            // Save Skills click on add button
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]", 10);
            saveSkillButton.Click();
        }


        public void AddEducation(string Country, string University, string Title, string Degree, string Graduation)
        {
            // Create Education 
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[normalize-space()='Education']")));
            educationButton.Click();
            //Click on Education add new Button
            educationNewButton.Click();
            // Input College/University name
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input", 10);
            universityName.Clear();
            universityName.SendKeys(University);
            // Click on Country of College/University dropdown
            universityDropdown.Click();
            //// Select Country of College/University dropdown
            SelectElement selectElementSelectCountry = new(countryCollegeSelect);
            selectElementSelectCountry.SelectByValue(Country);
            // Click on title dropdown
            titleDropdown.Click();
            // Select title
            SelectElement selectElementSelectTitle = new(selectTitle);
            selectElementSelectTitle.SelectByValue(Title);
           // Input degree
            inputDegree.Clear();
            inputDegree.SendKeys(Degree);
            // Select Year of graduation dropdown
            YearOfgraduation.Click();
            // Choose year in dropdown list
            Wait.WaitToBeClickable(driver, "XPath", "//select[starts-with(@class,\"ui dropdown\") and contains(@name,\"yearOfGraduation\")]", 10);
            SelectElement selectElementSelectYear = new(selectYear);
            selectElementSelectYear.SelectByValue(Graduation);
            Thread.Sleep(2000);
            selectYear.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]", 10);
            addnewButtun.Click();
            Wait.WaitToBeVisible(driver, "CssSelector", ".ns-box-inner", 5);
                     

        }

      

        public void AddCertification()
        {

            // Create Certification 

            IWebElement certificationButon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButon.Click();


            //Click on add new Button to create Certification

            IWebElement addnewButton = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[@class='ui teal button '][normalize-space()='Add New']"));
            addnewButton.Click();


            // Input Award into textBox Certification

            IWebElement awardsTextBox = driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
            awardsTextBox.SendKeys("NetRiders Challenge 2011");
            Thread.Sleep(2000);

            //Input Cerfication form into textBox

            IWebElement formTextBox = driver.FindElement(By.Name("certificationFrom"));
            formTextBox.SendKeys("pdf");
            Thread.Sleep(2000);

            //Select certification Year dropdown

            IWebElement certificationYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            certificationYear.Click();

            //Input cerfication year

            IWebElement selectYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[14]"));
            selectYear.Click();


            // Click on add button to save Certification

            IWebElement ADDButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            ADDButton.Click();

        }

        public void AddLanguages()
        {
         // Create Languages 
         Languagebutton.Click();
        // ADD language button
         addlanguage.Click();
        // Input languages in textBox
         inputLanguagesTextBox.SendKeys("English");
        // Choose language level
         levelLanguage.Click();
         AddClick.Click();
        }
        public string GetDescription()
        {
            IWebElement actualDescription = driver.FindElement(By.XPath("//span[contains(text(),'An organized candidate is a detail-oriented person')]"));
            return actualDescription.Text;

        }

        public string getSkill()
        {

            //IWebElement skillsButton = driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
            skillsButton.Click();


            IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return newSkill.Text;
        }

        public string newLanguage()
        {

            IWebElement Languagebutton = driver.FindElement(By.XPath("//a[contains(@class,'item active')]"));
            Languagebutton.Click();

            IWebElement updateLanguage = driver.FindElement(By.XPath("//div[@id=\"account-profile-section\"]//form//tbody//td[1]"));
            return updateLanguage.Text;

        }
        public string getCertification()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10);
            IWebElement certificationButon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));  ////*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]
            certificationButon.Click();
            IWebElement newCertification = driver.FindElement(By.XPath("//td[normalize-space()='pdf']"));
            return newCertification.Text;

        }

        // EDIT Certification

        public void EditCertification()
        {

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10);

            IWebElement certificationButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButton.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr[last()]/td[4]/span[1]/i", 10);
            IWebElement updateCertification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr[last()]/td[4]/span[1]/i"));
            updateCertification.Click();

            IWebElement CertificateOrAward = driver.FindElement(By.XPath("//input[contains(@class , 'certification-award capitalize')]"));

            CertificateOrAward.Clear();

            CertificateOrAward.SendKeys("NetRiders2012");


            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[2]/input", 10);
            IWebElement certificationFrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[2]/input"));
            certificationFrom.Clear();
            certificationFrom.SendKeys("html");

            //Wait.WaitToBeClickable(driver, "XPath", "//select[contains(@class , 'ui fluid dropdown')]", 10);
            IWebElement certificationYearSelect = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select"));
            certificationYearSelect.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select/option[11]", 10);
            IWebElement selected2014 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select/option[11]"));
            selected2014.Click();


            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]", 10);
            IWebElement updateCertificationButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            updateCertificationButton.Click();
            //Wait.WaitToBeVisible(driver, "CssSelector", ".ns-box-inner", 5);
            driver.Navigate().GoToUrl("http://localhost:5000/Account/Profile");
            driver.Navigate().Refresh();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10);

            IWebElement certificationButton1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButton1.Click();

        }

        public string updatedCertification()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//a[contains(@class , 'item active')]", 10);
            IWebElement certificationButton = driver.FindElement(By.XPath("//a[contains(@class , 'item active')]"));
            certificationButton.Click();


            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[1]", 10);
            IWebElement certification1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[1]"));
            return certification1.Text;

        }
        public void deleteCertification()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);
            IWebElement certificationButon1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButon1.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i", 5);
            IWebElement deleteCertification1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));


            deleteCertification1.Click();

        }
        public string DeletedCertification()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);
            IWebElement certificationButon1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButon1.Click();

            IWebElement deleteSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td"));
            return deleteSkill.Text;

        }

        // Edit Language

        public void editNewLanguage()
        {
         WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
         wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")));
         Languagebutton.Click();
         Wait.WaitToBeClickable(driver, "XPath", "//span[contains(@class,\"button\")]", 10);
         editButton.Click();
         Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input", 10);
         editLanguage.Clear();
         Thread.Sleep(2000);
         editLanguage.SendKeys("Italian");
         Thread.Sleep(2000);
         selectLanguage.Click();
         LanguageLevel.Click();
         Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]", 10);
         updateButton.Click();
         Wait.WaitToBeVisible(driver, "CssSelector", ".ns-box-inner", 5);
         driver.Navigate().GoToUrl("http://localhost:5000/Account/Profile");
         driver.Navigate().Refresh();
         Languagebutton.Click();
        }
        public string editedLanguage1()
        {
            IWebElement Languageesbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            Languageesbutton.Click();

            IWebElement lastedit = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return lastedit.Text;
           
        }

        public void deletedLanguage1()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 10);
            IWebElement Languageesbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            Languageesbutton.Click();

            IWebElement languageRemoved = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            languageRemoved.Click();

        }
        public string getdeleteLanguage()

        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 10);
            IWebElement Languageesbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            Languageesbutton.Click();
            IWebElement languageRemoved = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            return languageRemoved.Text;
        }




        // Edit Skills


        public void editedSkills()
        {

            Wait.WaitToBeClickable(driver, "XPath", "//a[contains(@data-tab,'second')]   ", 10);
            IWebElement clickskillsButton = driver.FindElement(By.XPath("//a[contains(@data-tab,'second')]   "));
            clickskillsButton.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]", 10);
            IWebElement outlineWriteIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]"));
            outlineWriteIcon.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//input[contains(@value, \"breathing\")]", 10);
            IWebElement editskill = driver.FindElement(By.XPath("//input[contains(@value, \"breathing\")]"));
            editskill.Clear();
            editskill.SendKeys("Computer skills");
            Wait.WaitToBeClickable(driver, "XPath", "//select[contains(@name,'level')]", 10);
            IWebElement selectLevel = driver.FindElement(By.XPath("//select[contains(@name,'level')]"));
            selectLevel.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//option[contains(@value,'Expert')]", 10);
            IWebElement optionSelect = driver.FindElement(By.XPath("//option[contains(@value,'Expert')]"));

            Wait.WaitToBeClickable(driver, "XPath", "//input[contains(@class,'ui teal button')]", 10);
            IWebElement updateButton = driver.FindElement(By.XPath("//input[contains(@class,'ui teal button')]"));
            updateButton.Click();

            //Refresh the page            
            driver.Navigate().GoToUrl("http://localhost:5000/Account/Profile");
            driver.Navigate().Refresh();
            Wait.WaitToBeClickable(driver, "XPath", "//a[contains(@data-tab,'second')]   ", 10);
            IWebElement clickskillsButton1 = driver.FindElement(By.XPath("//a[contains(@data-tab,'second')]   "));
            clickskillsButton1.Click();


        }
        public string newEditSkills()
        {

            IWebElement clickskillsButton = driver.FindElement(By.XPath("//a[@class='item active']"));
            clickskillsButton.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10);
            IWebElement neweditedskills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            return neweditedskills.Text;


        }
        public void deleteNewSkills()
        {
            IWebElement clickskillsButton = driver.FindElement(By.XPath("//a[@class='item active']"));
            clickskillsButton.Click();

            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]", 10);
            IWebElement deletedNewSkills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            //driver.Navigate().GoToUrl("http://localhost:5000/Account/Profile");
            //driver.Navigate().Refresh();
            //IWebElement clickskillsButton1 = driver.FindElement(By.XPath("//a[@class='item active']"));
            //clickskillsButton1.Click();

        }
        public string lastDeleteSkill()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/Account/Profile");
            driver.Navigate().Refresh();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 10);
            IWebElement clickskillsButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            clickskillsButton.Click();

            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]", 10);
            IWebElement lastDelete = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]"));
            return lastDelete.Text;

        }


        public EducationInfo getEducationCountryName(String expectedCountryName)
        {
            EducationInfo educationInfo = new EducationInfo();
            var table = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table"));
            // Find all rows within the table
            var rows = table.FindElements(By.TagName("tr"));
            // Create a list to store the values from the table

            // Iterate over the rows (skipping the header row if applicable)
            for (int i = 1; i < rows.Count; i++)
            {
                var row = rows[i];
                // Find the columns within each row
                var columns = row.FindElements(By.TagName("td"));
                // Add the desired column value to the list
                IWebElement countryElement = columns[0]; // Assuming the value is in the first column

                IWebElement universityElement = columns[1]; // Assuming the value is in the first column
                IWebElement titleElement = columns[2];
                IWebElement degreeElement = columns[3];
                IWebElement graduationYearsElement = columns[4];


                if (expectedCountryName.Equals(countryElement.Text))
                {
                    educationInfo.setCountryName(countryElement.Text);
                    educationInfo.setTitleName(titleElement.Text);
                    educationInfo.setDegreeName(degreeElement.Text);
                    educationInfo.setGradutaiongName(graduationYearsElement.Text);
                    educationInfo.setUniversityName(universityElement.Text);

                    string cName = countryElement.Text;
                    string tName = titleElement.Text;
                    string dName = degreeElement.Text;
                    string gName = graduationYearsElement.Text;
                    string universityName = universityElement.Text;

                }


            }
         
            return educationInfo;


        }













    }



}

