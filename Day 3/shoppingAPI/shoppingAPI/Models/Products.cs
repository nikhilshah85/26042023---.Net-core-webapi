using Microsoft.AspNetCore.Server.HttpSys;

namespace shoppingAPI.Models
{
    public class Products
    {
        #region Properties
        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public int pPrice { get; set; }
        public bool pIsInStock { get; set; }
        #endregion

        #region Data Store

        private static List<Products> pList = new List<Products>()
        {
            new Products(){ pId=101, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50 },
            new Products(){ pId=102, pName="Appy", pCategory="Cold-Drink", pIsInStock=false, pPrice=90 },
            new Products(){ pId=103, pName="IPhone", pCategory="Electronics", pIsInStock=true, pPrice=100 },
            new Products(){ pId=104, pName="FossilQ", pCategory="Watch", pIsInStock=true, pPrice=200 },
            new Products(){ pId=105, pName="Dell Lattitude", pCategory="Electronics", pIsInStock=true, pPrice=500 },
            new Products(){ pId=106, pName="Apple Watch", pCategory="Watch", pIsInStock=false, pPrice=1500 },
        };
        #endregion

        #region Get Methods
        public List<Products> GetAllProducts()
        {
            return pList;
        }

        public Products GetproductById(int id)
        {
            var checkproduct = pList.Count(p => p.pId == id);

            if (checkproduct == 1)
            {
                var prod = (from p in pList
                            where p.pId == id
                            select p).Single();
                return prod;
            }
            throw new Exception("Sorry product not found");
        }
        public List<Products> GetProductsByCategory(string category)
        {
            var prod = (from p in pList
                        where p.pCategory == category
                        select p).ToList();

            return prod;
        }

        #endregion

        public string AddNewProduct(Products newP)
        {
            if (newP.pPrice < 0)
            {
                throw new Exception("Please enter a valid price for your product");
            }
            else if (newP.pName.Length < 3)
            {
                throw new Exception("Please enter product name more than 3 characters");
            }
            //do other validations
            pList.Add(newP);
            return "Product Added Successfully";
        }

        public string EditProduct(Products productToEdit)
        {
            var count = pList.Count(p => p.pId == productToEdit.pId);

            if (count > 0)
            {
                var p = (from pr in pList
                         where pr.pId == productToEdit.pId
                         select pr).Single();

                p.pName = productToEdit.pName;
                p.pCategory = productToEdit.pCategory;
                p.pPrice = productToEdit.pPrice;
                p.pIsInStock = productToEdit.pIsInStock;
                return "Product Edited Succsfully";
            }
            throw new Exception("Product Not Found");
        }

        public string DeleteProduct(int id)
        {
            var count = pList.Count(p => p.pId == id);
            if (count > 0)
            {
                var p = (from pr in pList
                         where pr.pId == id
                         select pr).Single();

                pList.Remove(p);
                return "Product Deleted Successfully";
            }
            throw new Exception("Product not found");
        }
    }

}

















