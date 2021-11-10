using System.Net;
using System.IO;
using HtmlAgilityPack;

String variableName = "https://www.youtube.com/playlist?list=PLNF97D26mpE4VxDazVrsLShzp9xq5rSNC";
WebRequest webRequest = HttpWebRequest.Create(variableName);
WebResponse webResponse = webRequest.GetResponse();
StreamReader streamReader = new StreamReader(webResponse.GetResponseStream());
Console.WriteLine(streamReader.ReadToEnd());
HtmlDocument htmlDocument = new HtmlDocument();
htmlDocument.LoadHtml(streamReader.ReadToEnd());
String someResult = htmlDocument.DocumentNode.SelectSingleNode("//div/contents").Attributes["class"].Value;
Console.WriteLine(someResult);
//HTMLparser htmlParse = new HTMLparser(streamReader.ToString());