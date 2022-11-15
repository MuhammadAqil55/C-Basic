////int[] num = { 10, 20, 30, 45, 50, 55, 60, 75, 80 };


////foreach (var item in num)
////{
////    Console.WriteLine(item);
////}

////    var res = from number in num
////            where number > 25
////            select number;

////Console.WriteLine("********");

////foreach (var item in res)
////{
////    Console.WriteLine(item);
////}


////var words = new string[] { "fly", "higher", "way", "longroad", "sky","Line"};
   
////var res2 = from word in words
////         //  where word.Length> 5
////           select word+" : "+word.Length;
////foreach (var item in res2)
////{
////    Console.WriteLine(item);
////}
static void main()
{
    int n = 6;
    for (int i = 1; i <= n; i++)/// 6
    {
        for (int j = 1; j <= n - i; j++)//5
        {
            Console.Write(" ");

        }
        for (int k = 1; k <= i; k++)
        {
            Console.Write("*");
        }
        for (int l = i - 1; l >= 1; l--)
        {
          Console.Write("*");
        }
        Console.Write("\n");
    }
}
main();