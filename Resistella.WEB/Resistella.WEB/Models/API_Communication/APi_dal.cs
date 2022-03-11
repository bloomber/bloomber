using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Resistella.WEB.Models.API_Communication
{
    public class APi_dal
    {
        public APi_dal()
        {

        }
        public async void GetArticle(string adress)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(adress);
                //HTTP GET
                var responseTask = client.GetAsync("Article");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                      string responseBody = await result.Content.ReadAsStringAsync();
                    //var readTask = result.Content.ReadAsAsync<IList<StudentViewModel>>();
                    //readTask.Wait();

                    //students = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    //students = Enumerable.Empty<StudentViewModel>();

                    //ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            //return View(students);
        }

    }
}
