using SalesWebMvc1.Data;
using SalesWebMvc1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc1.Services
{
    public class SellerService
    {
        private readonly SalesWebMvc1Context _context;

        public SellerService(SalesWebMvc1Context context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Selller.ToList();//método que retorna todos os vendedores da lista
        }

        public void Insert(Seller obj)
        {
            //obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
        public Seller FindById(int id)
        {
            return _context.Selller.FirstOrDefault(obj => obj.Id == id);

        }

        public void Remove(int id)
        {
            var obj = _context.Selller.Find(id);
            _context.Selller.Remove(obj);
            _context.SaveChanges();
        }
    }
    
}
