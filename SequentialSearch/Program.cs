using System;

namespace SequentialSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Jeff", "Jackson", "Danish", "Rachel", "Brendan", "Trevin", "Sarah", "Kevin", "Lilly" };
            double[] grades = { 100, 95, 81, 91, 88, 90, 93, 90, 90.5};
            int indexFound;
            int count = names.Length;

            string nameSearch = GetNameToSearch();

            while (nameSearch.ToLower() != "stop")
            {
                indexFound = SequentialSearchName1(names, nameSearch, count);
                //indexFound = SequentialSearchName2(names, nameSearch, count);

                if (indexFound == -1)
                {
                    Console.WriteLine(nameSearch + " was not found...\n");
                }
                else
                {
                    Console.WriteLine(nameSearch + "'s grade: " + grades[indexFound] + "\n");
                }

                nameSearch = GetNameToSearch();
            }

            Console.WriteLine("\nBefore swapping, students at index 1 and 4: ");
            Console.WriteLine(names[1] + ": " + grades[1]);
            Console.WriteLine(names[4] + ": " + grades[4]);

            Swap(names, 1, 4);

            Console.WriteLine("\nAfter swapping names, students at index 1 and 4: ");
            Console.WriteLine(names[1] + ": " + grades[1]);
            Console.WriteLine(names[4] + ": " + grades[4]);

            Swap(grades, 1, 4);

            Console.WriteLine("\nAfter swapping grades, students at index 1 and 4: ");
            Console.WriteLine(names[1] + ": " + grades[1]);
            Console.WriteLine(names[4] + ": " + grades[4]);

            Console.ReadKey();

        }


        static string GetNameToSearch()
        {
            Console.Write("Enter a name to seach (stop to exit): ");
            string name = Console.ReadLine();
            return name;
        }


        static int SequentialSearchName1(string[] names, string nameSearch, int count)
        {
            int indexFound = -1;

            for (int i = 0; i < count; i++)
            {
                if (names[i] == nameSearch)
                {
                    indexFound = i;
                }
            }

            return indexFound;
        }


        static int SequentialSearchName2(string[] names, string nameSearch, int count)
        {
            int indexFound = -1;
            bool notFound = true;

            int i = 0;

            while(notFound && i < count)
            {
                if(names[i] == nameSearch)
                {
                    indexFound = i;
                    notFound = false;
                }
                i++;
            }

            return indexFound;
        }


        static void Swap(string[] names, int index1, int index2)
        {
            string temp = names[index1];
            names[index1] = names[index2];
            names[index2] = temp;
        }


        static void Swap(double[] grades, int index1, int index2)
        {
            double temp = grades[index1];
            grades[index1] = grades[index2];
            grades[index2] = temp;
        }
    }
}
