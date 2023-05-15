using repository_pattern_api.Repository;

namespace repository_pattern_api.Model.Collections
{
    public class ProductsCollection : IProduct
    {
        static List<Products> pList = new List<Products>()
        {
            new Products(){ pId=101, pName="Collection 1", pCategory="Collection", pIsInStock=true, pPrice=20 },
            new Products(){ pId=102, pName="Collection 2", pCategory="Collection", pIsInStock=true, pPrice=20 },
            new Products(){ pId=103, pName="Collection 3", pCategory="Collection", pIsInStock=false, pPrice=20 },
            new Products(){ pId=104, pName="Collection 4", pCategory="Collection", pIsInStock=true, pPrice=20 },
            new Products(){ pId=105, pName="Collection 5", pCategory="Collection", pIsInStock=false, pPrice=20 },
            new Products(){ pId=106, pName="Collection 6", pCategory="Collection", pIsInStock=true, pPrice=20 },
        };


        public string AddProduct(Products newProduct)
        {
            pList.Add(newProduct);
            return "Product Added to collection";
        }

        public string DeleteProduct(int productId)
        {
            //write the delete code
            return "Product deleted from Collection";
        }

        public string EditProduct(Products changes)
        {
            //write edit code
            return "Product Edited from collection";
        }

        public Products GetProductById(int id)
        {
            return pList.Find(p => p.pId == id);
        }

        public List<Products> GetProducts()
        {
            return pList;
        }
    }
}
