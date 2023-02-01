using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CHomeTask11
{
    internal class Store
    {
        Product[] Products = new Product[0];
        public void AddProduct(Product pr)
        {
            if (!HasProductByNo(pr.No))
            {
                Array.Resize(ref Products, Products.Length + 1);
                Products[Products.Length - 1] = pr;
            }
            else
            {
                throw new Exception();
            }
        }
        public bool HasProductByNo(string no)
        {
            foreach(Product pr in Products)
            {
                if (pr.No == no)
                    return true;
            }
            return false;
        }
    }
}
