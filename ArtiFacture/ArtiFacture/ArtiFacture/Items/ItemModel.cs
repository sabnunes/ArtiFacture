using System;
namespace ARTIFACTURE
{
    class ItemModel : Item
    {
        public ItemModel(string name, int price)
            : base(name, price, "Model")
        {

        }

        public override string DisplayMessage()
        {
            return "Name: " + base.ItemName + " Price: " + base.Price + "$" + " Type: " + base.Type;
        }
    }
}