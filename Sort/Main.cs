using System;
using Sorter;

namespace Sorter
{
	class Runtime
	{
		static void Main()
		{
			int[] data = new int[] {1,4,2,6,7,3,5,22,13,77,89,12,16,44};
			Sort SortArr = new Sort();

			data = SortArr.HeapSortArr(data);

			foreach (int var in data)
			{
				Console.Write(var + " ");
			}

			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
