using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

public class KlixHomePage
{
    private IWebDriver driver;

    private By searchOpenButton = By.Id("search-open");
    private By searchBox = By.Name("q");
    private By LinkRss = By.LinkText("RSS");
    private By loginIcon = By.CssSelector(".w-7 > .w-5");
    private By usernameField = By.Name("username");
    private By passwordField = By.Id("lpassword");
    private By loginButton = By.CssSelector(".dark\\3A bg-gray-800");
    private By user = By.LinkText("vvsproba");
    private By errorMessageDiv = By.Id("errorlogindiv");


    public KlixHomePage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void Open()
    {
        driver.Navigate().GoToUrl("https://www.klix.ba/");
    }

    public void OpenSearch()
    {
        Thread.Sleep(2000);
        driver.FindElement(searchOpenButton).Click();
    }
    
    public void ScrollToRss()
    {
        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        js.ExecuteScript("window.scrollTo(0,3913)");
    }

    public KlixRssPage OpenRSS()
    {
        driver.FindElement(LinkRss).Click();
        return new KlixRssPage(driver);

    }

    
    public SearchResultsPage SearchFor(string keyword)
    {
        Thread.Sleep(2000);
        driver.FindElement(searchBox).Click();       
        driver.FindElement(searchBox).SendKeys(keyword);
        driver.FindElement(searchBox).SendKeys(Keys.Enter);
        return new SearchResultsPage(driver);   
    }

    public void Login(string username, string password)
    {
        Thread.Sleep(2000);
        driver.FindElement(loginIcon).Click();
        Thread.Sleep(1000);
        driver.FindElement(usernameField).SendKeys(username);
        driver.FindElement(passwordField).SendKeys(password);
        driver.FindElement(loginButton).Click();
        Thread.Sleep(1000);
    }

    public void OpenUserMenu()
    {
        Thread.Sleep(3000);
        driver.FindElement(loginIcon).Click();
    }

    public KlixAccountSettingsPage OpenUserSettings()
    {
        Thread.Sleep(3000);
        driver.FindElement(user).Click();
        return new KlixAccountSettingsPage(driver);
        
    }

    public string GetErrorMessage()
    {
        return driver.FindElement(errorMessageDiv).Text;
    }


    public KlixCategoryPage OpenCategory(string category)
    {
        driver.FindElement(By.LinkText(category)).Click();
        return new KlixCategoryPage(driver);
    }

}
