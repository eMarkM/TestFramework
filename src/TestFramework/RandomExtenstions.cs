using System;
using System.Collections.ObjectModel;

namespace TestFramework
{
    public static class RandomExtenstions
    {
        static Random _rnd = new Random();  // TODO improve with "cryto" impl of Random

        public static T NextElement<T>(this Collection<T> source)
        {
            int index = _rnd.Next(source.Count);
            return source[index];
        }
    }
}
