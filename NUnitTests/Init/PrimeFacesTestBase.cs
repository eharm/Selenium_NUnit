using SeleniumLibrary;

namespace NUnitTests.Init
{
   [TestFixture]
   public abstract class PrimeFacesTestBase : ITestBase
   {
      protected Browser Browser { get; private set; }

      public PrimeFacesTestBase()
      {
         Browser = new Browser();
      }


      [SetUp]
      public void SetUp()
      {
         Browser.Url = @"https://www.primefaces.org/";
      }

      [TearDown]
      public void TearDown()
      {
         Browser.Quit();
         Browser.Dispose();
      }

   }
}