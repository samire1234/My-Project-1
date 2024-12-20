using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EF;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EF
{
    public class EfProductDal : BaseRepository<Product, BaseProjectContext>,IProductDal
    {

    }
}

































//public EfProductDal()
//{

//}
//public void Add(Product product)
//{
//    using (var context = new BaseProjectContext())
//    {
//        var addProduct = context.Entry(product);
//        addProduct.State = EntityState.Added;
//        context.SaveChanges();
//    }
//}

//public void Delete(Product product)
//{
//    using (var context = new BaseProjectContext())
//    {
//        var deleteProduct = context.Entry(product);
//        deleteProduct.State = EntityState.Deleted;
//        context.SaveChanges();
//    }
//}

//public Product Get(Expression<Func<Product, bool>> filter)
//{
//    throw new NotImplementedException();
//}

//public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
//{
//    using (var context = new BaseProjectContext())
//    {
//        return context.Set<Product>().ToList();
//    };
//}

//public void Update(Product entity)
//{
//    throw new NotImplementedException();
//}
//    };
