using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP.MODELS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Portal.Utils;

namespace APP.CMS.Controllers
{
    [Route("sinh-vien")]
    public class SinhVienController : Controller
    {
        private readonly IConfiguration _config;
        private readonly string _domain;
        public SinhVienController(IConfiguration config)
        {
            this._config = config;
            this._domain = _config["APIDomain"].ToString();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Create")]
        public IActionResult CreateSinhVien()
        {
            return PartialView("CreateSinhVien");
        }
        [HttpGet("get-list")]
        public async Task<IActionResult> GetList(string name)
        {
            var data = await HttpHelper.GetData<List<SinhViens>>($"{_domain}/api/sinhvien/get-list", $"name={name}");
            return PartialView("GetList", data);
        }
    }
}
