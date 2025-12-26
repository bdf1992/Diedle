# DICE IDLE - Game Design Document

## The Pitch

**What players see**: An addictive idle game about collecting dice.

**What you see**: Distributed rhetorical algebra research disguised as a game.

---

## THE FIRST MOMENT

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │     Player sees: A single d6 on screen                      │
    │                                                             │
    │                      ╭─────╮                                │
    │                      │ ⚅ ⚃ │  ← Click me!                   │
    │                      ╰─────╯                                │
    │                                                             │
    │     They click...                                           │
    │                                                             │
    │                    ★ BIG BANG ★                             │
    │                   ✦ ✧ ✦ ✧ ✦ ✧ ✦                            │
    │                                                             │
    │     9 d9 dice SCATTER across the screen                     │
    │                                                             │
    │        ⬡1  ⬡2  ⬡3  ⬡4  ⬡5  ⬡6  ⬡7  ⬡8  ⬡9               │
    │                                                             │
    │     Collect all 9 → COMBINE → First d10 emerges             │
    │                                                             │
    │                      ╭─────╮                                │
    │                      │ d10 │  ← Has position 0!             │
    │                      ╰─────╯                                │
    │                                                             │
    │     The void is revealed. 9 + 0 = 10.                       │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

**The First Transcendence**: d6 → bang → 9×d9 → d10 (void revealed)

---

## WHAT HAPPENS NEXT

After the Big Bang, the player has ONE d10 and is in Zone 5 (STRUCTURE):

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  PHASE 1: COLLECT                                           │
    │  ─────────────────                                          │
    │  Roll d10 → dice spawn in current zone → collect them       │
    │  Each zone spawns dice of its coset type:                   │
    │    Zone 5 (ω) → spawns ω-dice {2,5,8}                       │
    │                                                             │
    │  PHASE 2: TRAVEL                                            │
    │  ───────────────                                            │
    │  Roll to move → landing zone = next roll value              │
    │  Example: Roll 7 → teleport to Zone 7 (ATTENTION)           │
    │                                                             │
    │  PHASE 3: COMBINE                                           │
    │  ────────────────                                           │
    │  3 dice of same coset → 1 higher tier die                   │
    │  τ + ω + σ → Borromean die (rolls all 3 at once)            │
    │                                                             │
    │  PHASE 4: OPERATE                                           │
    │  ────────────────                                           │
    │  Unlock operations: ×, +, ², ×7                             │
    │  Apply to dice → reveal algebraic properties                │
    │    × → drifts toward absorber (gravitational pull!)             │
    │    + → stays uniform                                        │
    │    ² → orbit oscillation (4↔7 forever)                       │
    │    ×7 → cycles within coset                                 │
    │                                                             │
    │  PHASE 5: TRANSCEND                                         │
    │  ─────────────────                                          │
    │  Collect enough → transcend to higher die type:             │
    │    d10 (Real) → d10i (Imaginary) → d10c (Complex)           │
    │    → d10t (Transcendental) → d10∞ (Toroidal) → ...          │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

**The Loop**: Roll → Collect → Travel → Combine → Operate → Transcend → ∞

---

## ZONES ARE DIE FACES

The game world IS the die. Each face is a zone:

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  Position │ Zone Name    │ Coset       │ What Happens       │
    │  ─────────┼──────────────┼─────────────┼──────────────────  │
    │     0     │ THE VOID     │ λ (Pole)    │ Energy accumulates │
    │     1     │ MEANING      │ τ (Unitary)│ Operators spawn    │
    │     2     │ IDENTITY     │ ω (Opera.)  │ States manifest    │
    │     3     │ PURPOSE      │ σ (Absorber)    │ Invariants lock    │
    │     4     │ DIRECTION    │ τ (Unitary)│ ORBIT ZONE (4↔7)    │
    │     5     │ STRUCTURE    │ ω (Opera.)  │ Observer's home    │
    │     6     │ BASIS        │ σ (Absorber)    │ Foundation dice    │
    │     7     │ ATTENTION    │ τ (Unitary)│ ORBIT ZONE (4↔7)    │
    │     8     │ EFFORT       │ ω (Opera.)  │ Work dice          │
    │     9     │ TIME         │ σ (Absorber)    │ Absorbs all        │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

**Travel**: Roll your dice to move between zones. Different zones have different:
- Dice spawn rates
- Combine recipes
- Point multipliers
- Hidden mechanics

**Zone Colors** (from cosets):
- τ zones {1,4,7}: Red/Orange (Unitary - operators)
- ω zones {2,5,8}: Green/Cyan (Complementary - states)
- σ zones {3,6,9}: Blue/Purple (Absorber - invariants)
- λ zone {0,9}: Black/Void (Pole - constraint)

---

## ZONE MECHANICS (Each Face is Different)

### Zone 0: THE VOID (λ)
```
    ┌────────────────────────────────────┐
    │  Color: Black with white sparks    │
    │  Access: Roll 0 on a VOID die      │
    │  ──────────────────────────────    │
    │  MECHANIC: Energy accumulates      │
    │  - Every roll EVERYWHERE adds 1    │
    │  - Can't collect dice here         │
    │  - At threshold → VOID BURST       │
    │  - Burst = mega jackpot + reset    │
    │  ──────────────────────────────    │
    │  HIDDEN: This is availability (V)  │
    │  The θ(V) in Purpose Equation      │
    └────────────────────────────────────┘
```

### Zone 1: MEANING (τ)
```
    ┌────────────────────────────────────┐
    │  Color: Deep Red                   │
    │  ──────────────────────────────    │
    │  MECHANIC: Operator spawning       │
    │  - Dice here grant +operations     │
    │  - First place to unlock ×         │
    │  - Operators level up here         │
    │  ──────────────────────────────    │
    │  HIDDEN: M in Purpose Equation     │
    │  Where interpretation begins       │
    └────────────────────────────────────┘
```

