using System;
using System.Collections.Generic;
using System.Linq;

namespace ReplaceOnce
{
    public class ReplaceOneService
    {
        public string ReplaceOnce(string fullSource, string fullFilter)
        {
            return string.Join(" ", Extract(fullSource.Split(" "), fullFilter.Split(" ")));
        }

        private IEnumerable<string> Extract(IEnumerable<string> source, IEnumerable<string> filters)
        {
            using(var sourceIter = source.GetEnumerator())
            {
                using(var filterIter = filters.GetEnumerator())
                {
                    filterIter.MoveNext();

                    while (sourceIter.MoveNext())
                    {
                        if (sourceIter.Current?.Equals(filterIter.Current) ?? false)
                        {
                            filterIter.MoveNext();
                            continue;
                        }

                        yield return sourceIter.Current;
                    }
                }
            }
        }
    }
}
