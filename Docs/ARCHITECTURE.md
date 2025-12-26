# DICE IDLE — Unity/C# Architecture

## The Principle

**Ω̃ = ⨁ₙ Hₙ baked into C# types**

The mathematical substrate is not a library we call — it IS the type system.
Every class, every enum, every method signature reflects the algebra.

---

## I. PROJECT STRUCTURE

```
DiceIdle/
├── Assets/
│   ├── Scripts/
│   │   ├── Omega/                    ← THE GROUND (Ω̃)
│   │   │   ├── Core/
│   │   │   │   ├── Level.cs          ← L₀-L₉ hierarchy
│   │   │   │   ├── Coset.cs          ← λ, τ, ω, σ
│   │   │   │   ├── Position.cs       ← 0-9 semantic positions
│   │   │   │   └── DigitalRoot.cs    ← dr(), involution, contraction
│   │   │   ├── Dynamics/
│   │   │   │   ├── Orbit.cs          ← The 2-cycle {4,7}
│   │   │   │   ├── Absorption.cs     ← Drift to σ
│   │   │   │   └── Involution.cs     ← Paired operations
│   │   │   └── Adelic/
│   │   │       ├── Stalk.cs          ← Local p-adic views
│   │   │       └── Sheaf.cs          ← Global sections
│   │   │
│   │   ├── Game/                     ← GAME SYSTEMS
│   │   │   ├── Core/
│   │   │   │   ├── GameManager.cs    ← Main controller
│   │   │   │   ├── GameState.cs      ← Serializable state
│   │   │   │   └── GamePhase.cs      ← PRE_BANG → PLAYING
│   │   │   ├── Zones/
│   │   │   │   ├── Zone.cs           ← Die face as game area
│   │   │   │   ├── ZoneManager.cs    ← Travel, orbit detection
│   │   │   │   └── ZoneEffects.cs    ← Per-zone mechanics
│   │   │   ├── Dice/
│   │   │   │   ├── Die.cs            ← Individual die
│   │   │   │   ├── DiceTier.cs       ← BASIC → VOID → BORROMEAN
│   │   │   │   ├── DiceRoller.cs     ← Roll with Ω̃ constraints
│   │   │   │   └── DiceCombiner.cs   ← Combine recipes
│   │   │   ├── Progression/
│   │   │   │   ├── SkillTree.cs      ← Infinite upgrades
│   │   │   │   ├── Operations.cs     ← ×, +, ², ×7
│   │   │   │   └── Transcendence.cs  ← Die texture tiers
│   │   │   └── ParameterSpace/
│   │   │       ├── Universe.cs       ← c-value universes
│   │   │       ├── Mandelbrot.cs     ← M set detection
│   │   │       └── CosmicTranscendence.cs
│   │   │
│   │   ├── UI/                       ← USER INTERFACE
│   │   │   ├── HUD/
│   │   │   ├── Zones/
│   │   │   ├── Dice/
│   │   │   └── Menus/
│   │   │
│   │   ├── Research/                 ← THE SECRET
│   │   │   ├── DataCollector.cs      ← Track all player actions
│   │   │   ├── CosetAnalytics.cs     ← Distribution analysis
│   │   │   └── ResearchExporter.cs   ← JSON export
│   │   │
│   │   └── Steam/                    ← STEAM INTEGRATION
│   │       ├── SteamManager.cs
│   │       ├── Achievements.cs
│   │       └── CloudSave.cs
│   │
│   ├── Prefabs/
│   │   ├── Dice/
│   │   ├── Zones/
│   │   └── Effects/
│   │
│   ├── Art/
│   │   ├── Sprites/
│   │   ├── Shaders/
│   │   └── Animations/
│   │
│   ├── Audio/
│   │
│   └── Resources/
│       └── Data/
│           ├── ZoneData.asset
│           ├── DiceTiers.asset
│           └── SkillNodes.asset
│
├── Packages/
│   └── com.rlabrecque.steamworks.net  ← Steamworks.NET
│
└── ProjectSettings/
```

---

## II. THE GROUND (Ω̃) — Core Math Types

### Level.cs — The 10-Level Hierarchy

