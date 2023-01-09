public class Program
{
    static void Main(string[] args)
    {

        ////var ip = new IP(192, 168, 1, 1);
        //var ip = new IP("192.168.1.1");


        //var FirsttSegment = ip[0];
        //System.Console.WriteLine($"Ip Address = {ip.Address}");
        //System.Console.WriteLine($"First Segment = {FirsttSegment}");

        //Console.ReadKey();

        int[,] inputs = new int[,]
        {
                {9,8,7,6,5,4,3,2,1},
                {1,2,3,4,5,6,7,8,9},
                {1,5,9,7,5,3,7,8,9}
        };

        var suduko = new Suduko(inputs);

        Console.WriteLine(suduko[1, 4]);//5
        suduko[1, 4] = -2;
        Console.WriteLine(suduko[1, 4]);//10


        Console.ReadKey();
    }
}



#region IP
//public class IP
//{
//    private int[] segments = new int[4];

//    public int this[int Index]//Indexer ,this refer to Object to class
//    {
//        get
//        {
//            return segments[Index];
//        }
//        set
//        {
//            segments[Index] = value;
//        }
//    }

//    public IP(string IPAddress)
//    {
//        var segs = (char)IPAddress.Split(".");
//        for (int i = 0; i < segs.Length; i++)
//        {
//            segments[i] = Convert.ToInt32(segs[i]);
//        }
//    }
//    public IP(int segments1, int segments2, int segments3, int segments4)
//    {
//        segments[0] = segments1;
//        segments[1] = segments2;
//        segments[2] = segments3;
//        segments[3] = segments4;

//    }

//    public string Address => string.Join(".", segments);//Join() to add anu item to array
//}
#endregion

public class Suduko
{
    private int[,] _matrix;

    public int this[int row, int col]
    {
        get
        {
            // value out of range
            if (row < 0 || row > _matrix.GetLength(0) - 1)//GetLength(0) for rows
                return -1;


            if (col < 0 || col > _matrix.GetLength(1) - 1)//GetLength(1) for col

                return -1;

            return _matrix[row, col];


        }
        set
        {
            if (value < 1 || value > _matrix.GetLength(0))
                return;

            _matrix[row, col] = value;
        }
    }

    public Suduko(int[,] matrix)
    {
        _matrix = matrix;
    }

}