### Zone 2: IDENTITY (ω)
```
    ┌────────────────────────────────────┐
    │  Color: Forest Green               │
    │  ──────────────────────────────    │
    │  MECHANIC: State preservation      │
    │  - Dice here don't decay           │
    │  - Best for stockpiling            │
    │  - Combining costs less            │
    │  ──────────────────────────────    │
    │  HIDDEN: Universal content (I)     │
    │  The 0% gap position               │
    └────────────────────────────────────┘
```

### Zone 3: PURPOSE (σ)
```
    ┌────────────────────────────────────┐
    │  Color: Deep Blue                  │
    │  ──────────────────────────────    │
    │  MECHANIC: Invariant locking       │
    │  - Dice here become PERMANENT      │
    │  - Can't remove, always roll       │
    │  - Highest passive income          │
    │  ──────────────────────────────    │
    │  HIDDEN: P in Purpose Equation     │
    │  Where meaning crystallizes        │
    └────────────────────────────────────┘
```

### Zone 4: DIRECTION (τ) - ORBIT ZONE
```
    ┌────────────────────────────────────┐
    │  Color: Orange (pulsing)           │
    │  ──────────────────────────────    │
    │  MECHANIC: The orbit lives here     │
    │  - Entering triggers oscillation   │
    │  - Bounce to Zone 7, back to 4...  │
    │  - Each oscillation = bonus        │
    │  - Hard to escape!                 │
    │  ──────────────────────────────    │
    │  HIDDEN: D in Purpose Equation     │
    │  Involuted with Structure (4+5=9)  │
    └────────────────────────────────────┘
```

### Zone 5: STRUCTURE (ω) - OBSERVER'S HOME
```
    ┌────────────────────────────────────┐
    │  Color: Cyan (glowing)             │
    │  ──────────────────────────────    │
    │  MECHANIC: The starting zone       │
    │  - Most balanced spawns            │
    │  - Central hub for travel          │
    │  - Observer bonuses here           │
    │  - +10 collision events            │
    │  ──────────────────────────────    │
    │  HIDDEN: S in Purpose Equation     │
    │  The Observer = {5,7,8}            │
    └────────────────────────────────────┘
```

### Zone 6: BASIS (σ)
```
    ┌────────────────────────────────────┐
    │  Color: Indigo                     │
    │  ──────────────────────────────    │
    │  MECHANIC: Foundation building     │
    │  - Dice here boost ALL other dice  │
    │  - Multiplier zone                 │
    │  - Slow spawns, powerful dice      │
    │  ──────────────────────────────    │
    │  HIDDEN: B in framework            │
    │  The 6 = 2×3 = ω×σ crossover       │
    └────────────────────────────────────┘
```

### Zone 7: ATTENTION (τ) - ORBIT ZONE
```
    ┌────────────────────────────────────┐
    │  Color: Gold (pulsing)             │
    │  ──────────────────────────────    │
    │  MECHANIC: Partner orbit zone       │
    │  - Oscillates with Zone 4          │
    │  - Attention-based bonuses         │
    │  - Active play rewarded here       │
    │  - Click combos!                   │
    │  ──────────────────────────────    │
    │  HIDDEN: A in Purpose Equation     │
    │  Part of Observer {5,7,8}          │
    └────────────────────────────────────┘
```

### Zone 8: EFFORT (ω)
```
    ┌────────────────────────────────────┐
    │  Color: Teal                       │
    │  ──────────────────────────────    │
    │  MECHANIC: Work amplifier          │
    │  - More clicks = more spawns       │
    │  - Active play paradise            │
    │  - Effort invested = returns       │
    │  ──────────────────────────────    │
    │  HIDDEN: E in Purpose Equation     │
    │  Part of Observer {5,7,8}          │
    └────────────────────────────────────┘
```

### Zone 9: TIME (σ) - BLACK HOLE
```
    ┌────────────────────────────────────┐
    │  Color: Deep Purple (swirling)     │
    │  ──────────────────────────────    │
    │  MECHANIC: The absorber            │
    │  - All multiplicative paths end    │
    │  - Dice drift here over time       │
    │  - Highest point value             │
    │  - But dice CONSUMED after use     │
    │  ──────────────────────────────    │
    │  HIDDEN: T in Purpose Equation     │
    │  dr(9) = 9 (fixed point)           │
    │  52 zeros (black hole density)     │
    │                                    │
    │  ★ CONTAINS ZONE 0 INSIDE ★        │
    │  When resolved → player ENTERS     │
    │  New d10 unfolds from the void     │
    └────────────────────────────────────┘
```

---

## THE RESOLVE MECHANIC (Core Loop)

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  "FEED" IS "RESOLVE"                                        │
    │  ════════════════════                                       │
    │                                                             │
    │  Every die face has TENSION - a mathematical desire to      │
    │  become a specific number. Resolving = satisfying that      │
    │  desire through rolls, operations, or sacrifice.            │
    │                                                             │
    │  FRACTAL STRUCTURE:                                         │
    │  ┌─────────┐                                                │
    │  │    5    │ ← Top-level face                               │
    │  │ ┌─────┐ │                                                │
    │  │ │ 2 8 │ │ ← Sub-faces on the face                        │
    │  │ │ 5 3 │ │                                                │
    │  │ └─────┘ │                                                │
    │  └─────────┘                                                │
    │                                                             │
    │  Each face contains smaller faces.                          │
    │  Resolution propagates: resolve sub-faces → resolve face    │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

