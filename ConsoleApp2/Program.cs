namespace ConsoleApp2;

class Program
{
    static void Main()
    {
        IntList list = new IntList();

        list.Add(4);
        list.Add(8);
        list.Add(15);

        list.Insert(1, 6);
        list.Insert(0, 1);
        list.Insert(5, 9);

        list.RemoveAt(2);

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list.Get(i));
        }
        
        Console.WriteLine($"Count: {list.Count}");
    }
}

class IntList
{
    private int[] _arr = new int[4];
    private int _count;


    public int Count
    {
        get { return _count; }
    }


public void Add(int value)
   {
       if (_count == _arr.Length)
       {
           int[] newArr = new int [_arr.Length * 2];
           for (int i = 0; i < _count; i++)
           {
               newArr[i] = _arr[i];
               _arr = newArr;
           }

           _arr[_count] = value;
           _count++;
       } 
   }

   public void Insert(int index, int value)
   {
       if (index < 0 || index > _count)
       {
           throw new ArgumentOutOfRangeException(nameof(index));
       }

       if (_count == _arr.Length)
       {
           int[] newArr = new int[_arr.Length * 2];

           for (int i = 0; i < _count; i++)
           {
               newArr[i] = _arr[i];
           }

           _arr = newArr;
       }

       for (int i = _count; i > index; i--)
       {
           _arr[i] = _arr[i - 1];
       }

       _arr[index] = value;
       _count++;
   }

   public void RemoveAt(int index)
   {
           if (index < 0 || index >= _count)
           {
               throw new ArgumentOutOfRangeException(nameof(index));
           }

           for (int i = index; i < _count - 1; i++)
           {
               _arr[i] = _arr[i + 1];
           }

           _count--;
           _arr[_count] = 0;
       }
   

   public int Get(int index)
   {
       if (index < 0 || index >= _count)
       {
           throw new ArgumentOutOfRangeException(nameof(index));
       }

       return _arr[index];
   }
}