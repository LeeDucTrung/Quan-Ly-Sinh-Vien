using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP.MANAGER;
using Microsoft.AspNetCore.Mvc;
using Portal.Utils;

namespace APP.API.Controllers
{
    [Route("api/sinhvien")]
    [ApiController]
    public class SinhVienController : Controller
    {
        private readonly ISinhVienManager _sinhvien;

        public SinhVienController(ISinhVienManager sinhVienManager)
        {
            this._sinhvien = sinhVienManager;
        }
        [HttpGet("get-list")]
        public async Task<IActionResult> GetList(string name, int pageSize = 10, int pageNumber = 0)
        {
            try
            {
                var data = await _sinhvien.Get_List(name, pageSize, pageNumber);
                if (data == null)
                {
                    throw new Exception(MessageConst.DATA_NOT_FOUND);
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
