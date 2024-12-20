using Business.Concrete;
using DataAccess.Concrete.EF;
using Entities.Concrete;


ProductManager productManager = new ProductManager(new EfProductDal());
Product product1 = new Product() { ProductName="samsung",ProductCount=1,ProductPrice=1000,ProductDesc="16ram",IsDiscount=false,IsDeleted=false};
//productManager.Add(product1);


//foreach (var deletedProduct in productManager.GetAllProducts())
//{
//    if (deletedProduct.Id == 2)
//    {
//        productManager.Delete(deletedProduct);
//    }
//}


Console.WriteLine("==============================================================");


foreach (var item in productManager.GetAllProducts().Data)
{
    Console.WriteLine(item.ProductName);
}


//getproduct
//foreach (var item in productManager.GetAllProducts())
//{
//    if (item.Id==2)
//    {
//        Console.WriteLine(productManager.GetProduct(item).ProductName);
//    }
//}


//foreach (var updatepr in productManager.GetAllProducts())
//{
//    if (updatepr.Id==3)
//    {
//        updatepr.ProductName = "ASUS";
//        productManager.Update(updatepr);
//    }
//}


//var productGetAll = productManager.GetAllProducts();

//foreach (var product in productGetAll)
//{
//    Console.WriteLine(product.ProductName);
//}



//CustomerManager customerManager = new CustomerManager(new EfCustomerDal()) ;
//Customer costumer1 = new Customer() { Id = 1, CustomerName = "samire",Email="samire@gmail.com",PhoneNumber=1234567,IsDeleted=false };
//customerManager.Add(costumer1);
//Console.WriteLine(costumer1.CustomerName);