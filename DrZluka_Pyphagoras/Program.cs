using System;

namespace DrZluka_Pyphagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое горизонтальное число");
            int FirstGor = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите последнее горизонтальное число");
            int LastGor = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое вертикальное число");
            int FirstVer = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите последнее вертикальное число");
            int LastVer = int.Parse(Console.ReadLine());

            //max result
            int maxResult = LastVer * LastGor;
            int countMaxRank = 0;
            string space = " ";
            string spaceMax = space;
            string dash = "-";
            string dashEmul = dash;
            while (maxResult >= 1)
            {
                maxResult = maxResult / 10;
                countMaxRank++;
                dashEmul = dashEmul + dash;
                spaceMax = spaceMax + space;
            }

            //indent
            int FirstGorEmul = FirstGor;
            int countGor = 0;
            Console.Write(spaceMax + "|");

            //gorizontal numbers
            while (FirstGor <= LastGor)
            {
                int FirstGorRank = FirstGor;
                string spaceGor = space;
                while (FirstGorRank >= 1)
                {
                    FirstGorRank = FirstGorRank / 10;
                    countGor++;
                }
                countGor = countMaxRank - countGor;
                while (countGor >= 1)
                {
                    spaceGor = spaceGor + space; 
                    countGor--;
                }
                Console.Write(spaceGor + FirstGor);
                FirstGor++;
            }
            FirstGor = FirstGorEmul;
            Console.WriteLine();

            //dash
            Console.Write(dashEmul + "+");
            while (FirstGor <= LastGor)
            {
                Console.Write(dashEmul);
                FirstGor++;
            }
            FirstGor = FirstGorEmul;
            Console.WriteLine();

            //vertical numbers + |, result numbers
            int countVer = 0;
            int countResult = 0;
            while (FirstVer <= LastVer)
            {
                int FirstVerRank = FirstVer;
                string spaceVer = space;
                while (FirstVerRank >= 1)
                {
                    FirstVerRank = FirstVerRank / 10;
                    countVer++;
                }
                countVer = countMaxRank - countVer;
                while (countVer >= 1)
                {
                    spaceVer = spaceVer + space;
                    countVer--;
                }
                Console.Write(spaceVer + FirstVer + "|");
                while (FirstGor <= LastGor)
                {
                    int result = FirstVer * FirstGor;
                    int resultEmul = result;
                    string spaceResult = space;
                    while (resultEmul >= 1)
                    {
                        resultEmul = resultEmul / 10;
                        countResult++;
                    }
                    countResult = countMaxRank - countResult;
                    while (countResult >= 1)
                    {
                        spaceResult = spaceResult + space;
                        countResult--;
                    }
                    Console.Write(spaceResult + result);
                    FirstGor++;
                }
                FirstGor = FirstGorEmul;
                Console.WriteLine();
                FirstVer++;
            }
        }
    }
}