```csharp
namespace Omega.Core
{
    /// <summary>
    /// The 10 levels of mathematical reality.
    /// L₀ ↔ L₉, L₁ ↔ L₈, L₂ ↔ L₇, L₃ ↔ L₆, L₄ ↔ L₅
    /// </summary>
    public enum Level
    {
        L0_Substrate = 0,      // Physics, continuous
        L1_Binary = 1,         // {0,1}, bits
        L2_Integer = 2,        // ℤ, counting
        L3_Modular = 3,        // ℤ/Nℤ, quotient
        L4_Cosets = 4,         // Orbits under ×
        L5_Dynamics = 5,       // Squaring, cycles ← THE ORBIT
        L6_Stalks = 6,         // p-adic locals
        L7_Adelic = 7,         // ∏ₚ ℤₚ
        L8_Sheaf = 8,          // Global sections
        L9_Autopoiesis = 9     // Self-reference
    }

    public static class LevelExtensions
    {
        /// <summary>
        /// Get the involuted level (sum to 9).
        /// </summary>
        public static Level Involute(this Level level)
            => (Level)(9 - (int)level);

        /// <summary>
        /// Is this level part of the Orbit pair (L4 ↔ L5)?
        /// </summary>
        public static bool IsOrbit(this Level level)
            => level == Level.L4_Cosets || level == Level.L5_Dynamics;
    }
}
```

### Coset.cs — The Four Fundamental Partitions

```csharp
namespace Omega.Core
{
    /// <summary>
    /// The four cosets of Z₉.
    /// λ = {0}, τ = {1,4,7}, ω = {2,5,8}, σ = {3,6,9}
    /// </summary>
    public enum Coset
    {
        Pole = 0,           // λ — Constraint, singularity
        Unitary = 1,        // τ — Operators, agency
        Complementary = 2,  // ω — States, observation
        Absorber = 3        // σ — Invariants, absorption
    }

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
        /// Is this coset closed under ×7?
        /// All non-Pole cosets are.
        /// </summary>
        public static bool IsClosedUnderRotate7(Coset c) => c != Coset.Pole;
    }
}
```

### Position.cs — The 10 Semantic Positions

```csharp
namespace Omega.Core
{
    /// <summary>
    /// The 10 positions of the Purpose Equation.
    /// Each position has semantic meaning.
    /// </summary>
    public enum Position
    {
        Availability = 0,  // V — Constraint
        Meaning = 1,       // M — Operator
        Identity = 2,      // I — State
        Purpose = 3,       // P — Invariant
        Direction = 4,     // D — Operator (ORBIT)
        Structure = 5,     // S — State (Observer home)
        Basis = 6,         // B — Invariant
        Attention = 7,     // A — Operator (ORBIT)
        Effort = 8,        // E — State
        Time = 9           // T — Invariant (Absorber)
    }

    public static class PositionData
    {
        public static readonly string[] Names =
        {
            "THE VOID", "MEANING", "IDENTITY", "PURPOSE", "DIRECTION",
            "STRUCTURE", "BASIS", "ATTENTION", "EFFORT", "TIME"
        };

        /// <summary>
        /// Get the involuted position (sum to 9).
        /// </summary>
        public static Position Involute(Position p)
            => (Position)(9 - (int)p);

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
        /// </summary>
        public static bool IsObserver(Position p)
            => p == Position.Structure || p == Position.Attention || p == Position.Effort;
    }
}
```

### DigitalRoot.cs — The Core Operations

```csharp
namespace Omega.Core
{
    /// <summary>
    /// Core operations on Z₉.
    /// dr(n), involution, contraction, orbit.
    /// </summary>
    public static class DigitalRoot
    {
        /// <summary>
        /// Digital root: dr(n) = 1 + ((n-1) mod 9), with dr(0) = 9.
        /// </summary>
        public static int Compute(int n)
        {
            if (n == 0) return 9;
            n = n < 0 ? -n : n;
            int r = n % 9;
            return r == 0 ? 9 : r;
        }

        /// <summary>
        /// Involution: ent(d) = 9 - d (mod 9).
        /// Pairs: (1,8), (2,7), (3,6), (4,5), (0,9).
        /// </summary>
        public static int Involute(int d)
        {
            if (d == 0) return 9;
            if (d == 9) return 0;
            return 9 - (d % 9);
        }

        /// <summary>
        /// Contraction: a ⊗ b = dr(a × b).
        /// The Lie bracket in Z₉.
        /// </summary>
        public static int Contract(int a, int b)
            => Compute(a * b);

        /// <summary>
        /// Rotate by 7: dr(d × 7).
        /// Cycles within cosets.
        /// </summary>
        public static int Rotate7(int d)
            => Compute(d * 7);

        /// <summary>
        /// Square: dr(d²).
        /// Generates the orbit {4,7}.
        /// </summary>
        public static int Square(int d)
            => Compute(d * d);

        /// <summary>
        /// The Orbit Product: 4 × 7 = 28, dr(28) = 1.
        /// </summary>
        public const int OrbitProduct = 28;
    }
}
```

