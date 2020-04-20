using Data.Entities;
using Data.Models;
using Models.Products;
using System.Collections.Generic;
using System.Linq;


namespace Services
{
    public class ProductService : IProductService
    {
        public void CreateProduct(ProductCreateModel productToCreate)
        {
            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                ctx.Products.Add(new Product(productToCreate));
                ctx.SaveChanges();
                //??
            }
        }

        public List<ProductListItem> GetProductList()
        {
            using(var ctx = new ApplicationDbContext())
            {
                return ctx
                    .Products
                    .Select(product => new ProductListItem()
                {
                    ProductID = product.ProductId,
                    Name = product.Name,
                    Price = product.Price
                })
                    .ToList();
            }
        }

        public void UpdateProduct(ProductUpdateModel productToUpdate)
        {
            using (var ctx = new ApplicationDbContext())
            {
                // Find the product we want to update
                Product productWeWantToUpdate = ctx.Products.Find(productToUpdate.ProductID);
                if (productWeWantToUpdate !=null)
                {

                //update it
                productWeWantToUpdate.Name = productToUpdate.UpdatedName;
                productWeWantToUpdate.Price = productToUpdate.UpdatedPrice;
                
                //save our changes to the database
                ctx.SaveChanges();
                }
            }
        }

        //Add DeleteProduct method!!
        public void DeleteProduct(ProductDeleteModel productToDelete)
        {
            using (var ctx = new ApplicationDbContext())
            {
                // Find the product we want to Delete
                Product productWeWantToDelete = ctx.Products.Find(productToDelete.ProductID);
                if (productWeWantToDelete != null)
                {

                    //Delete it
                    ctx.Products.Remove(productWeWantToDelete);
                    //save our changes to the database
                    ctx.SaveChanges();
                }
            }
        }            
    }
}
