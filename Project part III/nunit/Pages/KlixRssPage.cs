using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class KlixRssPage
    {
        private IWebDriver driver;
        private By xmlTag = By.TagName("xml");

    public KlixRssPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    public bool IsXmlTagPresent()
    {
        try
        {
            return driver.FindElement(xmlTag) != null;
        }
        catch (NoSuchElementException)
        {
            return false;
        }
    }



}
