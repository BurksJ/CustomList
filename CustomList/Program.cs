using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int test = 4;

            //Act
            list.Add(2);
            list.Add(3);
            list.Add(5);
            list.Add(4);

            //Assert
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
            Console.ReadKey();
        }
    }
}