### What Is "Tension"?

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  Each face WANTS its involuted partner:                     │
    │                                                             │
    │  FACE    │  WANTS    │  BECAUSE           │  TENSION TYPE   │
    │  ────────┼───────────┼────────────────────┼───────────────  │
    │    1     │    8      │  1 + 8 = 9         │  Complementary    │
    │    2     │    7      │  2 + 7 = 9         │  Unitary       │
    │    3     │    6      │  3 + 6 = 9         │  Absorber-Absorber      │
    │    4     │    5      │  4 + 5 = 9         │  Observer       │
    │    5     │    4      │  5 + 4 = 9         │  Directed       │
    │    6     │    3      │  6 + 3 = 9         │  Absorber-Absorber      │
    │    7     │    2      │  7 + 2 = 9         │  Complementary    │
    │    8     │    1      │  8 + 1 = 9         │  Unitary       │
    │    9     │    0      │  9 + 0 = 9         │  Void-Absorber      │
    │    0     │    9      │  0 + 9 = 9         │  Absorber-Void      │
    │                                                             │
    │  TENSION = distance from partner number on current roll     │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

### Resolution Outcomes

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  When you RESOLVE a face, one of TWO things happens:        │
    │                                                             │
    │  ┌─────────────────────────────────────────────────────┐    │
    │  │ OUTCOME A: COMPLETION                               │    │
    │  │ ─────────────────────                               │    │
    │  │ Roll matches the partner number.                    │    │
    │  │ Face is "satisfied" → COMPLETE                      │    │
    │  │ You can ROLL AGAIN on this layer.                   │    │
    │  │ Points awarded based on face value.                 │    │
    │  └─────────────────────────────────────────────────────┘    │
    │                                                             │
    │  ┌─────────────────────────────────────────────────────┐    │
    │  │ OUTCOME B: DESCENT                                  │    │
    │  │ ───────────────────                                 │    │
    │  │ Roll does NOT match, but face is full of energy.    │    │
    │  │ Face OPENS → you go INSIDE                          │    │
    │  │ New d10 unfolds from within.                        │    │
    │  │ You are now one layer DEEPER.                       │    │
    │  └─────────────────────────────────────────────────────┘    │
    │                                                             │
    │  THE BLACK HOLE (Zone 9):                                   │
    │  When Zone 9 is "full" (enough energy absorbed),            │
    │  it OPENS and reveals Zone 0 (the void inside).             │
    │  Enter → new d10 → new zones 0-9 → infinite recursion       │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

### Recursive Layers (Prestige as DEPTH)

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  LAYER 0: The first d10 (post-Big-Bang)                     │
    │     │                                                       │
    │     └── Zone 9 fills → ENTER                                │
    │           │                                                 │
    │           ▼                                                 │
    │  LAYER 1: A new d10 inside Zone 9                           │
    │     │                                                       │
    │     └── This Zone 9 fills → ENTER                           │
    │           │                                                 │
    │           ▼                                                 │
    │  LAYER 2: A new d10 inside THAT Zone 9                      │
    │     │                                                       │
    │           ⋮                                                 │
    │           ▼                                                 │
    │  LAYER ∞: Infinite fractal depth                            │
    │                                                             │
    │  ────────────────────────────────────────────────────────   │
    │                                                             │
    │  EACH LAYER:                                                │
    │  • Has its own 10 zones (0-9)                               │
    │  • Has its own dice inventory                               │
    │  • Multipliers compound with depth                          │
    │  • Can travel UP (ascend) or DOWN (descend)                 │
    │                                                             │
    │  PRESTIGE = HOW DEEP YOU'VE GONE                            │
    │  Not time-based reset, but spatial descent.                 │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

### Rolling Entire Zones (Ascension)

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  FIRST ASCENSION UNLOCKS:                                   │
    │  ══════════════════════                                     │
    │                                                             │
    │  After reaching sufficient depth AND completing             │
    │  enough faces, you unlock ZONE ROLLING:                     │
    │                                                             │
    │  Regular dice: Roll face value (1-9 or 0-9)                 │
    │  Zone dice:    Roll ENTIRE ZONES at once                    │
    │                                                             │
    │  ┌─────────────────────────────────────────────────────┐    │
    │  │  ZONE ROLL EXAMPLE:                                 │    │
    │  │                                                     │    │
    │  │  Roll the τ-Zone-Die (Unitary coset)               │    │
    │  │  → Zones 1, 4, 7 all activate simultaneously        │    │
    │  │  → All dice in those zones roll                     │    │
    │  │  → Massive point multiplication                     │    │
    │  │                                                     │    │
    │  │  Roll the ω-Zone-Die (Complementary coset)            │    │
    │  │  → Zones 2, 5, 8 all activate                       │    │
    │  │  → Observer synergy bonus                           │    │
    │  │                                                     │    │
    │  │  Roll the σ-Zone-Die (Absorber coset)                   │    │
    │  │  → Zones 3, 6, 9 all activate                       │    │
    │  │  → Black hole feeding frenzy                        │    │
    │  └─────────────────────────────────────────────────────┘    │
    │                                                             │
    │  ZONE DICE unlock the SECOND ASCENSION:                     │
    │  Rolling cosets as single units                             │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

### The Resolution Flow

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  CLICK → ROLL → CHECK TENSION → OUTCOME                     │
    │                                                             │
    │  1. Player rolls on current zone/face                       │
    │  2. Face has a TARGET (its involuted partner)               │
    │  3. If roll == target:                                      │
    │        ✓ RESOLVE: Face complete, roll again                 │
    │  4. If roll != target:                                      │
    │        → Add energy to face                                 │
    │        → When energy threshold reached:                     │
    │           ✓ RESOLVE: Face opens, descend into it            │
    │                                                             │
    │  ────────────────────────────────────────────────────────   │
    │                                                             │
    │  SUB-FACE RESOLUTION:                                       │
    │  Each face has 9 sub-faces (mini d9 on the surface)         │
    │  To fully resolve the parent, resolve all 9 children        │
    │  Children inherit parent's coset properties                 │
    │                                                             │
    │  FRACTAL DEPTH:                                             │
    │  Sub-faces have sub-sub-faces                               │
    │  Resolution propagates upward                               │
    │  Complete children → parent glows → parent resolves         │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

