using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaVuBaku.Data;
using VaVuBaku.Dto;
using VaVuBaku.Models;
using VaVuBaku.Repositories.Abstracts;
using VaVuBaku.Repositories.Abstracts.Product;

namespace VaVuBaku.Repositories
{
    public class ProductsRepos : ITransactions<Product>, IProduct<Product>
    {
        private readonly AdminContext _db;
        public ProductsRepos(AdminContext db)
        {
            _db = db;
        }
        public ResponseFrame Add(Product entity)
        {
            bool existed = _db.Products.Any(a => a.Name == entity.Name);
            if (existed)
            {
                return new ResponseFrame{ Code = 400, Message = "This Product is already exist", Data = "" };
            }
            if (entity.Weight > 0 && entity.Quantity > 0)
            {
                return new ResponseFrame { Code = 400, Message = "You can only assign weight or quantity, both not accepted", Data = "" };
            }
            try
            {
                _db.Products.Add(entity);
                _db.SaveChanges();
                return new ResponseFrame { Code = 200, Message = "Product successfully added", Data = entity.Name };
            }
            catch (Exception x)
            {
                return new ResponseFrame { Code = 500, Message = x.Message, Data = "" };
            }
        

        }

        public ResponseFrame AddQuantity(Product entity, int Id)
        {
            Product product = _db.Products.Where(a=> a.Id == Id).FirstOrDefault();
            if (product is null)
            {
                return new ResponseFrame { Code = 400, Message = "This Product is not exist", Data = entity.Name };
            }
            if (entity.Weight > 0 && entity.Quantity > 0)
            {
                return new ResponseFrame { Code = 400, Message = "You can only assign weight or quantity, both not accepted", Data = "" };
            }
            //if (product.Quantity !> entity.Quantity || product.Weight !> entity.Weight)
            //{
            //    return new ResponseFrame { Code = 400, Message = "You can only assign weight or quantity, both not accepted", Data = "" };
            //}
            try
            {
                product.Quantity = entity.Quantity;
                product.Weight = entity.Weight;
                _db.SaveChanges();
                return new ResponseFrame { Code = 200, Message = "Quantity and Weight successfully added", Data = entity.Name };
            }
            catch (Exception x)
            {
                return new ResponseFrame { Code = 500, Message = x.Message, Data = entity.Name };
            }
          

        }

        public object Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public ResponseFrame Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
