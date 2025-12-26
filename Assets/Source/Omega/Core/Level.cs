namespace Omega.Core
{
    /// <summary>
    /// The 10 levels of mathematical reality.
    ///
    /// From continuous substrate to self-reference.
    /// Levels are involuted in pairs that sum to 9.
    /// </summary>
    public enum Level
    {
        /// <summary>L0: Substrate - Physics, electricity, continuous.</summary>
        L0_Substrate = 0,

        /// <summary>L1: Binary - {0,1}, bits, parity.</summary>
        L1_Binary = 1,

        /// <summary>L2: Integer - Z, the counting numbers.</summary>
        L2_Integer = 2,

        /// <summary>L3: Modular - Z/NZ, quotient rings.</summary>
        L3_Modular = 3,

        /// <summary>L4: Cosets - Orbits under multiplication.</summary>
        L4_Cosets = 4,

        /// <summary>L5: Dynamics - Squaring, orbits, cycles. THE ORBIT lives here.</summary>
        L5_Dynamics = 5,

        /// <summary>L6: Stalks - Prime-local views (Zp, p-adics).</summary>
        L6_Stalks = 6,

        /// <summary>L7: Adelic - Product of all Zp, simultaneous residues.</summary>
        L7_Adelic = 7,

        /// <summary>L8: Sheaf - Global sections over local data.</summary>
        L8_Sheaf = 8,

        /// <summary>L9: Autopoiesis - Self-referential observation.</summary>
        L9_Autopoiesis = 9
    }

    /// <summary>
    /// Static operations for levels.
    /// </summary>
    public static class LevelData
    {
        public static readonly string[] Names =
        {
            "Substrate", "Binary", "Integer", "Modular", "Cosets",
            "Dynamics", "Stalks", "Adelic", "Sheaf", "Autopoiesis"
        };

        /// <summary>
        /// Get the involuted level (sum to 9).
        /// L0 <-> L9, L1 <-> L8, L2 <-> L7, L3 <-> L6, L4 <-> L5
        /// </summary>
        public static Level Involute(Level level)
            => (Level)(9 - (int)level);

        /// <summary>
        /// Is this level part of the Orbit pair (L4 <-> L5)?
        /// </summary>
        public static bool IsOrbit(Level level)
            => level == Level.L4_Cosets || level == Level.L5_Dynamics;

        /// <summary>
        /// Get the name of a level.
        /// </summary>
        public static string GetName(Level level)
            => Names[(int)level];
    }
}