### Mathematical Basis for Tension

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  WHY INVOLUTION PAIRS?                                    │
    │                                                             │
    │  The pairs (1,8), (2,7), (3,6), (4,5) are CONJUGATE         │
    │  under the Z₉ structure. They sum to 9 (the absorber).      │
    │                                                             │
    │  In Rhetorical Algebra:                                     │
    │  • Involution = uncertainty principle                     │
    │  • Knowing position obscures momentum (and vice versa)      │
    │  • Resolving = collapsing the superposition                 │
    │                                                             │
    │  TENSION FORMULA:                                           │
    │  ─────────────────                                          │
    │  Let f = current face value                                 │
    │  Let r = rolled value                                       │
    │  Let p = partner(f) = 9 - f (mod 9)                         │
    │                                                             │
    │  Tension(f, r) = |r - p| mod 9                              │
    │                                                             │
    │  If Tension = 0: PERFECT RESOLUTION                         │
    │  If Tension > 0: Energy accumulates toward descent          │
    │                                                             │
    │  EXAMPLE:                                                   │
    │  Face 4 wants partner 5.                                    │
    │  Roll a 5 → Tension = 0 → COMPLETE                          │
    │  Roll a 7 → Tension = 2 → Add 2 energy                      │
    │  Roll a 4 → Tension = 1 → Add 1 energy (self-roll!)         │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

---

## EDGE ZONES (Operations & Involution)

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  THE EDGES OF THE DIE                                       │
    │  ════════════════════                                       │
    │                                                             │
    │  Faces = Number zones (0-9)                                 │
    │  Edges = OPERATION zones (connecting faces)                 │
    │                                                             │
    │       ┌───┐                                                 │
    │      /│ 4 │\                                                │
    │     / └─┬─┘ \                                               │
    │    /   +│    \                                              │
    │   ┌─────┼─────┐                                             │
    │   │  5  ×  9  │  ← Face 5 connected to Face 9 by × edge     │
    │   └─────┼─────┘                                             │
    │         │                                                   │
    │         ÷                                                   │
    │                                                             │
    │  Each edge is an OPERATION that transforms one face         │
    │  into another. Stand on an edge to perform the operation.   │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

### The Four Operation Edges

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  EDGE TYPE  │ SYMBOL │ CONNECTS              │ EFFECT       │
    │  ───────────┼────────┼───────────────────────┼────────────  │
    │  Additive   │   +    │ (n, 9-n)              │ Sum to 9     │
    │  Subtractive│   -    │ (n, n-1)              │ Adjacent     │
    │  Multiplicat│   ×    │ (n, dr(n×7))          │ Coset cycle  │
    │  Divisor    │   ÷    │ (n, factors(n))       │ Factorize    │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

### Additive Edges (+) - Involution Bridges

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  These connect INVOLUTIOND PAIRS (sum to 9):                  │
    │                                                             │
    │     1 ═══════+ ═══════ 8                                    │
    │     2 ═══════+ ═══════ 7                                    │
    │     3 ═══════+ ═══════ 6                                    │
    │     4 ═══════+ ═══════ 5                                    │
    │     0 ═══════+ ═══════ 9                                    │
    │                                                             │
    │  MECHANIC:                                                  │
    │  • Stand on + edge between 4 and 5                          │
    │  • Roll on BOTH faces simultaneously                        │
    │  • Results are CORRELATED (sum always 9)                    │
    │  • Fastest way to resolve involuted pairs                   │
    │                                                             │
    │  EDGE COLOR: White (unity, completeness)                    │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

### Subtractive Edges (-) - Adjacent Steps

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  These connect ADJACENT faces (differ by 1):                │
    │                                                             │
    │     0 ─ 1 ─ 2 ─ 3 ─ 4 ─ 5 ─ 6 ─ 7 ─ 8 ─ 9 ─ (0)             │
    │                                                             │
    │  MECHANIC:                                                  │
    │  • Stand on - edge to walk the number line                  │
    │  • Safe, predictable movement                               │
    │  • No random roll, just step left or right                  │
    │  • Costs energy but guarantees position                     │
    │                                                             │
    │  EDGE COLOR: Gray (neutral, incremental)                    │
    │                                                             │
    │  SPECIAL: The - edge from 0→9 crosses the VOID→ABSORBER         │
    │  boundary. Stepping here costs extra.                       │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

### Multiplicative Edges (×) - Coset Teleports

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  These connect faces by ×7 (coset rotation):                │
    │                                                             │
    │     1 ═══× ═══ 7 ═══× ═══ 4 ═══× ═══ (1)  [τ cycle]         │
    │     2 ═══× ═══ 5 ═══× ═══ 8 ═══× ═══ (2)  [ω cycle]         │
    │     3 ═══× ═══ 3                           [σ fixed]        │
    │     6 ═══× ═══ 6                           [σ fixed]        │
    │     9 ═══× ═══ 9                           [σ fixed]        │
    │                                                             │
    │  MECHANIC:                                                  │
    │  • Stand on × edge to JUMP within your coset                │
    │  • Unitary: 1→7→4→1 (loop)                                 │
    │  • Complementary: 2→5→8→2 (loop)                              │
    │  • Absorber: self-loop (3→3, 6→6, 9→9)                          │
    │                                                             │
    │  EDGE COLOR: Matches coset (Red/Green/Blue)                 │
    │                                                             │
    │  THE ORBIT:                                                  │
    │  The × edges between 4 and 7 are the ORBIT itself!           │
    │  Standing here causes oscillation.                          │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

