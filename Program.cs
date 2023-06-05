using System;
using System.Numerics;

namespace dm_timus_solution {
    class Program {
        static void Main(string[] args) {
            int n;
            int k;
            n = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            BigInteger[] numAmount = new BigInteger[n];

            numAmount[0] = k;
            if (n == 1) {
                Console.WriteLine(numAmount[0]);
                return;
            }
            numAmount[1] = (k - 1) * k;
            if (n == 2) {
                Console.WriteLine(numAmount[1]);
                return;
            }
            numAmount[2] = numAmount[1]*(k - 1) + (numAmount[0]-1) * (k-1);
            if (n == 3) {
                Console.WriteLine(numAmount[2]);
                return;
            }
            for (int i = 3; i < n; i++) {
                numAmount[i] = (numAmount[i - 1] + numAmount[i - 2]) * (k - 1);
            }
            Console.WriteLine(numAmount[n - 1]);
        }
    }
}
