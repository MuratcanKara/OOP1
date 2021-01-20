using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{   // class isimleri pascal case 
    class ProductManager
    {
        //encapsulation
        
        public void Add(Product product)
        {
            Console.WriteLine("Sisteme eklendi! " + product.ProductName);
        }
    
        public void Update(Product product)
        {
            Console.WriteLine("Güncellendi! " + product.Id);
        }
    
        

    }
}
