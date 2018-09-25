using System;
using System.Linq;
using System.Threading.Tasks;

namespace ProductSearch.Core
{
    // An example class, in the real world would talk to a web 
    // server or database
    public class ProductRepository 
    {
        // a sample list of products to simulate a database
        private Product[] products = new[]
        {
            new Product { Id = 1, Name = "Shoes", Price = 19.99m },
            new Product { Id = 2, Name = "Shirt", Price = 15.99m },
            new Product { Id = 3, Name = "Hat", Price = 9.99m },
        };

        public async Task<Product[]> SearchProducts(string searchTerm)
        {
            // Wait 2 seconds to simulate web request
            await Task.Delay(2000); 

            // Use Linq-to-objects to search, ignoring case
            searchTerm = searchTerm.ToLower();
            return products
                .Where(p => p.Name.ToLower().Contains(searchTerm))
                .ToArray();
        }
    }

}

