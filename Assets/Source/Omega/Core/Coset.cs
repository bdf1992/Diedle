namespace Omega.Core
{
    /// <summary>
    /// The four cosets of Z/9Z - the fundamental partition.
    ///
    /// lambda = {0}     - Pole, constraint, singularity
    /// tau    = {1,4,7} - Unitary, operators, agency
    /// omega  = {2,5,8} - Complementary, states, observation
    /// sigma  = {3,6,9} - Absorber, invariants, absorption
    /// </summary>
    public enum Coset
    {
        /// <summary>
        /// lambda - The Pole. Constraint, singularity, the void.
        /// </summary>
        Pole = 0,

        /// <summary>
        /// tau - Unitary. Operators, agency, discrete.
        /// Contains the orbit {4,7}.
        /// </summary>
        Unitary = 1,

        /// <summary>
        /// omega - Complementary. States, observation, continuous.
        /// Contains the observer center {5}.
        /// </summary>
        Complementary = 2,

        /// <summary>
        /// sigma - Absorber. Invariants, absorption, fixed points.
        /// All multiplicative walks end here.
        /// </summary>
        Absorber = 3
    }

    /// <summary>
    /// Static data and operations for cosets.
    /// </summary>
    public static class CosetData
    {
        public static readonly int[] Pole = { 0 };
        public static readonly int[] Unitary = { 1, 4, 7 };
        public static readonly int[] Complementary = { 2, 5, 8 };
        public static readonly int[] Absorber = { 3, 6, 9 };

        /// <summary>
        /// Get the coset containing position d.
        /// </summary>
        public static Coset Of(int d)
        {
            if (d == 0) return Coset.Pole;
            int dr = DigitalRoot.Compute(d);
            return dr switch
            {
                1 or 4 or 7 => Coset.Unitary,
                2 or 5 or 8 => Coset.Complementary,
                3 or 6 or 9 => Coset.Absorber,
                _ => Coset.Pole
            };
        }

        /// <summary>
        /// Get the elements of a coset.
        /// </summary>
        public static int[] Elements(Coset c)
        {
            return c switch
            {
                Coset.Pole => Pole,
                Coset.Unitary => Unitary,
                Coset.Complementary => Complementary,
                Coset.Absorber => Absorber,
                _ => Pole
            };
        }

        /// <summary>
        /// Get the color associated with a coset.
        /// tau=red/orange, omega=green/cyan, sigma=blue/purple, lambda=black
        /// </summary>
        public static UnityEngine.Color GetColor(Coset c)
        {
            return c switch
            {
                Coset.Unitary => new UnityEngine.Color(1f, 0.5f, 0f),      // Orange
                Coset.Complementary => new UnityEngine.Color(0f, 0.8f, 0.8f), // Cyan
                Coset.Absorber => new UnityEngine.Color(0.5f, 0f, 0.8f),   // Purple
                Coset.Pole => UnityEngine.Color.black,
                _ => UnityEngine.Color.white
            };
        }

        /// <summary>
        /// Get the involuted coset.
        /// tau <-> omega, sigma <-> sigma, lambda <-> sigma (via dr(0)=9)
        /// </summary>
        public static Coset Involute(Coset c)
        {
            return c switch
            {
                Coset.Unitary => Coset.Complementary,
                Coset.Complementary => Coset.Unitary,
                Coset.Absorber => Coset.Absorber,
                Coset.Pole => Coset.Absorber,
                _ => c
            };
        }
    }
}
