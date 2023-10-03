using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileManagerComposite
{
    internal class Program
    {
        public static List<Node> folders = new List<Node>();
        public static List<Node> files = new List<Node>();

        public static void PrintMenu()
        {
            Console.Clear();

            Console.WriteLine("0 - Exit\n");
            Console.WriteLine("1 - Add Folder");
            Console.WriteLine("2 - Add File");
            Console.WriteLine("3 - Show file");
            Console.Write("4 - Open folder\n\nChoose -> ");
        }

        #region HelperFunc

        public static void WrongInput()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t!!! Wrong input !!!");

            Thread.Sleep(2000);
        }
        public static void ShowContentOfFolder(Folder folder)
        {
            Console.WriteLine($"Name of opened folder -> {folder.Name}");
            folder.ShowAllContent();
        }

        #endregion

        #region Choices

        public static void AddFolder()
        {
            Console.Clear();
            Console.Write("1 - Add in Disk C | 2 - Add in folder: "); int choice = int.Parse(Console.ReadLine());

            if (choice == 2)
            {
                bool ifExist = false; int i = 0;

                Console.Write("Enter name of folder where you want to add folder: "); string folder_name = Console.ReadLine();
                foreach (Folder folder in folders)
                {
                    if (folder_name == folder.Name)
                    {
                        ifExist = true;
                        i++;
                        break;
                    }
                    i++;
                }

                if (ifExist == true)
                {
                    Console.Clear();

                    Console.Write("Enter name of new folder: "); string name = Console.ReadLine();

                    if (name != null)
                    {
                        Node folder = new Folder(name);
                        folders[i].Add(folder);
                        folders.Add(folder);

                        Console.WriteLine("\n\nAdding...");
                        Thread.Sleep(1500);
                    }
                    else
                        WrongInput();
                }
                else
                {
                    Console.WriteLine("\n\n\nSuch folder is not exist");

                    Thread.Sleep(2000);
                }
            }
            else if (choice == 1)
            {
                Console.Clear();

                Console.Write("Enter name of new folder: "); string name = Console.ReadLine();

                if (name != null)
                {
                    Node folder = new Folder(name);
                    folders.Add(folder);

                    Console.WriteLine("\n\nAdding...");
                    Thread.Sleep(1500);
                }
                else
                    WrongInput();
            }
            else
                WrongInput();
        }
        public static void AddFile()
        {
            Console.Clear();

            bool ifExist = false; int i = 0;

            Console.Write("Enter name of folder where you want to add file: "); string folder_name = Console.ReadLine();
            
            foreach (Folder folder in folders)
            {
                if (folder_name == folder.Name)
                {
                    ifExist = true;
                    break;
                }
                i++;
            }

            if (ifExist == true)
            {
                Console.Clear();

                Console.Write("Enter name of new file: "); string name = Console.ReadLine();
                Console.Write("Enter type of new file(mp3, png and e.t.c): "); string type = Console.ReadLine();
                Console.Write("Enter size of new file(mb): "); int size = int.Parse(Console.ReadLine());

                if (size > 0)
                {
                    Node file = new File(name, type, size);

                    folders[i].Add(file);
                    files.Add(file);

                    Console.WriteLine("\n\nAdding...");
                    Thread.Sleep(1500);
                }
                else
                    WrongInput();
            }
            else
            {
                Console.WriteLine("\n\n\nSuch folder is not exist");

                Thread.Sleep(2000);
            }
        }

        public static void OpenFile()
        {
            Console.Clear();
            Console.Write("Enter name of searching file: "); string searching_file = Console.ReadLine();

            foreach (File file in files)
            {
                if (file.Name == searching_file)
                {
                    file.ShowFile();
                    break;
                }
            }

            Console.WriteLine("\n\nPress any key...");
            Console.ReadKey();
        }
        public static void OpenFolder()
        {
            Console.Clear();
            Console.Write("Enter name of searching folder: "); string searching_folder = Console.ReadLine();

            Folder tmp_folder = null;
            foreach (Folder folder in folders)
            {
                if (folder.Name == searching_folder)
                {
                    tmp_folder = folder;
                    break;
                }
            }

            if (tmp_folder != null)
            {
                ShowContentOfFolder(tmp_folder);

                Console.WriteLine("\n\nPress any key...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\n\nSuch file is not exist");
                Thread.Sleep(2000);
            }
        }

        #endregion

        static void Main(string[] args)
        {
            bool flag = true;

            while (flag)
            {
                PrintMenu(); int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.Clear();

                        Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\tGoodbye:)\n\n\n\n\n\n\n");
                        flag = false;

                        break;
                    case 1:
                        AddFolder();

                        break;
                    case 2:
                        AddFile();

                        break;
                    case 3:
                        OpenFile();

                        break;
                    case 4:
                        OpenFolder();

                        break;
                    default:
                        WrongInput();

                        break;
                }
            }
        }
    }
}
