namespace Sample505
{
    public class Bingo
    {
        private int[,] data;
        private int bingoSheetSize;

        private void InitBingoSheet(int size)
        {
            data = new int[size, size];
            bingoSheetSize = size * size;
            Array.Clear(data, 0, data.Length);

            return;
        }

        private void GenerateBingo(int size)
        {
            Random rnd = new Random();

            int num = 1;

            while (num <= bingoSheetSize)
            {

                while (true)
                {
                    int m = rnd.Next(size);
                    int n = rnd.Next(size);

                    if (data[m, n] == 0)
                    {
                        data[m, n] = num;
                        num++;
                        break;
                    }
                }
            }

            return;
        }

        public void Init(int size)
        {
            InitBingoSheet(size);
            GenerateBingo(size);
        }

        public void Show()
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("{0,2:d}|", data[i, j]);
                }
                Console.WriteLine();
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("---");
                }
                Console.WriteLine();
            }
        }
    }
}
