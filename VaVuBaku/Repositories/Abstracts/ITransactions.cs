using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaVuBaku.Dto;

namespace VaVuBaku.Repositories.Abstracts
{
    public interface ITransactions<T> where T: new()
    {
        ResponseFrame Add(T entity);
        ResponseFrame Update(T entity);
        object Get(int Id);
        List<object> GetAll();


    }
}
