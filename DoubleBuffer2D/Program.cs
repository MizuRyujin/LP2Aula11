using System;

namespace DoubleBuffer2D
{
    class Program
    {
        static void Main()
        {
            DoubleBuffer2D<char> buffer = 
                new DoubleBuffer2D<char>(5, 5);

            buffer[1, 0] = 'X';
            buffer[2, 0] = 'X';
            buffer[3, 0] = 'X';
            buffer[4, 0] = 'X';
            buffer[1, 1] = 'X';
            buffer[1, 2] = 'X';
            buffer[2, 2] = 'X';
            buffer[3, 2] = 'X';
            buffer[3, 3] = 'X';
            buffer[0, 4] = 'X';
            buffer[1, 4] = 'X';
            buffer[2, 4] = 'X';
            buffer[3, 4] = 'X';

            buffer.Swap();

            for (int y = 0; y < buffer.YDim; y++)
            {
                for (int x = 0; x < buffer.XDim; x++)
                {
                    Console.Write(buffer[x,y]);
                }
                Console.WriteLine();
            }
        }
    }
}
