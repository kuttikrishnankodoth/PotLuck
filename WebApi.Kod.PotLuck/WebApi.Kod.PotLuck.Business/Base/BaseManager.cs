using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Kod.PotLuck.Business;
using WebApi.Kod.PotLuck.Repository;

namespace WebApi.Kod.PotLuck.Business
{
    public class BaseManager<T> where T:class
    {
        protected T Repository;

        public BaseManager(T repository)
        {
            this.Repository = repository;
        }
    }
}
