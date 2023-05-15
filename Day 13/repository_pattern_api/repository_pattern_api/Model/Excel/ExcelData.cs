using repository_pattern_api.Repository;

namespace repository_pattern_api.Model.Excel
{
    public class ExcelData : IProduct
    {
        static List<Products> pList = new List<Products>()
        {
            new Products(){ pId=101, pName="Excel 1", pCategory="Excel", pIsInStock=true, pPrice=20 },
            new Products(){ pId=102, pName="Excel 2", pCategory="Excel", pIsInStock=true, pPrice=20 },
            new Products(){ pId=103, pName="Excel 3", pCategory="Excel", pIsInStock=false, pPrice=20 },
            new Products(){ pId=104, pName="Excel 4", pCategory="Excel", pIsInStock=true, pPrice=20 },
            new Products(){ pId=105, pName="Excel 5", pCategory="Excel", pIsInStock=false, pPrice=20 },
            new Products(){ pId=106, pName="Excel 6", pCategory="Excel", pIsInStock=true, pPrice=20 },
        };


        public string AddProduct(Products newProduct)
        {
            pList.Add(newProduct);
            return "Product Added to Excel";
        }

        public string DeleteProduct(int productId)
        {
            //write the delete code
            return "Product deleted from Excel";
        }

        public string EditProduct(Products changes)
        {
            //write edit code
            return "Product Edited from Excel";
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
