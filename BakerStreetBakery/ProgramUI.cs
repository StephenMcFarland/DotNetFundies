using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerStreetBakery
{
    class ProgramUI
    {
        private ProductRepository _productRepo;
        private List<Product> _products;

        //This is a constructor for the ProgramUI, inside of the constructor are items I want created when an instance of ProgramUI is initialized.
        public ProgramUI()
        {
            _productRepo = new ProductRepository();
            _products = _productRepo.GetOrderedProducts();
        }

        internal void Run()
        {
            StartDialogue();
        }

        private void Menu()
        {
            
        }

        private void StartDialogue()
        {
            Console.WriteLine("Hello and welcome to Baker Street Bakery...Would you like to enter a order? True or False");
            string answer = Console.ReadLine().ToLower();
            bool yes = bool.Parse(answer);
            if(yes == true)
            {
                Menu();
            }
            else
            {
                Console.WriteLine("Thanks for your interest. The program is going to close now.");
                Console.ReadKey();
            }
        }

        private void CreateProductOrder()
        {
            Console.WriteLine("Please enter the name of the product you would like to order.");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter the number for what type of bake product:\n" +
                "1. Bread\n" +
                "2. Cake\n" +
                "3. Pastery\n" +
                "4. Pie");
            int bakeType = ParseInput();

            BakeType type;
            switch (bakeType)
            {
                default:
                case 1:
                     type = BakeType.Bread;
                    break;
                case 2:
                    type = BakeType.Cake;
                    break;
                case 3:
                    type = BakeType.Pastery;
                    break;
                case 4:
                    type = BakeType.Pie;
                    break;
            }

            Console.WriteLine($"How many would you like to order");
            int orderAmount = ParseInput();

            Console.WriteLine("Enter the customer name for the order.");
            string customerName = Console.ReadLine();

            decimal orderCost = _productRepo.CalculateCost(type);
            Product order = new Product(productName, type, orderAmount, customerName, orderCost);

            _productRepo.AddProductOrderToList(order);
            Console.WriteLine($"\"{order.ProductName}\" added to list. Customer total is: {orderCost}");
            Console.ReadKey();
        }

        private void PrintAllProducts()
        {
            foreach(Product product in _products)
            {
                Console.WriteLine($"{product.ProductName} {product.BakeType} {product.OrderBatchSize} {product.CustomerName} {product.OrderCost}");
            }
        }

        private int ParseInput()
        {
            int input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}
