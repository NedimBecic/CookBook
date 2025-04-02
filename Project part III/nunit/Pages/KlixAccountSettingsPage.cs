using OpenQA.Selenium;
using System;
using System.Threading;

public class KlixAccountSettingsPage
{
    private IWebDriver driver;

    private By deleteAccountLink = By.LinkText("obriši korisnički nalog");
    private By confirmationMessage = By.CssSelector("div.message");
    private By editProfileLink = By.LinkText("uredi profil");

    public KlixAccountSettingsPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void DeleteAccount()
    {
        Thread.Sleep(1000);
        driver.FindElement(deleteAccountLink).Click();
    }

    public string GetConfirmationMessage()
    {
        return driver.FindElement(confirmationMessage).Text;
    }

    public string getUrl()
    {
        return driver.Url;
    }

    public KlixEditProfilePage GoToEditProfile()
    {
        Thread.Sleep(1000);
        driver.FindElement(editProfileLink).Click();
        return new KlixEditProfilePage(driver);
    }


}