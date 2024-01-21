using lesson2;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Matrix<int> array = new Matrix<int>(2, 2);
            array[0,0] = 1;
            array[0,1] = 2;
            array[1,1] = 3;
            array[1,0] = 4;

            array.PrintMatrix();
/*
            Collection<string> collection = new Collection<string>(size 10);
            collection[0] = "new string";
            collection[1] = "new string1";

            Console.WriteLine(collection[0]);
            Console.WriteLine(collection[1]);
*/
            Bits bit = new (100);
            Bits bitInt = new Bits((int)10);
            Bits bitByte = new Bits((byte)11);
            Bits bitLong = new Bits((long)12);

            Console.WriteLine(bit);
            Console.WriteLine(bitInt);
            Console.WriteLine(bitByte);
            Console.WriteLine(bitLong);

        }
    }
}
