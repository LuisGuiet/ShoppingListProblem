using System;
using System.IO;

namespace ShoppingListProblem
{
    internal class Program
    {
        // Subroutines
        static void FileSelector()
        {
            // Request the file name/path.
            string _FileName = "";

            Console.WriteLine("Please input existing file name...\n");
            _FileName = Console.ReadLine();

            // Format the text.
            if (!_FileName.EndsWith(".txt"))
            {
                _FileName += ".txt";
            }

            ShoppingList(_FileName);
        }

        static void ShoppingList(string FileName)
        {
            string _DefaultPathFile = "./Shopping list/" + FileName;
            TextWriter _FileWrite = new StreamWriter(_DefaultPathFile, true);

            string _UserInput = "";
            bool _CanContinue = true;

            // Ask if they want to add a new item, delete an item or output the file.
            while (_CanContinue)
            {
                // Selector.
                Console.WriteLine("1 > Add item to list. \n" +
                              "2 > Remove item from list. \n" +
                              "3 > Output list to console.\n" +
                              "4 > Closes the file.\n");

                _UserInput = Console.ReadLine();

                switch (_UserInput)
                {
                    case "1":
                        // Adds an item to the list and the quantity.
                        AddToList(_FileWrite);
                        break;

                    case "2":
                        // Removes the entire item.
                        //RemoveFromList();
                        break;

                    case "3":
                        // Output the whole file.
                        //ReadFromFile();
                        break;

                    case "4":
                        // Closes the file.
                        _CanContinue = false;
                        break;

                    default:
                        _CanContinue = true;
                        break;
                }
            }
            _FileWrite.Close();
        }

        static void AddToList(TextWriter _TextWriter)
        {
            int _Count = 0;

            // Adds an item to the list and the quantity.
            string _NewItemName = "";
            string _NewItemQuantity = "";

            // Request the name and quantity.
            Console.WriteLine("Please type the item name...\n");
            _NewItemName = Console.ReadLine();

            Console.WriteLine("Please type the item quantity...\n");
            _NewItemQuantity = Console.ReadLine();

            // Check that the string is not an int.
            if (!Int32.TryParse(_NewItemName, out int push))
            {
                // Check that the int is not char.
                if (Int32.TryParse(_NewItemQuantity, out int push2))
                {
                    _TextWriter.WriteLineAsync(String.Format("index no.{0} name {1} quantity {2}", _Count, _NewItemName, _NewItemQuantity));
                    _Count++;
                }
                else
                {
                    Console.WriteLine("Item quantity cannot consist of characters.\n");
                }
            }
            else
            {
                Console.WriteLine("Item name cannot consist of only integers.\n");
            }
        }

        static void RemoveFromList(TextReader _TextReader)
        {
            // Ask for the index of the item.
            string _IndexInput = "";

            Console.WriteLine("Please input index of item you wish to delete...\n");
            _IndexInput = Console.ReadLine();

            if (int.TryParse(_IndexInput, out int index))
            {
                

            }
        }

        static void ReadFromFile(TextReader _TextReader)
        {

        }

        // Main Program
        static void Main(string[] args)
        {
            FileSelector();
        }
    }
}
