using System.Collections.Generic;

namespace Omega.Dynamics
{
    using Omega.Core;

    /// <summary>
    /// The orbit is the 2-cycle {4,7} under squaring.
    ///
    /// 4^2 = 16 -> dr(16) = 7
    /// 7^2 = 49 -> dr(49) = 4
    ///
    /// This is where exponential blowup lives.
    /// Direction and Attention oscillate forever.
    /// </summary>
    public static class Orbit
    {
        /// <summary>
        /// The orbit pair: {4, 7}
        /// </summary>
        public static readonly int[] Pair = { 4, 7 };

        /// <summary>
        /// The orbit product: 4 x 7 = 28, dr(28) = 1
        /// </summary>
        public const int Product = 28;

        /// <summary>
        /// Is this value in the orbit?
        /// </summary>
        public static bool Contains(int d)
        {
            int dr = DigitalRoot.Compute(d);
            return dr == 4 || dr == 7;
        }

        /// <summary>
        /// Step the orbit: 4 -> 7, 7 -> 4.
        /// Non-orbit values just square.
        /// </summary>
        public static int Step(int d)
        {
            int dr = DigitalRoot.Compute(d);
            if (dr == 4) return 7;
            if (dr == 7) return 4;
            return DigitalRoot.Square(d);
        }

        /// <summary>
        /// Trace an orbit from starting value.
        /// Returns (path, cycleStart, cycleLength).
        /// </summary>
        public static (int[] path, int cycleStart, int cycleLength) Trace(int start, int maxSteps = 20)
        {
            var path = new List<int> { DigitalRoot.Compute(start) };
            var seen = new Dictionary<int, int> { { path[0], 0 } };

            int current = path[0];
            for (int i = 1; i <= maxSteps; i++)
            {
                current = DigitalRoot.Square(current);
                if (seen.TryGetValue(current, out int cycleStart))
                {
                    return (path.ToArray(), cycleStart, i - cycleStart);
                }
                path.Add(current);
                seen[current] = i;
            }

            return (path.ToArray(), -1, 0);
        }

        /// <summary>
        /// Count oscillations in a sequence.
        /// Each 4->7 or 7->4 transition counts as one.
        /// </summary>
        public static int CountOscillations(int[] sequence)
        {
            int count = 0;
            for (int i = 1; i < sequence.Length; i++)
            {
                bool prev = Contains(sequence[i - 1]);
                bool curr = Contains(sequence[i]);
                if (prev && curr && sequence[i - 1] != sequence[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
