using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExamples;


//Assert.That(title == "Gooogle");
GHPTests gHPTests=new GHPTests();
Console.Write("Enter your choice:\n1.Chrome\n2.Edge\n");
int choice=Convert.ToInt32(Console.ReadLine());
switch(choice)
{
    case 1:
        gHPTests.InitializeChromeDriver();
        break;  
    case 2:
        gHPTests.InitializeEdgeDriver();
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}
try
{
   //gHPTests.TitleTest();
   //gHPTests.PageSourceAndURLTest();
   //gHPTests.GSTest();
  //gHPTests.GmailLinkTest();
    gHPTests.ImagesLinkTest();
}
catch(AssertionException)
{
    Console.WriteLine("Fail");
}
gHPTests.Destruct();
