using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ASPNET_Core_2_1.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ASPNET_Core_2_1.Controllers
{
    public class QnAController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        public QnAController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> QuestionList()
        {
            string requestStr = "http://localhost:19845/api/questions/";
            var request = new HttpRequestMessage(HttpMethod.Get,
            requestStr);
           
            var client = _clientFactory.CreateClient();

            var task = client.SendAsync(request);
            var str = await task.Result.Content.ReadAsStringAsync();
            QuestionResponse arr = JsonConvert.DeserializeObject<QuestionResponse>(str);
            return View(arr);
        }

        public async Task<IActionResult> QuestionDetail(String id)
        {
            string requestStr = "http://localhost:19845/api/questions/" + id;
            var request = new HttpRequestMessage(HttpMethod.Get, requestStr);

            var client = _clientFactory.CreateClient();

            var task = client.SendAsync(request);
            var str = await task.Result.Content.ReadAsStringAsync();
            QuestionDetailModel arr = JsonConvert.DeserializeObject<QuestionDetailModel>(str);
            QuestionDetailandAnswer data = new QuestionDetailandAnswer {
                QuestionDetail = arr,
                Answer = ""
            };
            return View(data);
        }

        public async Task<IActionResult> QuestionDetailError(String id)
        {
            string requestStr = "http://localhost:19845/api/questions/" + id;
            var request = new HttpRequestMessage(HttpMethod.Get, requestStr);

            var client = _clientFactory.CreateClient();

            var task = client.SendAsync(request);
            var str = await task.Result.Content.ReadAsStringAsync();
            QuestionDetailModel arr = JsonConvert.DeserializeObject<QuestionDetailModel>(str);
            QuestionDetailandAnswer data = new QuestionDetailandAnswer
            {
                QuestionDetail = arr,
                Answer = ""
            };
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuestion(QuestionModel model)
        {
            model.CreatedUserID = "6e2e6aa0-8392-4892-a177-f1d073355cdd";
            string requestStr = "http://localhost:19845/api/questions/";
            var request = new HttpRequestMessage(HttpMethod.Post,
            requestStr);
            request.Content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            var client = _clientFactory.CreateClient();

            var task = client.SendAsync(request);
            var str = await task.Result.Content.ReadAsStringAsync();

            return RedirectToAction("QuestionList", "QnA");
        }


        [HttpPost]
        public async Task<IActionResult> CreateAnswer(QuestionDetailandAnswer model, String id)
        {
            var datamodel = new AnswerDataModel
            {
                QuestionId = id,
                CreatedUserID = "6e2e6aa0-8392-4892-a177-f1d073355cdd",
                Content = model.Answer
            };

            string requestStr = "https://www.purgomalum.com/service/containsprofanity?text=" + model.Answer;
            var request = new HttpRequestMessage(HttpMethod.Get,
            requestStr);

            var client = _clientFactory.CreateClient();

            var task = client.SendAsync(request);
            var str = await task.Result.Content.ReadAsStringAsync();

            if (str.Equals("false"))
            {

                string ansRequestStr = "http://localhost:19845/api/answers/";
                var ansRequest = new HttpRequestMessage(HttpMethod.Post, ansRequestStr);
                ansRequest.Content = new StringContent(JsonConvert.SerializeObject(datamodel), Encoding.UTF8, "application/json");
                var ansclient = _clientFactory.CreateClient();
                var ansTask = ansclient.SendAsync(ansRequest);
                var ansStr = await ansTask.Result.Content.ReadAsStringAsync();

                return RedirectToAction("QuestionDetail", "QnA", new { id = id});
                //return Ok(ansStr);
            }
            else
            {
                return RedirectToAction("QuestionDetailError", "QnA", new { id = id});
                //return Ok("Check your answer. Improper use of language.");
            }


        }


    }
}