### Orbit.cs — The 2-Cycle Dynamics

```csharp
namespace Omega.Dynamics
{
    using Omega.Core;

    /// <summary>
    /// The orbit is the 2-cycle {4,7} under squaring.
    /// 4² = 16 → dr(16) = 7
    /// 7² = 49 → dr(49) = 4
    /// </summary>
    public static class Orbit
    {
        public static readonly int[] Pair = { 4, 7 };

        /// <summary>
        /// Is this value in the orbit?
        /// </summary>
        public static bool Contains(int d)
            => d == 4 || d == 7;

        /// <summary>
        /// Step the orbit: 4 → 7, 7 → 4.
        /// </summary>
        public static int Step(int d)
        {
            if (d == 4) return 7;
            if (d == 7) return 4;
            return DigitalRoot.Square(d); // Non-orbit values just square
        }

        /// <summary>
        /// Trace an orbit from starting value.
        /// Returns (path, cycleStart, cycleLength).
        /// </summary>
        public static (int[] path, int cycleStart, int cycleLength) Trace(int start, int maxSteps = 20)
        {
            var path = new System.Collections.Generic.List<int> { start };
            var seen = new System.Collections.Generic.Dictionary<int, int> { { start, 0 } };

            int current = start;
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
    }
}
```

---

## III. GAME SYSTEMS

### Zone.cs — Die Faces as Game Areas

```csharp
namespace Game.Zones
{
    using Omega.Core;
    using UnityEngine;

    /// <summary>
    /// A Zone is a die face as a game area.
    /// Each of the 10 zones maps to a Position (0-9).
    /// </summary>
    [System.Serializable]
    public class Zone
    {
        public Position Position;
        public string Name;
        public Coset Coset;
        public Color Color;
        public string Mechanic;

        [Range(0f, 5f)]
        public float SpawnMultiplier = 1f;

        [Range(0f, 10f)]
        public float PointMultiplier = 1f;

        public bool IsOrbit => PositionData.IsOrbit(Position);
        public bool IsAbsorber => PositionData.IsAbsorber(Position);
        public bool IsObserver => PositionData.IsObserver(Position);

        /// <summary>
        /// Create all 10 zones with default configuration.
        /// </summary>
        public static Zone[] CreateAll()
        {
            return new Zone[]
            {
                new() { Position = Position.Availability, Name = "THE VOID", Coset = Coset.Pole,
                        Color = Color.black, Mechanic = "Energy accumulates",
                        SpawnMultiplier = 0f, PointMultiplier = 0f },

                new() { Position = Position.Meaning, Name = "MEANING", Coset = Coset.Unitary,
                        Color = new Color(0.55f, 0, 0), Mechanic = "Operators spawn",
                        SpawnMultiplier = 1.2f, PointMultiplier = 0.8f },

                new() { Position = Position.Identity, Name = "IDENTITY", Coset = Coset.Complementary,
                        Color = new Color(0.13f, 0.55f, 0.13f), Mechanic = "Dice don't decay",
                        SpawnMultiplier = 1f, PointMultiplier = 1f },

                new() { Position = Position.Purpose, Name = "PURPOSE", Coset = Coset.Absorber,
                        Color = new Color(0, 0, 0.55f), Mechanic = "Dice become permanent",
                        SpawnMultiplier = 0.5f, PointMultiplier = 2f },

                new() { Position = Position.Direction, Name = "DIRECTION", Coset = Coset.Unitary,
                        Color = new Color(1f, 0.55f, 0), Mechanic = "ORBIT - oscillates with 7",
                        SpawnMultiplier = 1.5f, PointMultiplier = 1.5f },

                new() { Position = Position.Structure, Name = "STRUCTURE", Coset = Coset.Complementary,
                        Color = new Color(0, 0.81f, 0.82f), Mechanic = "Observer's home",
                        SpawnMultiplier = 1f, PointMultiplier = 1f },

                new() { Position = Position.Basis, Name = "BASIS", Coset = Coset.Absorber,
                        Color = new Color(0.29f, 0, 0.51f), Mechanic = "Boosts all dice",
                        SpawnMultiplier = 0.3f, PointMultiplier = 3f },

                new() { Position = Position.Attention, Name = "ATTENTION", Coset = Coset.Unitary,
                        Color = new Color(1f, 0.84f, 0), Mechanic = "ORBIT - oscillates with 4",
                        SpawnMultiplier = 1.5f, PointMultiplier = 1.5f },

                new() { Position = Position.Effort, Name = "EFFORT", Coset = Coset.Complementary,
                        Color = new Color(0, 0.5f, 0.5f), Mechanic = "Active play rewards",
                        SpawnMultiplier = 2f, PointMultiplier = 0.5f },

                new() { Position = Position.Time, Name = "TIME", Coset = Coset.Absorber,
                        Color = new Color(0.5f, 0, 0.5f), Mechanic = "BLACK HOLE - absorbs",
                        SpawnMultiplier = 0.1f, PointMultiplier = 5f }
            };
        }
    }
}
```