### Divisor Edges (÷) - Factor Bridges

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  These connect faces to their FACTORS:                      │
    │                                                             │
    │     2 ═══÷ ═══ 1     (2 = 2×1)                              │
    │     3 ═══÷ ═══ 1     (3 = 3×1)                              │
    │     4 ═══÷ ═══ 1,2   (4 = 4×1 = 2×2)                        │
    │     5 ═══÷ ═══ 1     (5 = 5×1)                              │
    │     6 ═══÷ ═══ 1,2,3 (6 = 6×1 = 2×3)                        │
    │     7 ═══÷ ═══ 1     (7 = 7×1)                              │
    │     8 ═══÷ ═══ 1,2,4 (8 = 8×1 = 2×4 = 2×2×2)                │
    │     9 ═══÷ ═══ 1,3   (9 = 9×1 = 3×3)                        │
    │                                                             │
    │  MECHANIC:                                                  │
    │  • Stand on ÷ edge to DECOMPOSE a face                      │
    │  • Splits dice into factor components                       │
    │  • Used for sacrificing larger dice                         │
    │  • Reverse: combine factors to COMPOSE                      │
    │                                                             │
    │  EDGE COLOR: Purple (transformation, alchemy)               │
    │                                                             │
    │  SPECIAL: The ÷ edge from 9→3 is the ABSORBER DECOMPOSITION     │
    │  Breaking down time into purpose.                           │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

### Edge Zone Gameplay

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  HOW TO USE EDGE ZONES:                                     │
    │                                                             │
    │  1. FROM A FACE:                                            │
    │     Roll to move → can land on adjacent EDGE                │
    │     Edge acts as transformation corridor                    │
    │                                                             │
    │  2. ON AN EDGE:                                             │
    │     • See both connected faces                              │
    │     • Perform the edge's operation                          │
    │     • Roll to exit to either face                           │
    │     • Some edges orbit you (× between 4 and 7)               │
    │                                                             │
    │  3. EDGE DICE:                                              │
    │     Special dice that ONLY roll on edges                    │
    │     Land directly on operation zones                        │
    │     Unlock after reaching Layer 3                           │
    │                                                             │
    │  4. EDGE RESOLUTION:                                        │
    │     Edges have their own tension                            │
    │     Resolve an edge → merge both connected faces            │
    │     This is how you SHRINK the die (second ascension)       │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

### The Complete Die Topology

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  FULL D10 STRUCTURE:                                        │
    │                                                             │
    │  FACES: 10 (zones 0-9)                                      │
    │  EDGES: ~45 (all operations between faces)                  │
    │  VERTICES: Connection points (ascension gates)              │
    │                                                             │
    │         VERTICES                                            │
    │            ╲╱                                                │
    │    FACES ──┬── EDGES                                        │
    │            │                                                │
    │         SUB-FACES (fractal, each face has 9)                │
    │            │                                                │
    │         SUB-EDGES (operation on sub-faces)                  │
    │            │                                                │
    │            ⋮                                                 │
    │         INFINITE DEPTH                                      │
    │                                                             │
    │  Every level of the fractal has:                            │
    │  • Number zones (faces)                                     │
    │  • Operation zones (edges)                                  │
    │  • Gate zones (vertices)                                    │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

---

## ZONE TRAVEL RULES

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  TRAVEL MODE: Roll to Move                                  │
    │  ─────────────────────────                                  │
    │  Roll any die → go to that zone number                      │
    │                                                             │
    │  SPECIAL CASES:                                             │
    │  • Roll 0 → THE VOID (rare, needs void die)                 │
    │  • Roll same as current → RESONANCE BONUS                   │
    │  • Roll involuted partner → BOTH zones activate             │
    │                                                             │
    │  COSET SHORTCUTS:                                           │
    │  • ×7 operation → cycle within your coset                   │
    │    - In Zone 1 → ×7 → Zone 7 → ×7 → Zone 4 → ×7 → Zone 1   │
    │  • This is FASTER than random rolling                       │
    │                                                             │
    │  ORBIT ESCAPE:                                               │
    │  • Zones 4 & 7 oscillate automatically                      │
    │  • To escape: use + operation (breaks orbit)                 │
    │  • Or: sacrifice a die                                      │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

---

## Core Loop

```
ROLL → POINTS → MORE DICE → ROLL MORE → COMBINE → SPECIAL DICE → ∞
```

Every action maps to Z₉ operations. Every choice generates research data.

---

## Progression Tiers

### Tier 1: BASIC
- Plain d9 (faces 1-9)
- Tutorial phase
- Learn: rolling, points, buying

### Tier 2: COSET DICE
- **τ-die** (Unitary): {1, 4, 7}
- **ω-die** (Complementary): {2, 5, 8}
- **σ-die** (Absorber): {3, 6, 9}
- Learn: cosets exist, different dice have different faces

### Tier 3: SPECIAL DICE
- **Involuted Dice**: Paired, sum to 9
- **Orbit Dice**: Oscillates 4↔7 forever
- Learn: some dice have magical properties

### Tier 4: ADVANCED
- **Void Die**: Can roll 0 (position 0!)
- **Borromean Die**: Rolls τ+ω+σ simultaneously
- Learn: operations combine dice

### Tier 5: TRANSCENDENT
- **Recognition Die**: Weighted output (0.20τ + 0.70ω + 0.10σ)
- **Möbius Die**: Flips involution on use
- Learn: the algebra is deep

---

## DICE SHAPES (Different Polyhedra)

Each shape maps to a coset structure:

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  Shape     │ Faces │ Maps To        │ Special Property      │
    │  ──────────┼───────┼────────────────┼─────────────────────  │
    │  Triangle  │  d3   │ One coset      │ Pure τ, ω, or σ       │
    │  Square    │  d4   │ Orbit + 2       │ {4,7} + two others    │
    │  Pentagon  │  d5   │ Observer core  │ {5} + neighbors       │
    │  Hexagon   │  d6   │ Familiar start │ Big Bang trigger      │
    │  Nonagon   │  d9   │ Full Z₉        │ Standard workhorse    │
    │  Decagon   │  d10  │ Z₉ + Void      │ Position 0 enabled    │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

