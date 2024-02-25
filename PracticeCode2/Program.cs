using PracticeCode2;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
HtmlSerializer htmlSerializer = new HtmlSerializer();

var html =await htmlSerializer.Load("https://learn.malkabruk.co.il/");
HtmlElement htmlElement= htmlSerializer.BuildHtmlTree(html);
Selector selector = Selector.Parse("div.home-hero div.home-hero1 div.home-container1 h1.home-hero-heading heading1");
var result=HtmlElementExtensions.FindElementsBySelector(htmlElement, selector);
foreach (var item in result)
{
    Console.Write(item.Name + " " + item.Id + " ");
	foreach (var c in item.Classes)
	{
		Console.Write(c+" ");
	}
	Console.WriteLine();
}

