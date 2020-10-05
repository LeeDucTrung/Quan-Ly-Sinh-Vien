using APP.MODELS;
using APP.REPOSITORY;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.MANAGER
{
    public interface ISinhVienManager
    {
        Task<List<SinhViens>> Get_List(string name,int pageSize, int pageNumber);
    }
    public class SinhVienManager :ISinhVienManager
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<SinhViens> _logger;
        public SinhVienManager(IUnitOfWork unitOfWork, ILogger<SinhViens> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        public async Task<List<SinhViens>> Get_List(string name = "",int pageSize = 10, int pageNumber = 0)
        {
            try
            {
                var data = (await _unitOfWork.SinhVienRepository.FindBy(x => ((string.IsNullOrEmpty(name) || x.tenSinhVien.ToLower().Contains(name)))
                                                                    )).ToList();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
