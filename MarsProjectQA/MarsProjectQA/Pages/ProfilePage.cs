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

namespace MarsProjectQA.Pages
{
    public class ProfilePage : CommonDriver
    {
        WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

        public void CreateProfile(IWebDriver driver)
        {
            IWebElement description = driver.FindElement(By.XPath("//h3[@class='ui dividing header']//i[@class='outline write icon']"));
            description.Click();



            //Write Description

            IWebElement putDescription = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            putDescription.Clear();
            Thread.Sleep(4000);
            putDescription.SendKeys("An organized candidate is a detail-oriented person an employer can trust to meet deadlines.");



            //Click save button on Description
            IWebElement saveButton = driver.FindElement(By.XPath("//button[@type='button']"));
            saveButton.Click();



            //Click on SkillS Button

            IWebElement skillsButton = driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
            skillsButton.Click();



            //Click on Skills addNew Button 

            IWebElement addNewButton = driver.FindElement(By.XPath("//div[@class='ui teal button']"));
            addNewButton.Click();


            Wait.WaitToBeVisible(driver, "XPath", "//input[@placeholder='Add Skill']", 10);
            IWebElement inputSkill = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            inputSkill.SendKeys("breathing");




            //Select dropdown in Skills

            IWebElement selectDropDown = driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"));
            selectDropDown.Click();


            // Select level in Skills
            IWebElement addskillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            addskillLevel.Click();


            // Save Skills click on add button

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//body/div[@id='account-profile-section']/div/section/div[@class='ui fluid container']/div[@class='ui grid']/div[@class='row']/div[1]")));


            IWebElement saveSkillButton = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div/section/div[@class='ui fluid container']/div[@class='ui grid']/div[@class='row']/div[1]"));
            saveSkillButton.Click();









            // Click on Education button

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[normalize-space()='Education']")));

            IWebElement educationButton = driver.FindElement(By.XPath("//a[normalize-space()='Education']"));
            educationButton.Click();

            //Click on Education add new Button

            IWebElement EdnewButton = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
            EdnewButton.Click();


            // Input College/University name

            IWebElement universityName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            universityName.SendKeys("CCNP Cisco EduNet");


            // Click on Country of College/University dropdown

            IWebElement universityDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            universityDropdown.Click();

            // Select Country of College/University dropdown

            IWebElement countryCollege = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[36]"));
            countryCollege.Click();


            // Click on title dropdown

            IWebElement titleDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            titleDropdown.Click();


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


            // Click on certification button

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








            //Click on Languages button

            IWebElement Languageesbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            Languageesbutton.Click();



            // ADD language button

            IWebElement addlanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addlanguage.Click();


            // Input languages in textBox

            IWebElement inputLanguagesTextBox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            inputLanguagesTextBox.SendKeys("English");

            // Choose language level

            IWebElement levelLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
            levelLanguage.Click();

            IWebElement AddClick = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            AddClick.Click();








        }
        public string getSkill(IWebDriver driver)
        {


            IWebElement skillsButton = driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
            skillsButton.Click();


            IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            return newSkill.Text;                               //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[1]
        }









        public string newLanguage(IWebDriver driver)
        {
            IWebElement Languageesbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            Languageesbutton.Click();

            IWebElement updateLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return updateLanguage.Text;




        }
        public string getCertification(IWebDriver driver)
        {

            IWebElement certificationButon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButon.Click();
            IWebElement newCertification = driver.FindElement(By.XPath("//td[normalize-space()='pdf']"));
            return newCertification.Text;


        }


        // EDIT Certification

        public void editCertification(IWebDriver driver)
        {

            //Wait.WaitToBeClickable(driver, "XPath", "//a[normalize-space()='Certifications']", 10);

            IWebElement certificationButton = driver.FindElement(By.XPath("//a[normalize-space()='Certifications']"));
            certificationButton.Click();

            IWebElement updateCertification = driver.FindElement(By.XPath("//tbody[1]/tr[1]/td[4]/span[1]/i[1]"));
            updateCertification.Click();

            IWebElement aword = driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
            aword.Clear();

            aword.SendKeys("NetRiders Challenge 2012");

            IWebElement selectYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select"));
            selectYear.Click();
            IWebElement selectYear1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select/option[11]"));
            selectYear1.Click();
            IWebElement certificationFrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[2]/input"));
            certificationFrom.Clear();
            certificationFrom.SendKeys("html");




            IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateButton.Click();

        }

