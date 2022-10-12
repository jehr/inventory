using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IBulkInsert
    {
        Task TruncateTable(string table);
        Task TruncateTable(string table, Guid UserId);
        Task<DataTable> SaveFile(IFormFile Request);
        Task<DataTable> Bulk(DataTable dt);
        void setTemporalTable(string table);
        Task<DataTable> ValidateBulk(string table);
    }
}
