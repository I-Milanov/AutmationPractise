using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automationpractice.Pages
{
    public partial class BasePage
    {

        public IWebElement FollowUsFacebook => Driver.FindElement(By.CssSelector("#social_block .facebook"));
        public IWebElement FollowUsTwitter => Driver.FindElement(By.CssSelector("#social_block .twitter"));
        public IWebElement FollowUsYoutube => Driver.FindElement(By.CssSelector("#social_block .youtube"));
        public IWebElement FollowUsGooglePlus => Driver.FindElement(By.CssSelector("#social_block .google-plus"));

        public IWebElement NewsletterInput => Driver.FindElement(By.CssSelector("#newsletter-input"));
        public IWebElement NewsletterButton => Driver.FindElement(By.Name("submitNewsletter"));



    }
}
