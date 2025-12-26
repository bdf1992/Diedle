namespace Omega.Core
{
    /// <summary>
    /// The 10 semantic positions of the Purpose Equation.
    /// Each position is a die face, a zone, a meaning.
    ///
    /// P = (M x S) / (A + E + T) x theta(V)
    /// </summary>
    public enum Position
    {
        /// <summary>0: Availability (V) - Constraint, the void, gates the system.</summary>
        Availability = 0,

        /// <summary>1: Meaning (M) - Operator, interpretation begins here.</summary>
        Meaning = 1,

        /// <summary>2: Identity (I) - State, universal content, 0% gaps.</summary>
        Identity = 2,

        /// <summary>3: Purpose (P) - Invariant, where meaning crystallizes.</summary>
        Purpose = 3,

        /// <summary>4: Direction (D) - Operator, ORBIT ZONE, oscillates with 7.</summary>
        Direction = 4,

        /// <summary>5: Structure (S) - State, Observer's home, central attractor.</summary>
        Structure = 5,

        /// <summary>6: Basis (B) - Invariant, foundation, omega x sigma crossover.</summary>
        Basis = 6,

        /// <summary>7: Attention (A) - Operator, ORBIT ZONE, oscillates with 4.</summary>
        Attention = 7,

        /// <summary>8: Effort (E) - State, work amplifier, part of Observer.</summary>
        Effort = 8,

        /// <summary>9: Time (T) - Invariant, BLACK HOLE, absorbs all, contains 0.</summary>
        Time = 9
    }

    /// <summary>
    /// Static data and operations for positions.
    /// </summary>
    public static class PositionData
    {
        public static readonly string[] Names =
        {
            "THE VOID", "MEANING", "IDENTITY", "PURPOSE", "DIRECTION",
            "STRUCTURE", "BASIS", "ATTENTION", "EFFORT", "TIME"
        };

        public static readonly string[] Descriptions =
        {
            "Energy accumulates silently",
            "Operators spawn here",
            "Dice don't decay here",
            "Dice become permanent",
            "ORBIT - oscillates with 7",
            "Observer's home - balanced",
            "Foundation - boosts all dice",
            "ORBIT - oscillates with 4",
            "Active play rewards",
            "BLACK HOLE - absorbs dice"
        };

        /// <summary>
        /// Get the involuted position (sum to 9).
        /// </summary>
        public static Position Involute(Position p)
            => (Position)(9 - (int)p);

        /// <summary>
        /// Get the coset this position belongs to.
        /// </summary>
        public static Coset GetCoset(Position p)
            => CosetData.Of((int)p);

        /// <summary>
        /// Is this position part of the Orbit {4,7}?
        /// </summary>
        public static bool IsOrbit(Position p)
            => p == Position.Direction || p == Position.Attention;

        /// <summary>
        /// Is this position part of the Absorber {3,6,9}?
        /// </summary>
        public static bool IsAbsorber(Position p)
            => p == Position.Purpose || p == Position.Basis || p == Position.Time;

        /// <summary>
        /// Is this position part of the Observer {5,7,8}?
        /// Structure + Attention + Effort
        /// </summary>
        public static bool IsObserver(Position p)
            => p == Position.Structure || p == Position.Attention || p == Position.Effort;

        /// <summary>
        /// Get the name of a position.
        /// </summary>
        public static string GetName(Position p)
            => Names[(int)p];

        /// <summary>
        /// Get the description of a position.
        /// </summary>
        public static string GetDescription(Position p)
            => Descriptions[(int)p];
    }
}
