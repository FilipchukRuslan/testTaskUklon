using Common.Interface;
using System;

namespace Common
{
    public class MyRandom : IMyRandom
    {
        Random random = new Random();

        public int GetRandomValue()
        {
            return random.Next(50, 100);
        }
    }
}