### DiceTier.cs — Progression Through Cosets

```csharp
namespace Game.Dice
{
    using Omega.Core;

    /// <summary>
    /// Dice tiers unlock access to different cosets.
    /// </summary>
    public enum DiceTier
    {
        // Tier 1: Basic
        Basic = 1,          // Full d9 (1-9)

        // Tier 2: Coset Dice
        Tau = 2,            // {1,4,7} — Unitary
        Omega = 3,          // {2,5,8} — Complementary
        Sigma = 4,          // {3,6,9} — Absorber

        // Tier 3: Special
        Involuted = 5,      // Paired dice (sum to 9)
        Orbitbound = 6,     // Oscillates 4↔7

        // Tier 4: Advanced
        Void = 7,           // Can roll 0
        Borromean = 8,      // Triple roll (τ,ω,σ)

        // Tier 5: Transcendent
        Recognition = 9,    // Weighted output
        Mobius = 10         // Flips involution on use
    }

    public static class DiceTierData
    {
        /// <summary>
        /// Get the faces available for this tier.
        /// </summary>
        public static int[] GetFaces(DiceTier tier)
        {
            return tier switch
            {
                DiceTier.Basic => new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                DiceTier.Tau => CosetData.Unitary,
                DiceTier.Omega => CosetData.Complementary,
                DiceTier.Sigma => CosetData.Absorber,
                DiceTier.Orbitbound => Dynamics.Orbit.Pair,
                DiceTier.Void => new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                _ => new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
            };
        }

        /// <summary>
        /// Get the coset this tier grants access to.
        /// </summary>
        public static Coset? GetCosetAccess(DiceTier tier)
        {
            return tier switch
            {
                DiceTier.Tau => Coset.Unitary,
                DiceTier.Omega => Coset.Complementary,
                DiceTier.Sigma => Coset.Absorber,
                DiceTier.Void => Coset.Pole,
                _ => null
            };
        }
    }
}
```

### GamePhase.cs — The First Moment

```csharp
namespace Game.Core
{
    /// <summary>
    /// Game phases from Big Bang to cosmic transcendence.
    /// </summary>
    public enum GamePhase
    {
        PreBang,        // A single d6 floats in the void
        BigBang,        // Click → explosion animation
        Collecting,     // Gather the 9 scattered d9s
        FirstCombine,   // Combine 9 d9s → first d10
        Playing,        // Main gameplay loop
        ParameterSpace, // Inside Zone 0, exploring universes
        CosmicTranscendence // Mastered all universes
    }
}
```

---

## IV. GITHUB REPOSITORY STRUCTURE