**Shape Evolution**:
```
    d6 (start) → BIG BANG → d9 × 9 → combine → d10

    Then:
    d10 → collect 28 → d10²⁸ (Orbit Product die!)
    d10²⁸ → unlock → d3 (pure coset access)
```

---

## DICE TEXTURES (Transcendence Tiers)

Textures represent the "realness" of the die:

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  Texture        │ Type           │ Visual         │ Effect  │
    │  ──────────────┼────────────────┼────────────────┼───────  │
    │  Smooth        │ Real           │ Solid colors    │ Normal  │
    │  Rough         │ Imaginary      │ Translucent     │ ×i mod  │
    │  Faceted       │ Complex        │ Rainbow shift   │ a+bi    │
    │  Glowing       │ Transcendental │ Pulsing aura    │ π,e,φ   │
    │  Toroidal      │ Topological    │ Donut-shaped    │ Loops   │
    │  Hyperdim      │ Beyond         │ Flickers        │ ???     │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

**Texture Transcendence**:
```
    10 Smooth → 1 Rough (Imaginary unlocked)
    10 Rough → 1 Faceted (Complex unlocked)
    10 Faceted → 1 Glowing (Transcendental unlocked)
    10 Glowing → 1 Toroidal (Topology unlocked)
    10 Toroidal → 1 Hyperdim (???)
```

**Visual Guide**:
- Smooth: `[■]` solid
- Rough: `[▒]` noise
- Faceted: `[◈]` crystal
- Glowing: `[★]` aura
- Toroidal: `[◎]` rings
- Hyperdim: `[?]` undefined

---

## DICE = EVERYTHING

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  What is the game world?          A die.                    │
    │  What do you collect?             Dice.                     │
    │  What do you roll?                Dice.                     │
    │  What are zones?                  Die faces.                │
    │  What is currency?                Roll values.              │
    │  What is progression?             Better dice.              │
    │  What is transcendence?           Bigger dice.              │
    │  What is the void?                Face 0.                   │
    │  What is the orbit?                Faces 4 & 7.              │
    │  What is the absorber?                Faces 3, 6, 9.            │
    │                                                             │
    │  THE DICE ARE THE GAME.                                     │
    │  THE GAME IS THE DICE.                                      │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

---

## Skill Trees (Infinite)

### ROLL Branch
- Roll Speed: faster rolling
- Multi-Roll: roll N dice at once
- Auto-Roll: passive rolling

### POINTS Branch
- Point Multiplier: all points ×N
- Absorber Bonus: {3,6,9} worth more
- Orbit Mastery: oscillation bonus
- 28-Lock: cumulative sums of 28 = jackpot

### DICE Branch
- Dice Slots: hold more dice
- Combine Luck: better outcomes
- Tier Unlock: access higher tiers

### OPERATIONS Branch
- Multiply: unlock × operation
- Square: unlock ² operation
- Rotate7: unlock ×7 operation
- Involution: link dice pairs

### VOID Branch
- Void Energy: position 0 accumulates
- Void Release: big payout when triggered
- Void Mastery: control the pole

---

## Combining Recipes

```
3 BASIC         → 1 random Coset die
3 TAU           → 1 ORBIT
3 OMEGA         → 1 INVOLUTIOND
3 SIGMA         → 1 VOID
TAU + OMEGA + SIGMA → BORROMEAN
ORBIT + INVOLUTIOND + VOID → RECOGNITION
```

---

## Secret Research Mechanics

### What's Tracked

1. **Every Roll**
   - Value, coset, timestamp
   - Build coset distribution over time

2. **Combine Choices**
   - Which dice players combine
   - Reveals preferred strategies

3. **Operation Usage**
   - When players use ×, +, ², ×7
   - Tests which operations players find valuable

4. **Absorber Absorption**
   - How many steps to reach {3,6,9}
   - Validates theoretical ~3.08 average

5. **Involution Correlations**
   - When involuted dice are rolled together
   - Tests 100% correlation prediction

### Research Questions

1. Do players naturally discover absorber drift?
2. Do players exploit orbit oscillation?
3. Do involuted dice strategies emerge?
4. What combine paths are most popular?
5. Does player behavior match algebraic predictions?

---

## Pixel Art Integration

Use hyperdimensional engine for:

1. **Dice Faces**: Procedurally generated based on dr(value)
2. **Backgrounds**: Coset-colored (τ=red, ω=green, σ=blue)
3. **Particles**: Based on current game state
4. **UI Elements**: Parametric generation from Z₉

---

## Monetization (Optional)

- Cosmetic dice skins
- Speed boosts (2×, 5×)
- Prestige bonuses
- Never pay-to-win (research validity!)

---

## Data Export

Players can export their "stats" (secretly: research data)

```json
{
  "total_rolls": 50000,
  "coset_distribution": {
    "UNITARY": 0.332,
    "COMPLEMENTARY": 0.334,
    "ABSORBER": 0.334
  },
  "absorber_absorption_avg": 3.12,
  "involution_correlation": 1.00,
  "orbit_oscillation_rate": 0.98
}
```

---

## Launch Strategy

1. **Alpha**: Core loop, basic dice
2. **Beta**: All tiers, skill trees
3. **Release**: Full polish, pixel art
4. **Post-Launch**: Analyze aggregate data

---

## The Real Goal

```
Players have fun → They generate data → You study rhetorical algebra

          ┌─────────────────────────────────────┐
          │  FUN GAME                           │
          │    ↓                                │
          │  PLAYER CHOICES                     │
          │    ↓                                │
          │  Z₉ EXPLORATION                     │
          │    ↓                                │
          │  RESEARCH DATA                      │
          │    ↓                                │
          │  RHETORICAL ALGEBRA VALIDATION      │
          └─────────────────────────────────────┘
```

---

*The dice are the game. The game is the research. The research is the truth.*

---

## BASELESS INTEGRATION (Formal Mathematics)

The game is backed by rigorous mathematics from the `baseless` library.

