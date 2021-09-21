using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaVuBaku.Dto;

namespace VaVuBaku.Repositories.Abstracts.Product
{
    public interface IProduct<T> where T: new()
    {
        ResponseFrame AddQuantity(T entity, int Id);
    }
}
