using OpenQA.Selenium;
using System.Threading;

public class KlixEditProfilePage
{
    private IWebDriver driver;

    private By usernameField = By.Id("username");
    private By saveButton = By.CssSelector(".bg-indigo-600");

    public KlixEditProfilePage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void EditUsername(string newUsername)
    {
        Thread.Sleep(1000);
        driver.FindElement(usernameField).Clear();
        driver.FindElement(usernameField).SendKeys(newUsername);
    }

    public void SaveChanges()
    {
        driver.FindElement(saveButton).Click();
    }

    // Dohvati trenutno korisničko ime
    public string GetUsername()
    {
        return driver.FindElement(usernameField).GetAttribute("value");
    }
}