        public string updatedCertification(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10);
            IWebElement certificationButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButton.Click();

            //// Get table xpath
            //var elemTable = driver.FindElement(By.XPath("//td[normalize-space()='NetRiders Challenge 2012"));
            //// Fetch all table rows
            //List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            //String strRowData = "";
            //// Looping through table rows
            //foreach (var elemTr in lstTrElem)
            //{
            //    // Get/access to all columns
            //    List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
            //    if (lstTdElem.Count > 0)
            //    {
            //        if (lstTdElem[0].Text == "NetRiders Challenge 2012")
            //        {
            //            //Click the edit button
            //            List<IWebElement> btn = new List<IWebElement>(lstTdElem[2].FindElements(By.XPath("span")));
            //            btn[0].Click();
            //        }
            //    }
            //    else
            //    {
            //        strRowData = String.Empty;
            //    }
            //    strRowData = String.Empty;
            //}




            IWebElement certification = driver.FindElement(By.XPath("//td[normalize-space()='NetRiders Challenge 2012']"));
            return certification.Text;


        }
        public void deleteCertification(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);
            IWebElement certificationButon1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButon1.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i", 5);
            IWebElement deleteCertification1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));


            deleteCertification1.Click();



        }
        public string DeletedCertification(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);
            IWebElement certificationButon1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButon1.Click();

            IWebElement deleteSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td"));
            return deleteSkill.Text;

        }





        // Edit Language


        public void editLanguage(IWebDriver driver)
        {
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")));


            IWebElement Languagesbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            Languagesbutton.Click();

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editButton.Click();

            IWebElement editLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            editLanguage.Clear();
            editLanguage.SendKeys("Italian");
            IWebElement selectLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            selectLanguage.Click();
            IWebElement LanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]"));
            LanguageLevel.Click();
            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateButton.Click();







        }
        public string editedLanguage1(IWebDriver driver)
        {


            IWebElement Languageesbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            Languageesbutton.Click();



            IWebElement lastedit = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return lastedit.Text;



        }
        public void deletedLanguage1(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 10);
            IWebElement Languageesbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            Languageesbutton.Click();

            IWebElement languageRemoved = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            languageRemoved.Click();

        }
        public string getdeleteLanguage(IWebDriver driver)

        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 10);
            IWebElement Languageesbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            Languageesbutton.Click();
            IWebElement languageRemoved = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            return languageRemoved.Text;
        }




        // Edit Skills


        public void editedSkills(IWebDriver driver)
        {

            Wait.WaitToBeClickable(driver, "XPath", "//a[normalize-space()='Skills']", 10);
            IWebElement clickskillsButton = driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
            clickskillsButton.Click();

           
            IWebElement outlineWriteIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));
            outlineWriteIcon.Click();

            IWebElement editskill = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            editskill.Clear();
            editskill.SendKeys("Computer skills");
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select", 10);
            IWebElement selectLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select"));
            selectLevel.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]", 10);
            IWebElement optionSelect = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select/option[2]"));
            optionSelect.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]", 10);
            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            updateButton.Click();


        }
        public string newEditSkills(IWebDriver driver)
        {


            IWebElement clickskillsButton = driver.FindElement(By.XPath("//a[@class='item active']"));
            clickskillsButton.Click();

            IWebElement neweditedskills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[1]"));
            return neweditedskills.Text;


        }
        public void deleteNewSkills(IWebDriver driver)
        {
            IWebElement clickskillsButton = driver.FindElement(By.XPath("//a[@class='item active']"));
            clickskillsButton.Click();

            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td", 10);
            IWebElement deletedNewSkills = driver.FindElement(By.XPath("//*[@id=\\\"listing-management-section\\\"]/div[2]/div/div/table/tbody/tr[2]/td[8]/div/button[3]"));

        }
        public string lastDeleteSkill(IWebDriver driver)
        {
            IWebElement clickskillsButton = driver.FindElement(By.XPath("//a[@class='item active']"));
            clickskillsButton.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td", 10);
            IWebElement lastDelete = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td"));
            return lastDelete.Text;

        }














    }



}

