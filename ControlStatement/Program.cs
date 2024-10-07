using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //int _day = 8;
        //switch (_day)
        //{
        //    case 1 or 7:
        //        Console.WriteLine("Today is Sunday");
        //        break;
        //    case > 1 and < 7:
        //        Console.WriteLine("Today is Weekday");
        //        break;
        //    default:
        //        Console.WriteLine("Invalid Day");
        //        break;
        //}
        //if (_day == 1 || _day == 7)
        //{
        //    Console.WriteLine("Today is weekend");
        //}
        //else if (_day > 1 && _day< 7)
        //{
        //    Console.WriteLine("Today is Weekday");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid Day");
        //}

        //NestedIFElseExample();
        for (int i = 0;  i< 10; i++)
        {
            if (i % 2 == 0){ 
                Console.WriteLine(i);
            }
        }
        Console.Read();
    }
    ////private static void NestedIFElseExample()
    //{
    //    int _no1 = 6;
    //    int _no2 = 39;

    //    //if (_no1 > 5)
    //    {

    //        if (_no2 > 15)
    //        {

    //            Console.WriteLine("No1 is > 5 and No2 is >15 ");
    //            if (_no2 > 20 && _no2 < 39)
    //            {
    //                Console.WriteLine("No1 is > 5 and No2 is >20");

    //            }
    //            else if (_no2 > 30 && _no2 < 50)
    //            {
    //                Console.WriteLine("No1 is in the range of 30 to 49");
    //            }
    //            else
    //            {
    //                Console.WriteLine("Not in range, its greater than 50");
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine("no1 is > 5 but no2 is not greater than 15");
    //        }
    //    }
    ////    else
    //    {
    //        Console.WriteLine("No1 is not greater than 5");
    //    }
    
}