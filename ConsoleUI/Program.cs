using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Transformation Object
            //ProductTest();
            CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            var result = categoryManager.GetAll();

            if (result.Success)
            {
                foreach (var category in result.Data)
                {
                    Console.WriteLine(category.CategoryName);
                }
            }


        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails();

            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.CategoryName + " = " + product.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }
    }
}
