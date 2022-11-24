using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Console.WriteLine("Please input existing file name and path OR a new file name...\n");
            _FileName = Console.ReadLine();

            // Format the text.
            if (!_FileName.EndsWith(".txt"))
            {
                _FileName += ".txt";
            }

            // Check if file exists.
            if (File.Exists(_FileName + ".txt"))
            {
                // loads the file to be read.
                StreamReader TextFileExisting = File.OpenText(_FileName);
                CurrentShoppingList(TextFileExisting);
            }
            else
            {
                // Creates the text file.
                TextWriter TextFile = new StreamWriter(_FileName);
                NewShoppingList(TextFile, _FileName);
            }
        }

        static void NewShoppingList(TextWriter SelectedFile, string FileName)
        {
            string _UserInput = "";
            bool _CanContinue = true;

            // Ask if they want to add a new item, delete an item or output the file.

            while (_CanContinue)
            {
                Console.WriteLine("1 > Add item to list. \n" +
                              "2 > Remove item from list. \n" +
                              "3 > Output list to console.\n" +
                              "4 > Closes the file.\n");

                _UserInput = Console.ReadLine();

                switch (_UserInput)
                {
                    case "1":
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
                                SelectedFile.WriteLine(_NewItemName + _NewItemQuantity);
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
                        break;

                    case "2":
                        // Removes the entire item.

                        break;

                    case "3":
                        // Output the whole file.

                        break;

                    case "4":
                        // Closes the file.
                        SelectedFile.Close();
                        _CanContinue = false;
                        break;

                    default:
                        _CanContinue = true;
                        break;
                }
            }
        }

        static void CurrentShoppingList(StreamReader SelectedFile)
        {

        }

        // Main Program
        static void Main(string[] args)
        {
            FileSelector();
        }
    }
}
