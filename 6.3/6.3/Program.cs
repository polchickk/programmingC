using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    class Program
    {// Белый ферзь и черный ферзь
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого ферзя");
            var whiteQueenPosition = Console.ReadLine();

            Console.WriteLine("Введите позицию черного ферзя");
            var blackQueenPosition = Console.ReadLine();

            if (!IsFiguresPositionsCorrect(whiteQueenPosition, blackQueenPosition))
            {
                Console.WriteLine("Позиции фигур не соответствуют условиям задачи");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите ход белого ферзя");
            var move = Console.ReadLine();

            if (IsQueenCanMakeSafeMove(whiteQueenPosition, blackQueenPosition, move))
                Console.WriteLine($"Ферзь {whiteQueenPosition} может безопасно пойти на клетку {move}");
            else
                Console.WriteLine($"Ферзь {whiteQueenPosition} не может пойти на клетку {move}");

            Console.ReadKey();
        }

        static bool IsFiguresPositionsCorrect(string queenWhitePosition, string queenBlackPosition)
        {
            return !IsEqualPositions(queenWhitePosition, queenBlackPosition) &&
                IsqueenBlackPositionCorrect(queenBlackPosition) &&
                !IsWhiteQueenStrikesqueenBlack(queenWhitePosition, queenBlackPosition) &&
                !IsqueenBlackStrikesWhiteQueen(queenWhitePosition, queenBlackPosition);
        }

        static bool IsWhiteQueenCanMakeSafeMove(string queenWhitePosition, string queenBlackPosition, string move)
        {
            return IsWhiteQueenCanMove(queenWhitePosition, move) &&
                !IsqueenBlackStrikesWhiteQueen(move, queenBlackPosition);
        }

        static bool IsEqualPositions(string position1, string position2)
        {
            return position1 == position2;
        }

        static bool IsqueenBlackStrikesWhiteQueen(string queenWhitePosition, string queenBlackPosition)
        {
            int qx, qy, px, py;

            GetCoordinates(queenWhitePosition, out qy, out qx);
            GetCoordinates(queenBlackPosition, out py, out px);

            return py - qy == 1 && Math.Abs(px - qx) == 1;
        }

        static bool IsWhiteQueenStrikesqueenBlack(string queenWhitePosition, string queenBlackPosition)
        {
            return IsWhiteQueenCanMove(queenWhitePosition, queenBlackPosition);
        }

        static bool  IsqueenBlackPositionCorrect(string queenBlackPosition)
        {
            int px, py;
            GetCoordinates(queenBlackPosition, out py, out px);

            return py > 0 && py < 7;
        }

        static bool IsWhiteQueenCanMove(string queenWhitePosition, string move)
        {
            int qx, qy, mx, my;
            GetCoordinates(queenWhitePosition, out qy, out qx);
            GetCoordinates(move, out my, out mx);

            return qy == my || qx == mx || Math.Abs(qy - my) == Math.Abs(qx - mx);
        }

        static void GetCoordinates(string position, out int row, out int column)
        {
            row = (int)position[1] - 0x31;
            column = (int)position[0] - 0x61;
        }
    }
}
