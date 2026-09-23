class Program 
{

    


    static void Main(string[] args)
    {
        int poziom = 1;
    start:
        for(int i = 0; i < 5 - poziom; i++)
        {
            Console.Write(" ");
        }
        for(int i = 0; i < 2 * poziom - 1; i++)
        {
            Console.Write("X");
        }
        Console.WriteLine();
        poziom++;
        if(poziom <= 5)
        {
            goto start;
        }
    }

}