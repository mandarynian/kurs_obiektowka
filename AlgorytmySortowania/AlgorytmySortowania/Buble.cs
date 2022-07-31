using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmySortowania
{
    public class Buble
    {
        int[] intArray;

        public Buble(int numberOfElementToSort = 5)
        {
            intArray = new int[numberOfElementToSort];
            GenerateArrayValues();
            Sort();
        }

        private void GenerateArrayValues()
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = new Random().Next(10);
            }
        }

        public void Sort()
        {
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                int a1 = intArray[i];
                int a2 = intArray[i + 1];   

                if (a1 > a2)
                {
                    intArray[i] = a2;
                    intArray[i + 1] = a1;
                }
            }

            if (CheckArrayCond())
            {
                return;
            }

            Sort();
        }

        bool CheckArrayCond()
        {
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                if (intArray[i] > intArray[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
