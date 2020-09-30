using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//@TODO a finir

namespace CSharAc
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            //-------------------------------Utils-----------------------------------------\\
            string dotMinecraftDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft";
            string dotMinecraftLogs = dotMinecraftDir + "\\logs";
            
            //Message d'open
            void msgStart()
            {
                Console.WriteLine("\n");
                Console.WriteLine(@"  $$$$$$\  $$$$$$\ $$\                                  $$$$$$\  $$$$$$|      ");
                Console.WriteLine(@"  $$  __$$\$$  __$$\$$ |                                $$  __$$\$$  __$$\    ");
                Console.WriteLine(@"  $$ /  \__$$ /  \__$$$$$$$\  $$$$$$\  $$$$$$\  $$$$$$\ $$ /  $$ $$ /  \__|   ");
                Console.WriteLine(@"  $$ |     \$$$$$$\ $$  __$$\ \____$$\$$  __$$\$$  __$$\$$$$$$$$ $$ |         ");
                Console.WriteLine(@"  $$ |      \____$$\$$ |  $$ |$$$$$$$ $$ |  \__$$ /  $$ $$  __$$ $$ |         ");
                Console.WriteLine(@"  $$ |  $$\$$\   $$ $$ |  $$ $$  __$$ $$ |     $$ |  $$ $$ |  $$ $$ |  $$\    ");
                Console.WriteLine(@"  \$$$$$$  \$$$$$$  $$ |  $$ \$$$$$$$ $$ |     $$$$$$$  $$ |  $$ \$$$$$$  |   ");
                Console.WriteLine(@"   \______/ \______/\__|  \__|\_______\__|     $$  ____/\__|  \__|\______/    ");
                Console.WriteLine(@"                                               $$ |                           ");
                Console.WriteLine(@"                                              $$ |                           ");
                Console.WriteLine(@"                                              \__|                           ");
            }

            //log Reader
            void logsReader()
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(dotMinecraftLogs+ "\\latest.log");

                foreach (string line in lines)
                {
                    List<string> lst = new List<string>();
                    /**lst.Add("wurst");
                    lst.Add("metro");
                    lst.Add("Liquid Bounce");
                    lst.Add("nodus");
                    lst.Add("injected");
                    lst.Add("reach");
                    lst.Add("kill aura");
                    lst.Add("anti kb");
                    lst.Add("Velocity");
                    lst.Add("missing");
                    lst.Add("missing mod");
                    lst.Add("missing");**/
                    lst.Add("_Tr1_gran_vitece");
                    if (line.Contains("_Tr1_gran_vitece"))
                    {
                        Console.WriteLine(line);    
                    }
                    /**else
                    {
                        Console.WriteLine("Nothing founded in Latest file");
                        menu();
                    }**/
                    
                }
                menu();
            }


            
            //Mesage menu
            void messageAll()
            {
                Console.WriteLine("Log Analyzer 1 |\n");
            }

            //menu Choice Fonctionne
            void menu()
            {
                string val;
                Console.Write("Enter integer: ");
                val = Console.ReadLine();
                if (val.Equals("1"))
                {
                    logsReader();
                }
            }


            Main();
            void Main()
             {
                 msgStart();
                 logsReader();
                // Console.Write(dotMinecraftDir);

             }
        }
    }
}