class Program
{
    static void Main()
    {
        Random r = new Random();
        int n = 0, m = 0, i = 0, j = 0, direction = 0, pp = 0, p = 0, nn = 0, mm = m, k = 0;
        int a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0, a7 = 0, a8 = 0;
        bool flag = true;
        n = Convert.ToInt32(Console.ReadLine());
        m = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[n, m];
        p = m;
        for (i = 0; i < m * n; i++)
        {
            direction++;
            for (j = 0; j < p; j++)
            {
                k++;

            }
            if (flag == true)
                p = n - pp;
            else
            {
                p = m - pp;
                pp++;
            }
        }
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("\n\tПовторить?(enter - Да, др.кл. + enter - НЕТ)\t\t");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        string proverka = Convert.ToString(Console.ReadLine());
        if (proverka == "")
            Main();
    }
}