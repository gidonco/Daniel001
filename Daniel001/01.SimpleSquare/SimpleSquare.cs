using System;
using Microsoft.SmallBasic.Library;
using SmallBasicFun;

namespace SimpleSquare
{
    public class SimpleSquare
    {
        public static void Main()
        {
            Tortoise.Show();
            Tortoise.SetSpeed(10);
            var sides = 100;

            for (int i = 0; i < sides; i++)
            {
                Tortoise.SetPenColor("interblue");
                Tortoise.SetPenWidth(new Random().Next(1,10));
                Tortoise.Move(100);
                Tortoise.Turn(100);
            }
           

        }
    }
}