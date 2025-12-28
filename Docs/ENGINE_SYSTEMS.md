# DIEDLE Engine Recommendations

**Goal**: Deepen gameplay systems using proven structural patterns.
**Approach**: Player-facing mechanics first, math as invisible infrastructure.

---

## System 1: Essence + Power (Die Identity)

### Player Experience
Every die has two independent properties:
- **Essence** — What kind of die (determines behavior, coset affinity)
- **Power** — How strong (determines multipliers, tier)

This lets players chase "high power" OR "right essence" — two axes of progression.

### Gameplay
| Essence | Color | Zone Affinity | Behavior |
|---------|-------|---------------|----------|
| Operator | Red/Orange | 1, 4, 7 | Triggers abilities |
| State | Green/Cyan | 2, 5, 8 | Persists, observes |
| Anchor | Blue/Purple | 3, 6, 9 | Locks, absorbs |

Power levels: 0 (base) → 1 → 2 → 3... (exponential scaling)

### Combination Rules
When combining dice:
- **Essences interact** — Operator + Operator = Operator, State + State = Operator, etc.
- **Powers stack** — Power 2 + Power 1 = Power 3

This creates strategic combining: "Do I want the essence or the power boost?"

### Engine Implementation
```csharp
// Source/Omega/Core/DieIdentity.cs
public struct DieIdentity {
    public Essence Essence;   // τ, ω, σ mapped to enum
    public int Power;         // 0, 1, 2, 3...

    public int Value => EssenceBase * (1 << Power);
}

public enum Essence { Operator, State, Anchor }

// Combination table (hidden from player, feels intuitive)
// Op × Op = Op, Op × St = St, St × St = Op, Anchor × Any = Anchor
```

---

## System 2: Zone States (Stable / Unstable / Rhythmic)

### Player Experience
Zones aren't static — they have **states** that change how dice behave:

| State | Visual | Dice Behavior | Player Strategy |
|-------|--------|---------------|-----------------|
| **Unstable** | Flickering, particles | Dice keep transforming | Chase evolving dice |
| **Stable** | Solid, glowing | Dice can reach final form | Farm perfect dice |
| **Rhythmic** | Pulsing, oscillating | Dice bounce between values | Time your collects |

### Zone Assignments
| Zone | Name | Default State | Why |
|------|------|---------------|-----|
| 0 | THE VOID | Unstable | Energy never settles |
| 1-3 | Core Zones | Unstable | Standard play |
| 4 | DIRECTION | Rhythmic | Orbits with zone 7 |
| 5 | STRUCTURE | Stable | Observer's base |
| 7 | ATTENTION | Rhythmic | Orbits with zone 4 |
| 9 | TIME | Stable | Endgame, dice complete |

### Gameplay Impact
- **Unstable zones**: High variance, exciting, unpredictable rewards
- **Stable zones**: Consistent farming, completionist goals
- **Rhythmic zones**: Skill-based timing, active play rewarded

### Engine Implementation
```csharp
// Source/Omega/Game/ZoneState.cs
public enum ZoneState { Unstable, Stable, Rhythmic }

public class Zone {
    public ZoneState State { get; private set; }

    public void ProcessDie(Die die) {
        switch (State) {
            case ZoneState.Unstable:
                die.Evolve();  // keeps changing
                break;
            case ZoneState.Stable:
                die.Crystallize();  // can reach final form
                break;
            case ZoneState.Rhythmic:
                die.Oscillate();  // bounded cycling
                break;
        }
    }
}
```

---

## System 3: Echo Dice (Cross-Layer Memory)

### Player Experience
When you descend to a new layer (prestige), you leave behind **Echoes** — ghostly dice that remember your previous run.

- Echoes appear faintly in the new layer
- Combining a current die with its Echo creates a **Bridge Die**
- Bridge Dice are powerful and can affect BOTH layers

### Gameplay Loop
```
Layer 0: Build up dice → Descend to Layer 1
Layer 1: See Echoes of Layer 0 dice
         Combine current + Echo → Bridge Die
         Bridge Die boosts BOTH layers
```

### Why It Works
- Creates nostalgia for past runs
- Rewards long-term strategy (what Echoes do I want?)
- Bridge Dice are the prestige multiplier — earned, not given

### Engine Implementation
```csharp
// Source/Omega/Dynamics/EchoSystem.cs
public class Echo {
    public DieIdentity Original;
    public int SourceLayer;
    public float Opacity;  // fades over time
}

public class BridgeDie : Die {
    public int[] AffectedLayers;

    public static BridgeDie Create(Die current, Echo echo) {
        return new BridgeDie {
            Identity = CombineIdentities(current.Identity, echo.Original),
            AffectedLayers = new[] { echo.SourceLayer, CurrentLayer }
        };
    }
}
```

---

## System 4: Milestone Gates (Natural Unlocks)

### Player Experience
New mechanics unlock at specific collection milestones — feels earned, not arbitrary.

| Milestone | Unlock | Player Sees |
|-----------|--------|-------------|
| 3 dice collected | Even-value dice spawn | "New dice types appearing!" |
| 4 dice collected | Anchor essence unlocked | "Purple dice discovered!" |
| 5 dice collected | Power Level 2 possible | "Dice growing stronger!" |
| 8 dice collected | Zone 7 accessible | "New zone revealed!" |
| 10 dice collected | Rhythmic mechanics | "Zones pulsing..." |

### Why These Numbers
The unlock sequence follows a natural pattern that "feels right" because it's structurally grounded. Players don't see the math — they just feel the pacing.

