namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Quyidagi 3 xil turdagi massivning ning oxirgi elementini qaytaradigan Generic funksiya yarating.

            //list1 = [12, 23, 34];
            //list2 = [12.12, 23.23, 34.34];
            //list3 = ["PDP", "Online", "2020"];
            List<int> list = new List<int>() { 12, 23, 34 };
            List<decimal> list2 = new List<decimal>() { 12.12m, 23.23m, 34.34m };
            List<string> list3 = new List<string>() { "PDP", "Online", "2023" };

            Console.WriteLine(GetMeList.LastElement(list));
            Console.WriteLine();
            Console.WriteLine(GetMeList.LastElement(list2));
            Console.WriteLine();
            Console.WriteLine(GetMeList.LastElement(list3));
        }
    }
    class GetMeList
    {
        public static T LastElement<T>(List<T> list)
        {
            if (list.Count > 0)
            {
                return list[list.Count - 1];
            }
            else
            {
                throw new InvalidOperationException("bush list");
            }
        }
    }


}