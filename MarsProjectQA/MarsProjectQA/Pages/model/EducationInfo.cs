using OpenQA.Selenium.DevTools.V109.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectQA.Pages.model
{

    public class EducationInfo
    {

        private String countryName;
        private String titleName;
        private String degreeName;
        private String gradutaiongName;
        private String universityName;


        public void setCountryName(String countryName)
        {
            this.countryName = countryName;
        }

        public String getCountryName()
        {
            return this.countryName;
        }
        public void setTitleName(String titleName)
        {
            this.titleName = titleName;
        }

        public String getTitleName()
        {
            return this.titleName;
        }
        public void setDegreeName(String degreeName)
        {
            this.degreeName = degreeName;
        }

        public String getDegreeName()
        {
            return this.degreeName;
        }
        public void setGradutaiongName(String gradutaiongName)
        {
            this.gradutaiongName = gradutaiongName;
        }

        public String getGradutaiongName()
        {
            return this.gradutaiongName;
        }
        public void setUniversityName(String universityName)
        {
            this.universityName = universityName;
        }

        public String getUniversityName()
        {
            return this.universityName;
        }

        internal void setGradutaiongName(object text)
        {
            throw new NotImplementedException();
        }
    }
}
