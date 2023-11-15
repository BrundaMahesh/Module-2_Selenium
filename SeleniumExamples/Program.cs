using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExamples;


////Assert.That(title == "Gooogle");
//GHPTests gHPTests=new GHPTests();
////Console.Write("Enter your choice:\n1.Chrome\n2.Edge\n");
////int choice=Convert.ToInt32(Console.ReadLine());
////switch(choice)
////{
////    case 1:
////        gHPTests.InitializeChromeDriver();
////        break;  
////    case 2:
////        gHPTests.InitializeEdgeDriver();
////        break;
////    default:
////        Console.WriteLine("Invalid choice");
////        break;
////}
//List<string> drivers = new List<string>();
//drivers.Add("Chrome");
////drivers.Add("Edge");
//foreach (var item in drivers)
//{
//    switch (item)
//    {
//        case "Chrome":
//            gHPTests.InitializeChromeDriver();
//            break;
//        case "Edge":
//            gHPTests.InitializeEdgeDriver();
//            break;

//    }
//    try
//    {
//        //gHPTests.TitleTest();
//        //gHPTests.PageSourceAndURLTest();
//        //gHPTests.GSTest();
//        //gHPTests.GmailLinkTest();
//        //gHPTests.ImagesLinkTest();
//        //gHPTests.LocalizationTest();
//        gHPTests.GAppYoutubeTest();
//    }

//    catch (AssertionException)
//    {
//        Console.WriteLine("Fail");
//    }
//    gHPTests.Destruct();
//}



//*********************AmazonTests************************************
AmazonTests amazonTests = new AmazonTests();
List<string> drivers = new List<string>();
drivers.Add("Chrome");
//drivers.Add("Edge");
foreach (var item in drivers)
{
    switch (item)
    {
        case "Chrome":
            amazonTests.InitializeChromeDriver();
            break;
        case "Edge":
            amazonTests.InitializeEdgeDriver();
            break;

    }
    try
    {
       // amazonTests.TitleTest();
        //amazonTests.LogoClickTest();
       // amazonTests.SearchProductTest();
       // amazonTests.TodaysDealsTest();
        //amazonTests.SignInAndAccountListTest();
        amazonTests.SearchAndFilterProductByBrandTest();
        amazonTests.SortBySelectTest();
        
    }

    catch (AssertionException)
    {
        Console.WriteLine("Fail");
    }
    catch(NoSuchElementException ex)
    {
        Console.WriteLine(ex.Message);
    }
    amazonTests.Destruct();
}