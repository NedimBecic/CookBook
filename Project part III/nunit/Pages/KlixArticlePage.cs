using OpenQA.Selenium;
using System.Threading;

public class KlixArticlePage
{
    private IWebDriver driver;

    private By commentInput = By.Id("komentarinput");
    private By submitCommentButton = By.CssSelector(".text-gray-800");
    private By postedComment = By.CssSelector(".komentar:nth-child(1) .mb-3 > div");
    private By newsTitle = By.CssSelector(".md\\3Atext-2xl");

    public KlixArticlePage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void AddComment(string comment)
    {
        driver.FindElement(commentInput).Click();
        driver.FindElement(commentInput).SendKeys(comment);
        driver.FindElement(submitCommentButton).Click();
    }

    public string GetPostedComment()
    {
        return driver.FindElement(postedComment).Text;
    }

    public string GetNewsTitle()
    {
        Thread.Sleep(2000);
        return driver.FindElement(newsTitle).Text;
    }
}
