using System.Linq;

namespace MarkovChainSentences.Extensions
{
    public static class ListExtensions // What the fuck is linq?
    {
        public static T[] combine<T>(this T[] l1, T[] l2)
        {
            T[] u1, u2;
            if (l1.Length > l2.Length)
            {
                u1 = l1;
                u2 = l2;
            }
            else
            {
                u2 = l1;
                u1 = l2;
            }
            var l = u1.AsEnumerable();
            foreach (var v in u2)
            {
                l = l.Append<T>(v);
            }
            u1 = l.ToArray();
            return u1;
        }
    }
}