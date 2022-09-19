using SeleniumLibrary;

namespace NUnitTests.Init
{
   public interface ITestBase
   {
      public void SetUp();

      public void TearDown();
   }
}