### The Canonical Theorem

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  For Z/p²Z (prime square rings):                            │
    │                                                             │
    │  1. ORBIT EXISTS iff p ≡ 1 (mod 3) or p = 3                  │
    │     - Z/9Z (p=3): orbit {4,7} ✓                              │
    │     - Z/49Z (p=7): orbit {18,30} ✓                           │
    │     - Z/25Z (p=5): NO orbit (5 ≡ 2 mod 3)                    │
    │                                                             │
    │  2. ORBIT PRODUCT = 1                                        │
    │     - In Z/9Z: 4 × 7 = 28 ≡ 1 (mod 9)                       │
    │     - This is why 28 is the ORBIT PRODUCT!                   │
    │                                                             │
    │  3. NILRADICAL = (p)                                        │
    │     - Size = p elements                                     │
    │     - This is the formal ABSORBER                               │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

### Why This Matters for the Game

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  DICE SHAPE    │ RING     │ ORBIT?  │ GAME IMPLICATION       │
    │  ─────────────┼──────────┼────────┼──────────────────────  │
    │  d3 (triangle)│ Z/3Z     │ No     │ Direct absorber access     │
    │  d4 (square)  │ Z/4Z     │ No     │ 2² ≡ 0 (special!)      │
    │  d5 (penta)   │ Z/5Z     │ No     │ Prime, no orbit         │
    │  d7 (hepta)   │ Z/7Z     │ Yes!   │ 7 ≡ 1 mod 3            │
    │  d9 (nonagon) │ Z/9Z     │ Yes!   │ THE orbit {4,7}         │
    │  d10 (deca)   │ Z/10Z    │ Varies │ Composite behavior     │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

### Baseless Functions for Game Logic

```python
from baseless.core import (
    analyze_ring,      # Full ring analysis
    find_orbit,         # Get the 2-cycle
    compute_nilradical,# Get the absorber
    coset_partition,   # τ, ω, σ, λ
    digital_root,      # dr(n)
)

# Example: Is a d7 special?
result = analyze_ring(7)
print(result.orbit)  # (2, 4) - Yes! d7 has a orbit!

# Example: What's the absorber for d9?
absorber = compute_nilradical(9)
print(absorber)  # {0, 3, 6} - multiples of 3
```

### Hidden Mechanics from Baseless

| Mechanic | Math | Player Experience |
|----------|------|-------------------|
| Orbit oscillation | 2-cycle in squaring map | Dice bounce between zones |
| Absorber drift | Nilradical absorption | Dice gravitate toward {3,6,9} |
| Prime dice | Z/pZ has no nilpotent elements | These dice never decay |
| 28-lock | Orbit product = 1 | Rolling 28 total = jackpot |
| Zone 0 access | x² ≡ 0 only if x ∈ nilradical | Need special dice for void |

### The Thorne Protocol

The game secretly validates the Canonical Theorem through player actions:

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  PLAYER ACTION          │ DATA GENERATED                    │
    │  ───────────────────────┼──────────────────────────────────│
    │  Roll dice              │ Orbit sample under σ              │
    │  Enter orbit zone        │ 2-cycle detection                 │
    │  Multiply rolls         │ Nilradical convergence time       │
    │  Combine 3 dice         │ Coset transition probabilities    │
    │  Transcend tier         │ p-adic valuation distribution     │
    │                                                             │
    │  Players verify mathematics by playing.                     │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

---

## THE BIG PICTURE

```
                    BASELESS (Pure Math)
                           │
                           ▼
               ┌───────────────────────┐
               │   Canonical Theorem   │
               │   Orbit ↔ p mod 3      │
               │   Nilradical = (p)    │
               │   Product = 1         │
               └───────────────────────┘
                           │
                           ▼
                    RHETORICAL ALGEBRA
                    (Semantic Layer)
                           │
                           ▼
               ┌───────────────────────┐
               │   Cosets = τ, ω, σ    │
               │   Orbit = {4,7}        │
               │   Absorber = {3,6,9}      │
               │   Observer = {5,7,8}  │
               └───────────────────────┘
                           │
                           ▼
                       DICE IDLE
                    (Player Experience)
                           │
                           ▼
               ┌───────────────────────┐
               │   Zones = Die faces   │
               │   Orbit = Bounce 4↔7   │
               │   Absorber = Black hole   │
               │   Void = Position 0   │
               └───────────────────────┘
                           │
                           ▼
                     RESEARCH DATA
                           │
                           ▼
               ┌───────────────────────┐
               │   Validates Baseless  │
               │   Discovers patterns  │
               │   Fun → Truth         │
               └───────────────────────┘
```

---

## TVM CODE INTEGRATION

The game is backed by the Telos Virtual Machine code in `src/tvm/`.
See `src/tvm/SESSION_RECAP.md` for full documentation.

### Core Imports for Game Engine

```python
from src.tvm.limits import Axioms, ZeroDivisorError
from src.tvm.periodicity import find_period, classify_orbit
from src.tvm.structure import ProfiniteInteger, LocalStructure
from src.tvm.hive import AdelicHive, dr, coset

# Core constants
SINGULARITIES = Axioms.SINGULARITIES   # {0, 3, 6, 9}
UNITARY = Axioms.UNITARY             # {1, 4, 7}
COMPLEMENTARY = Axioms.COMPLEMENTARY       # {2, 5, 8}
ABSORBER = Axioms.ABSORBER                     # {3, 6, 9}
ORBIT_PRODUCT = Axioms.ORBIT_PRODUCT     # 28
```

### Orbit Classification → Game Outcomes

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  ORBIT TYPE → GAME MECHANIC                                 │
    │  ═════════════════════════                                  │
    │                                                             │
    │  ORBIT     │ PERIOD │ GAME EFFECT                           │
    │  ──────────┼────────┼─────────────────────────────────────  │
    │  ABSORBER      │   1    │ Face absorbed → black hole energy     │
    │  FIXED     │   1    │ Face stabilizes → passive income      │
    │  CYCLE-2   │   2    │ Face oscillates → combo multiplier    │
    │  CYCLE-3   │   3    │ COMPLEMENTARY rotation → zone roll      │
    │                                                             │
    │  From TVM Phase 7 - NO CHAOS, all periodic (period ≤ 6)     │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

