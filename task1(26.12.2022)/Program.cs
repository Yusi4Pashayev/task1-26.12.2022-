namespace task1_26._12._2022_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Cüt yerdə duran rəqəmlər
            //Verilmiş ədədin cüt yerdə duran rəqəmlərinin kvadratını hesablayan proqramı yazın
            //Giris: 123046
            //Cixis: 40
            //Izahi: 2 * 2 + 0 * 0 + 6 * 6 = 40


            int sum = 0,b;
            Console.Write("Eded daxil edin:");
            int a = int.Parse(Console.ReadLine());

            while (a!=0)
            { 
                b = a % 10; ;
                a = a / 100;
                sum=sum+b*b;
            }
            Console.WriteLine(sum);



        }
    }
}