namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {   
       //Klavyeden girilen sayıya kadar olan tek sayıları ekrana yazdır
            
            int number =Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < number; i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine(i);
                }
            }
            int sumOfEvent = 0;
            int sumOfOdd = 0;
            for (int i = 0; i < 1000; i++)
            {
                if(i%2==1)
                {
                    sumOfOdd += i;
                }
                else
                {
                    sumOfEvent+= i;
                }
            }
            Console.WriteLine("Tek sayıların toplamı = "+sumOfOdd);
            Console.WriteLine("Çift sayıların toplamı ="+sumOfEvent);

            //break , continue

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}