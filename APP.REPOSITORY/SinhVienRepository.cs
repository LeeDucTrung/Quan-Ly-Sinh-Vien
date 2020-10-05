using APP.MODELS;
using Microsoft.EntityFrameworkCore;
using Portal.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace APP.REPOSITORY
{
    public interface ISinhVienRepository : IRepository<SinhViens>
    {

    }
    public class SinhVienRepository : Repository<SinhViens>, ISinhVienRepository
    {
        public SinhVienRepository(DbContext context) : base(context)
        {

        }
    }
}
