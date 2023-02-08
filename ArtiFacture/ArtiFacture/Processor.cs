using System;
using System.Threading;


namespace ARTIFACTURE
{
    class Processor 
    {
        private Item[,] _item; // Shelve to store products
        private Display _display; // Display to display messages
        private Transactor _transactor; // Transactor to handle the transactions
        private KeyPad _keyPad; // Keypad to read the used inputs
        private int userAmount; // Field to keep track of the user's money

        // Parameterized constructor
        public Processor(Item[,] items)
        {
            this._item = items;
            this._display = new Display();
            this._transactor = new Transactor();
            this._keyPad = new KeyPad();
            this.userAmount = 0;
        }
        // The method to start the vending machine
        public void Activate()
        {
            // Display welcome message
            _display.WelcomeMessage();

            // Variable to store input
            int input = 0;
            
            while (true)
            {

                Thread.Sleep(1000);
                _display.DisplayMethod();
                _display.DisplayMethod(Constants.EnterSelection);
                input = _keyPad.readKey();

                // user actions
                switch (input)
                {
                    // Feed money
                    case 1:
                        int bill;
                        _display.DisplayMethod(Constants.EnterBill);
                        bill = _keyPad.readKey();
                        if (_transactor.AddAmount(bill))
                        {
                            userAmount += bill;
                            _display.DisplayMethod(Constants.CurrentBalance, userAmount);
                        }
                        else
                        {
                            Console.WriteLine(Constants.InvalidBill);
                            _display.DisplayMethod(Constants.CurrentBalance, userAmount);
                        }
                        break;

                    // Select product
                    case 2:

                        int slot;
                        _display.DisplayMethod(this._item);
                        _display.DisplayMethod(Constants.CurrentBalance, userAmount);
                        _display.DisplayMethod(Constants.EnterSlotNum);
                        slot = _keyPad.readKey();
                        BuyProduct(slot);
                        break;
                    // Get change
                    case 3:

                        if (_transactor.GetChange(userAmount))
                        {
                            _display.DisplayMethod(Constants.CollectChange, userAmount);
                            userAmount = 0;
                        }
                        else
                        {
                            _display.DisplayMethod(Constants.NoChange);
                        }
                        break;
                    //  Quit
                    case 4:
                        if (userAmount == 0)
                        {
                            _display.DisplayMethod(Constants.ThankYou);
                            Console.Clear();
                            _display.WelcomeMessage();
                        }
                        else
                        {
                            _display.DisplayMethod(Constants.ChangeForgotten);
                            _display.DisplayMethod(Constants.CollectChange, userAmount);
                            _display.DisplayMethod(Constants.ThankYou);
                            userAmount = 0;
                            Console.Clear();
                            _display.WelcomeMessage();
                        }
                       
                        break;

                    default:
                        Console.Clear();
                        _display.DisplayMethod(Constants.InvalidSelection);
                        break;
                }


            }
        }

        private void BuyProduct(int slot)
        {

            int column = (slot % 10) - 1;
            int row = (slot / 10) - 1;
            if ((row >= 0 && row <= 2) && (column >= 0 && column <= 3))
            {
                if (_item[row, column] != null)
                {
                    if (_item[row, column].Price <= userAmount)
                    {
                        Console.Clear();
                        Thread.Sleep(1000);
                        _display.DisplayMethod(Constants.Processing);
                        Thread.Sleep(2000);
                        _display.DisplayMethod(Constants.Success);
                        Thread.Sleep(1000);
                        _display.DisplayMethod(Constants.PurchaseSuccessful, _item[row, column].ItemName);
                        userAmount -= this._item[row, column].Price;
                        _item[row, column] = null;

                    }
                    else
                    {
                        _display.DisplayMethod(Constants.InsufficientFunds, _item[row, column].ItemName);
                        Thread.Sleep(1000);
                    }
                }
                else
                {
                    _display.DisplayMethod(Constants.EmptySelection);
                    Thread.Sleep(1000);
                }
            }
            else
            {
                _display.DisplayMethod(Constants.InvalidItemNum);
                Thread.Sleep(1000);
            }
        }


    }
}