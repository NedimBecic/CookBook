using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class WebDriverManager
{
    private static IWebDriver driver;

    private WebDriverManager() { }

    public static IWebDriver GetDriver()
    {
        if (driver == null)
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe"; 
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
        }
        return driver;
    }

    public static void QuitDriver()
    {
        if (driver != null)
        {
            driver.Quit();
            driver = null;
        }
    }
}
