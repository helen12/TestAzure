using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestAzure.Models;

namespace TestAzure.Controllers
{
    public class GetInputController : Controller
    {
        // GET: GetInput
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult takeInput()
        {
            SearchData searchedRes = new SearchData();
            searchedRes.searchSentence = Request.Form["sent"];
            searchedRes.searchKey = Request.Form["srk"];
            //String val1, val2;
            //WebClient proxy = new WebClient();

            //string serviceURL = string.Format("http://localhost:2009/WordSearchService.svc/Search/searchSentence/searchKey");
            ////Console.WriteLine("HI");
            ////Console.ReadKey();
            //byte[] data = proxy.DownloadData(serviceURL);
            //Stream stream = new MemoryStream(data);
            //var reader = new StreamReader(stream);
            //var result = reader.ReadToEnd();


            //SServiceReference1.WordSearchServiceClient clt1 = new SServiceReference1.WordSearchServiceClient();
            //string result=clt1.Search("abebe beso albelam eko", "eko");

            //searchedRes.searchSentence = result;
            //searchedRes.searchKey = "Eko";
            searchedRes.searchResult = searchedRes.searchKey;

            return View(searchedRes);
            
        }
    }
}