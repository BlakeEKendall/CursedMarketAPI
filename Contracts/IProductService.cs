using Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IProductService
    {
        void CreateProduct(ProductCreateModel productToCreate);
        List<ProductListItem> GetProductList();
        void UpdateProduct(ProductUpdateModel productToUpdate);

        //ProductDetailItem GetDetailedProduct(int productID)
        void DeleteProduct(ProductDeleteModel productToDelete);
    }
}
