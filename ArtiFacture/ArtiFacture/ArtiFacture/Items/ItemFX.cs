using System;
namespace ARTIFACTURE
{
    class ItemFX : Item
    {
        public ItemFX(string name, int price)
            : base(name, price, "FX")
        {

        }

        public override string DisplayMessage()
        {
            return "Name: " + base.ItemName + " Price: " + base.Price + "$" + " Type: " + base.Type;
        }
    }
}