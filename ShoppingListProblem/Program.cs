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
                NewShoppingList(TextFile);
            }
        }

        static void NewShoppingList(TextWriter SelectedFile)
        {
            string _UserInput = "";
            bool _CanContinue = false;
            string[ , ] _NewItem = new string[ , ] { };

            // Ask if they want to add a new item, delete an item or output the file.

            while (_CanContinue)
            {
                Console.WriteLine("1 > Add item to list. \n" +
                              "2 > Remove item from list. \n" +
                              "3 > Output list to console.\n");

                _UserInput = Console.ReadLine();

                switch (_UserInput)
                {
                    case "1":
                        // Adds an item to the list and the quantity.

                        break;

                    case "2":
                        // Removes the entire item.

                        break;

                    case "3":
                        // Output the whole file.

                        break;

                    default:
                        _CanContinue = false;
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
