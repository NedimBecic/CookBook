using OpenQA.Selenium;

public class KlixCategoryPage
{
    private IWebDriver driver;

    private By firstArticle = By.CssSelector(".container:nth-child(2) .hover\\3Atext-gray-600 > .font-title");
    

    public KlixCategoryPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public KlixArticlePage OpenFirstArticle()
    {
        driver.FindElement(firstArticle).Click();
        return new KlixArticlePage(driver);
    }
}
