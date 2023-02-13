using System;
namespace ARTIFACTURE
{
    class ItemRig : Item
    {
        public ItemRig(string name, int price)
            : base(name, price, "Rig")
        {

        }

        public override string DisplayMessage()
        {
            return "Name: " + base.ItemName + " Price: " + base.Price + "$" + " Type: " + base.Type;
        }

    }
}