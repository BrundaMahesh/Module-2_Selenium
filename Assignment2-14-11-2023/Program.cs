using Assignment2_14_11_2023;
using NUnit.Framework;

NavigationTests navigationTests = new NavigationTests();
navigationTests.InitializeChromeDriver();
try
{
    navigationTests.GoToYahooTest();
    navigationTests.BackToGoogleTest();
    navigationTests.GoToYahooTest();
    navigationTests.BackToGoogleTest();
    navigationTests.GSTest();
}
catch(AssertionException)
{
    Console.WriteLine("Fail");
}
navigationTests.Exit();