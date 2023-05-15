using repository_pattern_api.Repository;

namespace repository_pattern_api.Model.Oracle
{
    public class OracleProducts : IProduct
    {
        static List<Products> pList = new List<Products>()
        {
            new Products(){ pId=101, pName="Oracle 1", pCategory="Oracle", pIsInStock=true, pPrice=20 },
            new Products(){ pId=102, pName="Oracle 2", pCategory="Oracle", pIsInStock=true, pPrice=20 },
            new Products(){ pId=103, pName="Oracle 3", pCategory="Oracle", pIsInStock=false, pPrice=20 },
            new Products(){ pId=104, pName="Oracle 4", pCategory="Oracle", pIsInStock=true, pPrice=20 },
            new Products(){ pId=105, pName="Oracle 5", pCategory="Oracle", pIsInStock=false, pPrice=20 },
            new Products(){ pId=106, pName="Oracle 6", pCategory="Oracle", pIsInStock=true, pPrice=20 },
        };


        public string AddProduct(Products newProduct)
        {
            pList.Add(newProduct);
            return "Product Added to Oracle";
        }

        public string DeleteProduct(int productId)
        {
            //write the delete code
            return "Product deleted from Oracle";
        }

        public string EditProduct(Products changes)
        {
            //write edit code
            return "Product Edited from Oracle";
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
