using OpenQA.Selenium;
using System.Threading;

public class SearchResultsPage
{
    private IWebDriver driver;

    private By firstResultTitle = By.CssSelector(".px-3:nth-child(10) .hover\\3Atext-gray-600 > .font-title");

    public SearchResultsPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public KlixArticlePage ClickFirstResult()
    {
        Thread.Sleep(1000);
        driver.FindElement(firstResultTitle).Click();
        return new KlixArticlePage(driver);
    }
}
