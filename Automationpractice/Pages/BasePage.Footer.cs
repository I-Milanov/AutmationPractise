using OpenQA.Selenium;

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

        public IWebElement FooterLinkSpecials => Driver.FindElement(By.XPath("//*[@id='block_various_links_footer']//li//a[contains(text(),\"Specials\")]"));

    
        public IWebElement FooterLinkNewProducts => Driver.FindElement(By.XPath("//*[@id='block_various_links_footer']//a[contains(text(),\"New products\")]"));

        //To Do
    }
}
