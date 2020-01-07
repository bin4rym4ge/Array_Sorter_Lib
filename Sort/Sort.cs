using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter
{
	public class Sort
	{
		public Sort() //(array, enumerated sorting type)
		{
			//implement overloading for methods to include multiple array types (int float char string double...)

		}

		public int[] SortArr(int[] arr)
		{
			bool end = false;
			bool sorted = false;
			bool flag = false;
			int temp = 0;

			while(!end)
			{
				for(int i = 1; i < arr.Length; i++)
				{
					if (arr[i-1] > arr[i])
					{
						//swap
						temp = arr[i - 1];
						arr[i - 1] = arr[i];
						arr[i] = temp;

						flag = true;
						sorted = false;
					}
				}
				
				if (sorted)
				{
					end = true;
				}
				else if(flag)
				{
					sorted = true;
					flag = false;
				}
			}
			return arr;
		}
		public string[] SortArr(string[] arr)
		{
			return arr;
		}

		public int[] HeapSortArr(int[] arr)
		{
			bool end = false;
			int temp = 0;
			int tempn = 0;
			int place = arr.Length;

			while (!end)
			{
				for(int i = place - 1; i > 0 ; i--)
				{
					for(int num = 0; num < place; num++ )
					{
						//get highest number
						if(arr[num] > temp)
						{
							temp = arr[num];
							tempn = num;
						}
					}
					//swap
					temp = arr[i];
					arr[i] = arr[tempn];
					arr[tempn] = temp;
					temp = 0;

					place--;
				}
				end = true;
			}
			return arr;
		}
		public string[] HeapSortArr(string[] arr)
		{

			return arr;
		}
	}
}
