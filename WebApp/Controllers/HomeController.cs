using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeChatService _wechatService;

        public HomeController(IWeChatService wechatService)
        {
            _wechatService = wechatService;
        }
        // GET: Home
        public string Index()
        {
            var config = _wechatService.GetMpAppConfig();
            return "Welcome, coming soon.";
        }
    }
}