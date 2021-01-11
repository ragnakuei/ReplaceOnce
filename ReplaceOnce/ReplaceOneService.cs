using System;
using System.Collections.Generic;
using System.Linq;

namespace ReplaceOnce
{
    public class ReplaceOneService
    {
        public string ReplaceOnce(string fullSource, string fullFilter)
        {
            return string.Join(" ",
                               Extract(new Queue<string>(fullSource.Split(" ")),
                                       new Queue<string>(fullFilter.Split(" "))));
        }

        private IEnumerable<string> Extract(Queue<string> source, Queue<string> filters)
        {
            while (source.Count > 0)
            {
                if (filters.Count > 0
                 && source.Peek().Equals(filters.Peek()))
                {
                    filters.Dequeue();
                    source.Dequeue();
                    continue;
                }

                yield return source.Dequeue();
            }
        }
    }
}
