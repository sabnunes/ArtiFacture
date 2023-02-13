using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTIFACTURE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 x 4 array of Items
            Item[,] products = new Item[3, 4];

            products[0, 0] = new ItemModel("Rock", 21);
            products[0, 1] = new ItemModel("Desktop", 52);
            products[0, 2] = new ItemModel("Dragon", 38);
            products[0, 3] = new ItemModel("Flower", 18);

            products[1, 0] = new ItemRig("Puppy", 18);
            products[1, 1] = new ItemRig("Snake", 39);
            products[1, 2] = new ItemRig("Human", 13);
            products[1, 3] = new ItemRig("Scarf", 11);

            products[2, 0] = new ItemFX("Smoke", 11);
            products[2, 1] = new ItemFX("Water", 18);
            products[2, 2] = new ItemFX("Fire", 14);
            products[2, 3] = new ItemFX("Sparkle", 40);


            // Passing the products array to the vending machine
            // Aggregation relationship
            Processor artifacture = new Processor(products);
            // Turning on the vending machine
            artifacture.Activate();
        }
    }
}
