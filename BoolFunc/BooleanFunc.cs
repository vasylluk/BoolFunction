using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolFunc
{
    class BooleanFunc : ICloneable, IEquatable<BooleanFunc>
    {
        public int n;
        //задання булевої функції реалізовано через вектор її значень
        public int[] args { get; set; }
        public int N
        {
            get => n;
            set => n = value;
        }

        public BooleanFunc(int Num, int[] Args)
        {
            N = Num;
            args = Args;
        }
        //десятковий еквівалент вектора значень - номер функції
        public int GetNumber()
        {
            int res = 0;
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == 1)
                {
                    res += 1 << (args.Length - i - 1);
                }
            }
            return res;
        }

        public BooleanFunc GetDual()
        {
            int[] a = new int[args.Length];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = (args[i] == 0) ? 1 : 0;
            }
            return new BooleanFunc(N=N, args=a);
        }

        public bool IdenticallyTrue()
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] != 1) return false;
            }
            return true;
        }

        public bool IdenticallyFalse()
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] != 0) return false;
            }
            return true;
        }

        public object Clone()
        {
            return new BooleanFunc(N,args);
        }

        public bool Equals(BooleanFunc other)
        {
            if (GetNumber() != other.GetNumber()) return false;
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] != other.args[i]) return false;
            }
            return true;
        }
    }
}
