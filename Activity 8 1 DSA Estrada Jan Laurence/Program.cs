using System.Collections;
using System.Collections.Generic;


namespace DSA_Activity_81_Estrada_JanLaurence
{
    class Program
    {

        public static void Main(string[] args)
        {
            /*
             * 
             */
            try
            {
                var recht = new Hashtable();
                var data = new Stack<int>();
                string choice = "0";
                while (choice != "4")
                {
                    Console.WriteLine("[1] Add Data");
                    Console.WriteLine("[2] Delete Data");
                    Console.WriteLine("[3] Display Data");
                    Console.WriteLine("[4] End");


                    choice = (Console.ReadLine());
                    Console.WriteLine();
                    switch (choice)
                    {
                        case "1":

                            Console.WriteLine("Enter Key:");
                            string key = (Console.ReadLine());
                            if (recht.ContainsKey(key) == false)
                            {
                                Console.WriteLine("Enter Value:");
                                int val = (Convert.ToInt32(Console.ReadLine()));
                                recht.Add(key, val);
                            }
                            else { Console.WriteLine("key duplicate"); }

                            break;


                        case "2":
                            Console.WriteLine("Enter Key:");
                            key = (Console.ReadLine());

                            if (recht.ContainsKey(key) == true)
                            {
                                recht.Remove(key);
                            }
                            else { Console.WriteLine("key not found"); }

                            break;

                        case "3":

                            Console.WriteLine("\t-Key-\t-Value-");
                            foreach (DictionaryEntry i in recht)
                            {
                                Console.WriteLine($"\t{i.Key}\t{i.Value}");
                            }

                            break;
                        case "4":

                            break;

                    }
                }

            }


            catch (Exception e)
            {
                Console.WriteLine("Error Encountered " + e.ToString());
            }
            finally
            {
                Console.ReadKey();
            }


        }

    }

}