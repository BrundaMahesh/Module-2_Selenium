using Assignment1_14_11_2023;
using NUnit.Framework;

AmazonTests amazonTests = new AmazonTests();
amazonTests.InitializeChromeDriver();
try
{  
    amazonTests.TitleTest();
    amazonTests.OrganisationTypeTest();
}
catch(AssertionException)
{
    Console.WriteLine("Fail");
}
amazonTests.Destruct();