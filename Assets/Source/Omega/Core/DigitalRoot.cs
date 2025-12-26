namespace Omega.Core
{
    /// <summary>
    /// Core operations on Z/9Z - the mathematical substrate.
    ///
    /// dr(n), involution, contraction, orbit.
    /// These operations are the ground from which all game mechanics grow.
    /// </summary>
    public static class DigitalRoot
    {
        /// <summary>
        /// The Orbit Product: 4 x 7 = 28, dr(28) = 1.
        /// Universal identity in Z9 multiplication.
        /// </summary>
        public const int OrbitProduct = 28;

        /// <summary>
        /// Digital root: dr(n) = 1 + ((n-1) mod 9), with dr(0) = 9.
        /// Maps any integer to {1,2,3,4,5,6,7,8,9}.
        /// </summary>
        public static int Compute(int n)
        {
            if (n == 0) return 9;
            n = n < 0 ? -n : n;
            int r = n % 9;
            return r == 0 ? 9 : r;
        }

        /// <summary>
        /// Involution: inv(d) = 9 - d (mod 9).
        /// Pairs: (1,8), (2,7), (3,6), (4,5), (0,9).
        /// The uncertainty principle of the framework.
        /// </summary>
        public static int Involute(int d)
        {
            if (d == 0) return 9;
            if (d == 9) return 0;
            int dr = Compute(d);
            return 9 - dr;
        }

        /// <summary>
        /// Contraction: a . b = dr(a x b).
        /// The Lie bracket in Z9 - shared structure consumed.
        /// </summary>
        public static int Contract(int a, int b)
            => Compute(a * b);

        /// <summary>
        /// Rotate by 7: dr(d x 7).
        /// Cycles within cosets: {1,4,7} and {2,5,8} are preserved.
        /// </summary>
        public static int Rotate7(int d)
            => Compute(d * 7);

        /// <summary>
        /// Square: dr(d^2).
        /// Generates the orbit {4,7} - the 2-cycle.
        /// </summary>
        public static int Square(int d)
            => Compute(d * d);

        /// <summary>
        /// Addition in Z9: dr(a + b).
        /// </summary>
        public static int Add(int a, int b)
            => Compute(a + b);

        /// <summary>
        /// Check if value is in absorber {3,6,9}.
        /// These are the fixed points under x7.
        /// </summary>
        public static bool IsAbsorber(int d)
        {
            int dr = Compute(d);
            return dr == 3 || dr == 6 || dr == 9;
        }

        /// <summary>
        /// Check if value is in the orbit {4,7}.
        /// These oscillate under squaring.
        /// </summary>
        public static bool IsOrbit(int d)
        {
            int dr = Compute(d);
            return dr == 4 || dr == 7;
        }

        /// <summary>
        /// Check if value is in unitary {1,4,7}.
        /// The operators - agents of change.
        /// </summary>
        public static bool IsUnitary(int d)
        {
            int dr = Compute(d);
            return dr == 1 || dr == 4 || dr == 7;
        }

        /// <summary>
        /// Check if value is in complementary {2,5,8}.
        /// The states - subjects of observation.
        /// </summary>
        public static bool IsComplementary(int d)
        {
            int dr = Compute(d);
            return dr == 2 || dr == 5 || dr == 8;
        }
    }
}
