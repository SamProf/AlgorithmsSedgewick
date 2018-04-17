using System;

namespace AlgorithmsSedgewick.UnionFind
{
    public class UnionFindSolution1
    {
        private readonly int n;
        private readonly int[] a;
        private readonly int[] w;

        public class LogItem
        {
            public int Time;
            public int Value1;
            public int Value2;
        }

        public bool Finded;
        public int Value;



        private int GetRoot(int v)
        {
            while (v!=a[v])
            {
                a[v] = a[a[v]];
                v = a[v];
            }
            return v;
        }

        public void Connect(LogItem log)
        {
            var r1 = GetRoot(log.Value1);
            var r2 = GetRoot(log.Value2);
            var wc = 0;
            if (r1 != r2)
            {
                if (w[r1] <= w[r2])
                {
                    a[r1] = r2;
                    w[r2] += w[r1];
                    wc = w[r2];
                }
                else
                {
                    a[r2] = r1;
                    w[r1] += w[r2];
                    wc = w[r1];
                }
            }

            if (wc == n)
            {
                Finded = true;
                Value = log.Time;
            }
        }

        public UnionFindSolution1(int n)
        {
            this.n = n;
            a = new int[n];
            w = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = i;
                w[i] = 1;
            }
        }
    }
}