using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerStreetBakery
{
    public class ProductRepository
    {
        List<Product> _products = new List<Product>();

        public void AddProductOrderToList(Product product)
        {
            _products.Add(product);
        }

        public List<Product> GetOrderedProducts()
        {
            return _products;
        }

        public void RemoveOrderedProduct(Product product)
        {
            _products.Remove(product);
        }

        public decimal CalculateCost(BakeType type)
        {
            decimal totalCost = 100m;
            switch (type)
            {
                case BakeType.Bread:
                    totalCost += 500.01m;
                    break;
                case BakeType.Cake:
                    totalCost += 2000m;
                    break;
                case BakeType.Pastery:
                    totalCost += 200.10m;
                    break;
                case BakeType.Pie:
                    totalCost += 851.50m;
                    break;
            }
            return totalCost;
        }
    }
}
