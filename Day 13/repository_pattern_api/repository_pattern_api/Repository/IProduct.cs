using repository_pattern_api.Model;
namespace repository_pattern_api.Repository
{
    public interface IProduct
    {
        List<Products> GetProducts();
        Products GetProductById(int id);

        string AddProduct(Products newProduct);
        string DeleteProduct(int productId);

        string EditProduct(Products changes);


    }
}