### Engine Implementation
```csharp
// Source/Omega/Game/ProgressionSystem.cs
public class MilestoneTracker {
    private static readonly (int threshold, string unlock)[] Milestones = {
        (3, "EvenDice"),
        (4, "AnchorEssence"),
        (5, "Power2"),
        (8, "Zone7"),
        (10, "RhythmicZones")
    };

    public void OnDiceCollected(int total) {
        foreach (var (threshold, unlock) in Milestones) {
            if (total >= threshold && !IsUnlocked(unlock)) {
                Unlock(unlock);
                ShowUnlockFanfare(unlock);
            }
        }
    }
}
```

---

## System 5: Realms (Prestige Worlds)

### Player Experience
After mastering the base game, players unlock **new Realms** with the same rules but different feel:

| Realm | Visual Theme | Gameplay Feel |
|-------|--------------|---------------|
| **Golden** (base) | Warm, classic | Balanced, familiar |
| **Silver** | Cool, metallic | Faster growth, bigger numbers |
| **Bronze** | Earthy, ancient | Slower but more powerful peaks |
| **Crystal** | Geometric, periodic | Bounded, puzzle-like |

### Realm Differences
Same coset structure, same zone layout — but:
- **Spawn rates** differ (Silver spawns faster)
- **Value scaling** differs (Bronze has bigger jumps)
- **Visual feedback** differs (Crystal has sharp edges)

### Prestige Flow
```
Master Golden Realm → Unlock Silver
Master Silver Realm → Unlock Bronze
Master Bronze Realm → Unlock Crystal
All Realms: Cross-realm Echoes become possible
```

### Engine Implementation
```csharp
// Source/Omega/Game/RealmConfig.cs
public class Realm {
    public string Name;
    public float SpawnRate;
    public float ValueScale;
    public Color PrimaryColor;
    public AnimationCurve GrowthCurve;
}

// Realms are ScriptableObjects — designers tune without code
[CreateAssetMenu(menuName = "Diedle/Realm")]
public class RealmData : ScriptableObject {
    public Realm Config;
}
```

---

## System 6: The Tide (Global Rhythm)

### Player Experience
A 24-beat **Tide** cycle affects the entire game:
- Visual indicator shows current tide position
- Different beats favor different Essences
- Skilled players learn the rhythm

### Tide Phases
```
Beats 1-9:   Operator tide (red glow) — Operator dice spawn more
Beats 10-18: State tide (green glow) — State dice spawn more
Beats 19-24: Anchor tide (purple glow) — Anchor dice spawn more
```

The ratio is 9:9:6 — Anchors are rarer, making them valuable.

### Gameplay Impact
- **Casual players**: Ignore it, still works fine
- **Active players**: Time big rolls to favorable tides
- **Expert players**: Plan entire strategies around tide cycles

### Engine Implementation
```csharp
// Source/Omega/Game/TideSystem.cs
public class TideSystem : MonoBehaviour {
    private const int PERIOD = 24;
    private int currentBeat;

    // 9 Operator, 9 State, 6 Anchor
    private static readonly Essence[] TideSequence = GenerateTideSequence();

    public Essence CurrentTide => TideSequence[currentBeat % PERIOD];

    public float GetSpawnBonus(Essence essence) {
        return essence == CurrentTide ? 1.5f : 1.0f;
    }

    void Update() {
        // Advance beat based on game time
    }
}
```

---

## Engine Architecture

### Current Structure
```
Assets/Source/Omega/
├── Core/           # Math primitives
├── Dynamics/       # Orbit, Absorption
└── Game/           # Zone, Tier, Phase
```

### Proposed Structure (System-Oriented)
```
Assets/Source/Omega/
├── Core/           # DieIdentity, Essence, Power (unchanged)
├── Systems/
│   ├── DieSystem.cs        # Spawning, combining, destruction
│   ├── ZoneSystem.cs       # Zone states, transitions
│   ├── ProgressionSystem.cs # Milestones, unlocks
│   ├── EchoSystem.cs       # Cross-layer memory
│   ├── RealmSystem.cs      # World switching, prestige
│   └── TideSystem.cs       # Global spawn rhythm
├── Data/
│   ├── RealmData.asset
│   ├── MilestoneData.asset
│   └── TideData.asset
└── UI/
    ├── TideIndicator.cs
    ├── EssenceDisplay.cs
    └── PowerMeter.cs
```

---

## Implementation Roadmap

### Sprint 1: Core Identity
- [ ] Refactor Die to use `DieIdentity` (Essence + Power)
- [ ] Update combination logic (Essence interaction + Power stacking)
- [ ] Add UI for Essence colors and Power level

### Sprint 2: Zone States
- [ ] Add `ZoneState` enum to Zone class
- [ ] Implement Unstable/Stable/Rhythmic behaviors
- [ ] Add zone state visuals (particles, glow, pulse)

### Sprint 3: Progression
- [ ] Create MilestoneTracker
- [ ] Define unlock sequence (3, 4, 5, 8, 10...)
- [ ] Add unlock fanfare UI

### Sprint 4: Depth Systems
- [ ] Implement Echo spawning on layer descent
- [ ] Create BridgeDie combination mechanic
- [ ] Add Tide system with 24-beat cycle

### Sprint 5: Realms
- [ ] Create RealmData ScriptableObjects
- [ ] Implement realm switching on prestige
- [ ] Add cross-realm Echo mechanics

---

## Summary

| System | Player Sees | Engine Provides |
|--------|-------------|-----------------|
| Essence + Power | Colored dice with levels | Two-axis progression |
| Zone States | Zones feel different | Varied farming strategies |
| Echo Dice | Ghosts of past runs | Prestige continuity |
| Milestones | Natural unlock pacing | Structured progression |
| Realms | New worlds to master | Prestige content |
| Tide | Global rhythm indicator | Strategic timing layer |

The math is infrastructure. Players feel depth without seeing equations.

---

*For Diedle repo: Docs/ENGINE_SYSTEMS.md*
