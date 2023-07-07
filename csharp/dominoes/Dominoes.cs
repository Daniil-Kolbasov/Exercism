using System.Collections.Generic;
using System.Linq;

public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        if (dominoes == null || !dominoes.Any())
            return true;
        if (dominoes.Count() == 1)
            return dominoes.First().Item1 == dominoes.First().Item2;

        List<(int, int)> dominoesList = dominoes.ToList();
        var start = dominoesList[0].Item1;
        var next = dominoesList[0].Item2;
        dominoesList.Remove(dominoesList[0]);

        return Recursion(dominoesList, start, next);
    }

    private static bool Recursion(List<(int, int)> dominoes, int start, int prev)
    {
        foreach (var d in dominoes)
        {
            if (dominoes.Count == 1)
                return d.Item1 == prev && d.Item2 == start || d.Item1 == start && d.Item2 == prev;

            if (d.Item1 == prev)
            {
                var subDominoes = new List<(int, int)>(dominoes);
                subDominoes.Remove(d);

                if (Recursion(subDominoes, start, d.Item2))
                    return true;
            }
            if (d.Item2 == prev)
            {
                var subDominoes = new List<(int, int)>(dominoes);
                subDominoes.Remove(d);

                if (Recursion(subDominoes, start, d.Item1))
                    return true;
            }
        }

        return false;
    }
}