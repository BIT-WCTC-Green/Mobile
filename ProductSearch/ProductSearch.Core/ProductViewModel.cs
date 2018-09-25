using System;
using System.Threading.Tasks;

namespace ProductSearch.Core
{
    public class ProductViewModel
    {
        private readonly ProductRepository repository = new ProductRepository();

        public string SearchTerm { get; set; }

        public Product[] Products { get; private set; }

        public async Task Search()
        {
            if (string.IsNullOrEmpty(SearchTerm))
                Products = null;
            else
                Products = await repository.SearchProducts(SearchTerm);
        }
    }
}

