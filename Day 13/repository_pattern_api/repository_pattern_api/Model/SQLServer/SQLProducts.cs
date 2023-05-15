using repository_pattern_api.Repository;

namespace repository_pattern_api.Model.SQLServer
{
    public class SQLProducts : IProduct
    {

        ShoppingDbRepositoryPContext _shopping;

        public SQLProducts(ShoppingDbRepositoryPContext shopping)
        {
            _shopping = shopping;
        }

        public string AddProduct(Products newProduct)
        {
            throw new NotImplementedException();
        }

        public string DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public string EditProduct(Products changes)
        {
            throw new NotImplementedException();
        }

        public Products GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Products> GetProducts()
        {
            var p = _shopping.ProductSqls.ToList();

          
            List<Products> products = new List<Products>();
            foreach (var item in p)
            {
                products.Add(new Products()
                {
                    pId = item.PId,
                    pName = item.PName,
                    pCategory = item.PCategory,
                    pPrice =Convert.ToDouble( item.PPrice),
                    pIsInStock =Convert.ToBoolean(item.PIsInStock)
                }); 
            }

            return products;

        }
    }
}
