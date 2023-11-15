using Assignment2_14_11_2023;
using NUnit.Framework;

NavigationTests navigationTests = new NavigationTests();
navigationTests.InitializeChromeDriver();
try
{
    navigationTests.GoToYahooTest();
    navigationTests.BackToGoogleTest();
    navigationTests.BackToYahooTest();
    navigationTests.BackToGoogleAgainTest();
    navigationTests.GSTest();
    navigationTests.RefreshTest();
}
catch(AssertionException)
{
    Console.WriteLine("Fail");
}
navigationTests.Exit();