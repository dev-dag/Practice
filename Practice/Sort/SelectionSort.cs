using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using rubtub2314.Logic.Sort;

namespace rubtub2314.Sort
{
    public class SelectionSort : SortFunction
    {
        public new static T[] Sort<T>(T[] arr, SortMethodEnum sortMethod) where T : IComparable
        {
            // 아규먼트로 넘어온 데이터 보존을 위해 얕은 복사
            T[] copy = new T[arr.Length];
            for (int index = 0; index < arr.Length; index++)
            {
                copy[index] = arr[index];
            }

            // 정렬 방식 선택
            if (sortMethod == SortMethodEnum.Ascending)
            {
                // 오름차 순 정렬
                SortOrderByAscending(copy);
            }
            else if (sortMethod == SortMethodEnum.Descending)
            {
                // 내림차 순 정렬
                SortOrderByDescending(copy);
            }
            else
            {
                throw new ArgumentException();
            }

            return copy;
        }

        private static void SortOrderByAscending<T>(T[] arr) where T : IComparable
        {
            
        }

        private static void SortOrderByDescending<T>(T[] arr) where T : IComparable
        {

        }
    }
}
