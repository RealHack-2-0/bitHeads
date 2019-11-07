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
    public class AccountController : Controller

    {
        private readonly IHttpClientFactory _clientFactory;
        public AccountController(IHttpClientFactory clientFactory) {
            _clientFactory = clientFactory;
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser(RegisterModel model)
        {
            string requestStr = "http://localhost:13218/api/auth/register";
            var request = new HttpRequestMessage(HttpMethod.Post,
            requestStr);
            request.Content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            var client = _clientFactory.CreateClient();

            var task = client.SendAsync(request);
            var str = await task.Result.Content.ReadAsStringAsync();

            return RedirectToAction("Login","Account");
        }

        [HttpPost]
        public async Task<IActionResult> LoginUser(LoginModel model)
        {
            string requestStr = "http://localhost:13218/api/auth/login";
            var request = new HttpRequestMessage(HttpMethod.Post,
            requestStr);
            request.Content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            var client = _clientFactory.CreateClient();

            var task = client.SendAsync(request);
            var str = await task.Result.Content.ReadAsStringAsync();

            return RedirectToAction("QuestionList", "QnA");
        }
    }
}