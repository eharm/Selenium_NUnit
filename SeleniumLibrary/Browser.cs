using System.Collections.ObjectModel;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace SeleniumLibrary;
public class Browser
{
   private const string WEBDRIVER_FOLDER = @"C:\Users\evan_\Code\Selenium\WebDrivers";
   private IWebDriver wd { get; set; }
   public IWebDriver WebDriver => wd;
   private Driver ChosenDriver;

   public Browser()
   {
      // TODO Add support for other browsers
      switch (ChosenDriver)
      {
         case Driver.Chrome:
            wd = new ChromeDriver(WEBDRIVER_FOLDER);
            break;
         case Driver.Edge:
            wd = new EdgeDriver(WEBDRIVER_FOLDER);
            break;
         case Driver.Firefox:
            wd = new FirefoxDriver(WEBDRIVER_FOLDER);
            break;
         default:
            wd = new ChromeDriver(WEBDRIVER_FOLDER);
            break;
      }
      wd.Manage().Window.Maximize();
   }

   public string CurrentWindowHandle => wd.CurrentWindowHandle;
   public string PageSource => wd.PageSource;
   public string Title => wd.Title;
   public string Url { get { return wd.Url; } set { wd.Url = value; } }
   public ReadOnlyCollection<string> WindowHandles => wd.WindowHandles;

   public void Close() { wd.Close(); }
   public IOptions Manage() { return wd.Manage(); }
   public INavigation Navigate() { return wd.Navigate(); }
   public void Quit() { wd.Quit(); }
   public ITargetLocator SwitchTo() { return wd.SwitchTo(); }
   public IWebElement FindElement(By by) { return wd.FindElement(by); }
   public ReadOnlyCollection<IWebElement> FindElements(By by) { return wd.FindElements(by); }
   public void Dispose() => wd.Dispose();

}


public enum Driver
{
   Chrome,
   Edge,
   Firefox
}