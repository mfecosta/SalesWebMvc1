using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc1.Data
{
    public class SeedingService
    {
        private SalesWebMvc1Context _context;
        
        public SeedingService(SalesWebMvc1Context context)
        {
            _context = context;
        }
        public void Seed()
        {
            if(_context.Department.Any() ||
                _context.Selller.Any()||
                _context.SallesRecord.Any())
            {
                return;// se o banco foi populado não faz nada
            }


        }
    }
}
