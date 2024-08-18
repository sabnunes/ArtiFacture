using System.Collections.Generic;

namespace ARTIFACTURE
{
    class Constants
    {
        // public const List<int> Bills = [1,2,3,4];
        public const string EnterSelection = "Enter your selection: ";
        public const string EnterBill = "Enter a valid dollar bill: ";
        public const string CurrentBalance = "\nYour balance is: ${0} \n";
        public const string InvalidBill = "\nInvalid bill. Enter one of the following: " +
                                          "1, 2, 5, 10, 20, 50, 100, 500, 1000\n"; // use Bills?
        
        public const string EnterSlotNum = "Select the item # for the art asset you would like to purchase: ";
        
        public const string CollectChange = "\nPlease collect your change ${0} from the cash dispenser.\n";
        public const string NoChange = "\nSorry, you don't have any change!\n";
        public const string ChangeForgotten = "OOPS! You forgot to collect your change";

        public const string ThankYou = "Thank you for using ARTIFACTURE!\n";

        public const string InvalidSelection = "Please make a valid selection from the list of options. (1, 2, 3, 4)\n";
        public const string Success = "Success!";
        public const string PurchaseSuccessful = "One {0} magically falls onto your lap.\n";
        public const string InsufficientFunds = "\nInsufficient funds to buy: {0}\n";
        public const string EmptySelection = "\nA real-life unicorn has visited you from space!\n";
        public const string InvalidItemNum = "\nYou've entered an invalid item number.\n";
        public const string Processing = "Processing your request...";

    }
}
