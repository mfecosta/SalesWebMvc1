using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc1.Data;
using SalesWebMvc1.Models;

namespace SalesWebMvc1.Services
{
    public class SallesRecordService 
    {
        private readonly SalesWebMvc1Context _context;

        public SallesRecordService(SalesWebMvc1Context context)
        {
            _context = context;
        }
        public async Task<List<SallesRecord>> FindByDateAsync(DateTime ? minDate, DateTime? maxDate)
        {
            var result = from obj in  _context.SallesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
                
        }
    }
}
