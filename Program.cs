using System;
 namespace Lists
{
    class List
    {

        static void Main(string[] args)
        {

            List<string> list = new List<string>(); // creating the instance for the our list

            list.Add("1 - Bülent Ersoy");
            list.Add("2 - Ajda Pekkan");
            list.Add("3 - Ebru Gündeş");
            list.Add("4 - Hadise");
            list.Add("5 - Hande Yener");
            list.Add("6 - Tarkan");
            list.Add("7 - Funda Arar");
            list.Add("8 - Demet Akalın");
            Console.WriteLine("** Davetliler **"); // Static string for the our program
            foreach (var item in list)
            {
               
                Console.WriteLine(item); // Write to the console each item
            }

        }
    }


}