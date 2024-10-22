////No.1 
//using System;
//public class Program
//{
//    public static bool IsPalindrome(string input)
//    {
//        string cleanedInput = input.Replace(" ", "").ToLower();
//        int left = 0;
//        int right = cleanedInput.Length - 1;
//        while (left < right)
//        {
//            if (cleanedInput[left] != cleanedInput[right])
//                left++;
//                right--;

//        }
//        return true;
//    }

//    public static void Main()
//    {
//        Console.WriteLine(IsPalindrome("racecar"));

//    }

//}


////No.2 b) Sorting algorithms / Merge sort
//using System;
//public class Program
//{
//    static void merge(int[] arr, int a, int b, int c)
//    {
//        int n1 = b - a + 1;
//        int n2 = c - (b+1) +1;
//        int[] L = new int[n1];
//        int[] R = new int[n2];
//        int i, j;

//        for (i = 0; i < n1; i++)
//        {
//            L[i] = arr[a + i];
//        }

//        for(j = 0; j < n2; j++)
//        {
//            R[j] = arr[b + 1 + j];
//        }

//        i = 0;
//        j = 0;

//        int d = a;
//        while (i < n1 && j < n2)
//        {
//            if (L[i] <= R[j])
//            {
//                arr[d] = L[i];
//                i++;
//            }
//            else
//            {
//                arr[d] = R[j];
//                j++;
//            }

//            d++;
//        }

//        while (i < n1)
//        {
//            arr[d] = L[i];
//            i++;
//            d++;
//        }

//        while (j < n2)
//        {
//            arr[d] = R[j];
//            j++;
//            d++;
//        }


//    }

//    static void mergeSort(int[] arr, int a, int c)
//    {
//        if (a < c)
//        {
//            int b = a + (c - a) / 2;
//            mergeSort(arr, a, b);
//            mergeSort(arr, b + 1, c);
//            merge(arr, a, b, c);
//        }
//    }

//    static void printArray(int[] arr)
//    {
//        int n = arr.Length;
//        for (int i = 0; i < n; i++)
//            Console.WriteLine(arr[i] + " ");
//        Console.WriteLine();

//    }

//    public static void Main(string[] args)
//    {
//        int[] arr = {38, 27, 43, 3, 9, 82, 10 };
//        Console.WriteLine("The initial array is: ");
//        printArray(arr);

//        mergeSort(arr, 0, arr.Length - 1);
//        Console.WriteLine("Here is the sorted array: ");
//        printArray(arr);
//    }

//}



//No.3 Custom implementation based on arrays of list.
using System;
class CustomList<T>
{
    private T[] _items;
    private int _count;

    public CustomList()
    {
        _items = new T[4];
        _count = 0;
    }

    public int Count => _count;

    public void Add (T item)
    {
        if (_count == _items.Length)
            Resize();
        _items[_count] = item;
        _count++;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException("Index is out of range ");
            return _items[index];
        }
        set
        {
            if (index < 0 || index >= _count) ;
            throw new IndexOutOfRangeException("Inmdex is out of range ");
            _items[index] = value;
        }
    }
    private void Resize()
    {
        T[] newItems = new T[_items.Length*2];

        for (int i = 0; i < _items.Length; i++)
            newItems[i] = _items[i];
        _items = newItems;
    }

    public bool Remove(T item)
    {
        int index = IndexOf(item);
        if (index == -1)
            return false;

        for (int i = index; i < _count - 1; ++i)
            _items[i] = _items[i + 1];
        _count--;
        return true;
    }

    public int IndexOf(T item)
    {
        for(int i =0; i < _count; ++i)
        {
            if (_items[i].Equals(item))
                return i;
        }
        return -1;
    }

    public void Clear()
    {
        _items = new T[4];
        _count = 0;
    }

    class Program
    {
        static void main()
        {
            CustomList<int> list = new
                CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            Console.WriteLine("The list cout: " + list.Count);
            for (int i = 0; i < list.Count; ++i)
                Console.WriteLine($"Element at index {i}: {list[i]}");

            list.Remove(3);
            Console.WriteLine("\nAfter removing the element 3: ");
                for(int i =0; i < list.Count; ++i)
                Console.WriteLine($"Element at index {i}: {list[i]}");

            Console.WriteLine($"Element at index 2: {list[2]}");

            list.Clear();
            Console.WriteLine("\nThe list count after the cleaning: " + list.Count);



        }
    }



}





