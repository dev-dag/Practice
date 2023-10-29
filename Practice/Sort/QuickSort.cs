using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using rubtub2314.Sort;

namespace rubtub2314.Logic.Sort
{
    public class QuickSort : SortFunction
    {
        private static SortMethodEnum sortMethod;

        /// <exception cref="ArgumentException">Sort Method Enum값을 잘 못 입력할 경우</exception>
        public new static T[] Sort<T>(T[] originArr, SortMethodEnum sortType) where T : IComparable
        {
            T[] copyArr = new T[originArr.Length];

            // 깊은 복사
            for (int index = 0; index < originArr.Length; index++)
            {
                copyArr[index] = originArr[index];
            }

            sortMethod = sortType;
            SortArray(copyArr, 0, originArr.Length - 1);

            return copyArr;
        }

        private static void SortArray<T>(T[] arr, int left, int right) where T : IComparable
        {
            // 정렬 메서드를 담을 변수 선언
            Func<T[], int, int, int> partitionMethod;

            if (sortMethod == SortMethodEnum.Ascending)
            {
                // 오름차 순 정렬 메서드 할당
                partitionMethod = PartitionPivotOrderByAscending;
            }
            else if (sortMethod == SortMethodEnum.Descending)
            {
                // 내림차 순 정렬 메서드 할당
                partitionMethod = PartitionPivotOrderByDescending;
            }
            else
            {
                // 예외처리
                throw new ArgumentException();
            }

            if (left < right)
            {
                int pivotIndex = partitionMethod.Invoke(arr, left, right);

                SortArray(arr, left, pivotIndex - 1);
                SortArray(arr, pivotIndex + 1, right);
            }
        }

        /// <returns>Pivot</returns>
        private static int PartitionPivotOrderByAscending<T>(T[] arr, int left, int right) where T : IComparable
        {
            T pivot = arr[left];

            while (left < right)
            {
                while (arr[left].CompareTo(pivot) < 0)
                {
                    left++;
                }
                while (arr[right].CompareTo(pivot) > 0)
                {
                    right--;
                }

                if (left < right)
                {
                    T temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;

                    if (arr[left].CompareTo(arr[right]) == 0)
                    {
                        left++;
                    }
                }
            }

            return left;
        }

        /// <returns>Pivot</returns>
        private static int PartitionPivotOrderByDescending<T>(T[] arr, int left, int right) where T : IComparable
        {
            T pivot = arr[left];

            while (left < right)
            {
                while (arr[left].CompareTo(pivot) > 0)
                {
                    left++;
                }
                while (arr[right].CompareTo(pivot) < 0)
                {
                    right--;
                }

                if (left < right)
                {
                    T temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;

                    if (arr[left].CompareTo(arr[right]) == 0)
                    {
                        left++;
                    }
                }
            }

            return left;
        }
    }
}