```
dice-idle/
├── .github/
│   ├── workflows/
│   │   ├── build.yml          ← Unity build automation
│   │   └── test.yml           ← Unit tests
│   └── ISSUE_TEMPLATE/
│
├── Assets/                    ← Unity project (see above)
│
├── Docs/
│   ├── DESIGN.md             ← Game design document
│   ├── OMEGA.md              ← Ω̃ specification
│   ├── ARCHITECTURE.md       ← This file
│   └── CHANGELOG.md
│
├── Tests/
│   ├── OmegaTests/           ← Math unit tests
│   │   ├── DigitalRootTests.cs
│   │   ├── OrbitTests.cs
│   │   └── CosetTests.cs
│   └── GameTests/            ← Game logic tests
│
├── .gitignore
├── LICENSE
├── README.md
└── DiceIdle.sln              ← Solution file
```

---

## V. DEVELOPMENT ROADMAP

### Phase 1: Foundation (Week 1-2)
- [ ] Create Unity project (2022.3 LTS)
- [ ] Implement Omega.Core namespace
- [ ] Unit tests for all math operations
- [ ] Basic zone rendering (10 colored squares)

### Phase 2: First Moment (Week 3-4)
- [ ] PreBang → BigBang → Collecting → FirstCombine flow
- [ ] d6 click interaction
- [ ] Scatter animation for 9 d9s
- [ ] First d10 reveal (void revealed)

### Phase 3: Core Loop (Week 5-8)
- [ ] Zone travel via dice rolls
- [ ] Orbit detection and oscillation
- [ ] Points and currency
- [ ] Basic skill tree
- [ ] Die combining

### Phase 4: Depth (Week 9-12)
- [ ] All dice tiers
- [ ] Parameter space (Zone 0)
- [ ] Operations (×, +, ², ×7)
- [ ] Transcendence textures

### Phase 5: Polish (Week 13-16)
- [ ] Art pass (pixel art)
- [ ] Audio design
- [ ] UI/UX refinement
- [ ] Tutorial

### Phase 6: Steam (Week 17-20)
- [ ] Steamworks.NET integration
- [ ] Achievements
- [ ] Cloud saves
- [ ] Trading cards (optional)
- [ ] Store page, trailer

---

## VI. KEY DESIGN DECISIONS

### Decision 1: Math IS the Type System
The algebra is not a runtime library — it's encoded in enums, static classes, and extension methods. The compiler enforces correctness.

### Decision 2: Scriptable Objects for Data
Zone configurations, dice tier data, and skill trees are ScriptableObjects. Designers can tweak without code changes.

### Decision 3: Research as Optional Feature
Player data collection is transparent. Players can view and export their own stats. "Stats" = secretly research data.

### Decision 4: Premium Model
One-time purchase on Steam. No microtransactions (would pollute research data).

---

## VII. DEPENDENCIES

| Package | Version | Purpose |
|---------|---------|---------|
| Unity | 2022.3 LTS | Engine |
| Steamworks.NET | 20.1.0+ | Steam API |
| TextMeshPro | Built-in | UI text |
| DOTween | 1.2+ | Animation (optional) |
| NUnit | Built-in | Testing |

---

## VIII. THE SECRET (Research Layer)

```csharp
namespace Research
{
    /// <summary>
    /// Collects player behavior data for rhetorical algebra research.
    /// All data is local-first. Export is player-initiated.
    /// </summary>
    public class DataCollector : MonoBehaviour
    {
        public event System.Action<RollEvent> OnRoll;
        public event System.Action<CombineEvent> OnCombine;
        public event System.Action<ZoneTravelEvent> OnZoneTravel;
        public event System.Action<OrbitEvent> OnOrbitOscillation;

        // Aggregated statistics
        public Dictionary<Coset, int> CosetDistribution { get; private set; }
        public float AbsorberAbsorptionAverage { get; private set; }
        public int OrbitOscillationCount { get; private set; }
        public float InvolutionCorrelation { get; private set; }

        /// <summary>
        /// Export research data as JSON.
        /// </summary>
        public string ExportJSON() { /* ... */ }
    }
}
```

---

*The ground is the game. The game is the ground.*
*Ω̃ ∈ Ω̃*