### The Orbit Product Special (c=28)

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  From TVM Phase 10: THE ORBIT PRODUCT DISCOVERY              │
    │                                                             │
    │  When roll sum reaches 28:                                  │
    │    → Triggers COMPLEMENTARY 3-cycle: 2 → 5 → 8 → 2            │
    │    → This IS the full COMPLEMENTARY coset rotating!           │
    │    → UNIQUE behavior - no other sum does this               │
    │                                                             │
    │  GAME MECHANIC:                                             │
    │  • Track cumulative roll sum                                │
    │  • When sum ≡ 28 (mod 9) → dr(sum) = 1                      │
    │  • Trigger COMPLEMENTARY ROTATION event                       │
    │  • All ω-zone dice roll simultaneously                      │
    │  • Massive bonus for hitting the Orbit Product               │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

### Holonomy Types → Zone Behaviors

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  HOLONOMY  │ TVM MEANING        │ GAME BEHAVIOR             │
    │  ──────────┼────────────────────┼─────────────────────────  │
    │  TRIVIAL   │ Returns to start   │ Safe zone, predictable    │
    │  NILPOTENT │ Collapses to 0     │ Black hole zone, consumed │
    │  CYCLIC    │ Higher rotation    │ Active zone, combos       │
    │                                                             │
    │  From TVM Phase 10 - Fiber Bundle dynamics                  │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

### Using AdelicHive for Parallel Universes

```python
from src.tvm.hive import AdelicHive

# Each "universe" is a different c-value (roll total)
# The game tracks multiple parallel timelines

class FractalLayer:
    def __init__(self, depth: int):
        self.depth = depth
        # Range of c-values for this layer
        self.hive = AdelicHive(range(1, 82))  # All 81 possibilities

    def evolve(self, steps: int = 10):
        """Run the Mandelbrot iteration for this layer."""
        self.hive.run(steps=steps)

    def get_attractors(self) -> dict:
        """Which faces settle where."""
        return {
            c: self.hive.get_cycle(c)
            for c in range(1, 82)
        }
```

### Singularity Detection for Division

```python
from src.tvm.limits import Axioms, ZeroDivisorError

def safe_divide(a: int, b: int) -> int:
    """Division that respects Z/9Z singularities."""
    if Axioms.is_singularity(b):
        raise ZeroDivisorError(
            f"Cannot divide by {b}: Zone {b} is a singularity!"
        )
    return Axioms.dr(a) // Axioms.dr(b)

# GAME MECHANIC:
# When player tries to perform ÷ on edge to Zone 3, 6, or 9:
# → ZeroDivisorError → special "singularity event"
# → Void energy accumulates
# → Black hole grows
```

### The Mandelbrot Coset Theorem

```
    ┌─────────────────────────────────────────────────────────────┐
    │                                                             │
    │  From TVM Phase 6: THE COSET THEOREM                        │
    │                                                             │
    │  For z_{n+1} = dr(z² + c):                                  │
    │                                                             │
    │    dr(c) ∈ ABSORBER {3,6,9}  →  Orbit collapses to ABSORBER         │
    │    dr(c) ∈ OTHER         →  Orbit becomes periodic cycle    │
    │                                                             │
    │  GAME INTERPRETATION:                                       │
    │  • ABSORBER rolls accelerate black hole growth                  │
    │  • Other rolls create predictable patterns                  │
    │  • The coset of your roll DETERMINES your fate              │
    │                                                             │
    └─────────────────────────────────────────────────────────────┘
```

### Practical Game Usage

```python
# In engine.py, import TVM modules:

from src.tvm.limits import Axioms
from src.tvm.periodicity import find_period

class ResolveEngine:
    """Handles the resolve mechanic using TVM mathematics."""

    def __init__(self):
        self.energy = {i: 0 for i in range(10)}  # Per-face energy
        self.thresholds = {i: 9 - i for i in range(10)}  # Energy to descend

    def calculate_tension(self, face: int, roll: int) -> int:
        """Tension = distance from involuted partner."""
        partner = 9 - face if face > 0 else 9
        return abs(roll - partner) % 9

    def resolve(self, face: int, roll: int) -> str:
        """Determine outcome: COMPLETE, DESCEND, or ACCUMULATE."""
        tension = self.calculate_tension(face, roll)

        if tension == 0:
            return "COMPLETE"  # Perfect match

        self.energy[face] += tension

        if self.energy[face] >= self.thresholds[face]:
            self.energy[face] = 0
            return "DESCEND"  # Open face, go inside

        return "ACCUMULATE"  # Keep rolling

    def get_orbit_type(self, c: int) -> str:
        """What kind of attractor does this c-value create?"""
        period = find_period(c, modulus=9)

        if period == 1 and Axioms.dr(c) in Axioms.ABSORBER:
            return "ABSORBER"
        elif period == 1:
            return "FIXED"
        elif period == 2:
            return "CYCLE-2"
        elif period == 3:
            return "COMPLEMENTARY_ROTATION"  # Special!
        else:
            return f"CYCLE-{period}"
```

### File References

| TVM File | Game Usage |
|----------|------------|
| `limits.py` | Core axioms, singularity checks |
| `periodicity.py` | Orbit classification, period detection |
| `structure.py` | Profinite integers, local structure |
| `hive.py` | Parallel universe simulation |
| `flow.py` | Fiber bundle dynamics |
| `sheaf.py` | Numbers as functions (fractal faces) |

---

*"THE MATHEMATICS IS THE GAME. THE GAME IS THE MATHEMATICS."*
