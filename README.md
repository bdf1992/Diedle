# Diedle

**An idle dice game where the dice are the world.**

Built on the Ω̃ mathematical substrate — the self-referential ground that connects shapes, integers, and rules.

---

## The First Moment

```
    ╭─────╮
    │ ⚅ ⚃ │  ← Click me!
    ╰─────╯

    ★ BIG BANG ★

    9 d9 dice SCATTER across the screen

    ⬡1  ⬡2  ⬡3  ⬡4  ⬡5  ⬡6  ⬡7  ⬡8  ⬡9

    Collect all 9 → COMBINE → First d10 emerges

    The void is revealed. 9 + 0 = 10.
```

---

## The Game

**Zones are die faces.** Each face is a game area with unique mechanics.

| Position | Zone | Coset | Mechanic |
|----------|------|-------|----------|
| 0 | THE VOID | λ (Pole) | Energy accumulates |
| 1 | MEANING | τ (Unitary) | Operators spawn |
| 2 | IDENTITY | ω (Complementary) | Dice don't decay |
| 3 | PURPOSE | σ (Absorber) | Dice become permanent |
| 4 | DIRECTION | τ (Unitary) | **ORBIT** - oscillates with 7 |
| 5 | STRUCTURE | ω (Complementary) | Observer's home |
| 6 | BASIS | σ (Absorber) | Foundation - boosts all |
| 7 | ATTENTION | τ (Unitary) | **ORBIT** - oscillates with 4 |
| 8 | EFFORT | ω (Complementary) | Active play rewards |
| 9 | TIME | σ (Absorber) | **BLACK HOLE** - absorbs all |

**The Loop**: Roll → Collect → Travel → Combine → Operate → Transcend → ∞

---

## The Substrate: Ω̃ = ⨁ₙ Hₙ

Everything follows the same rules.

**Core Operations**:
- `dr(n)` — Digital root, maps any integer to {1..9}
- `inv(d)` — Involution, pairs that sum to 9: (1,8), (2,7), (3,6), (4,5)
- `a ⊗ b` — Contraction, `dr(a × b)`
- `×7` — Rotation within cosets

**The Four Cosets**:
- **λ** (Pole): {0} — Constraint, singularity
- **τ** (Unitary): {1,4,7} — Operators, agency
- **ω** (Complementary): {2,5,8} — States, observation
- **σ** (Absorber): {3,6,9} — Invariants, absorption

**The Orbit**: {4,7} oscillates forever under squaring. 4² = 16 → dr(16) = 7. 7² = 49 → dr(49) = 4.

---

## Project Structure

```
Diedle/
├── Assets/
│   ├── Source/
│   │   ├── Omega/              ← THE GROUND
│   │   │   ├── Core/           ← DigitalRoot, Coset, Position, Level
│   │   │   ├── Dynamics/       ← Orbit, Absorption
│   │   │   └── Game/           ← DiedlePhase, Zone
│   │   ├── Base/               ← Infrastructure (from UnityProjectBase)
│   │   │   ├── Controllers/    ← Game, Screen, Scene, Camera
│   │   │   ├── Managers/       ← Audio, Currency, Input
│   │   │   ├── Handlers/       ← Data, PopUp, Tutorial
│   │   │   └── IOC/            ← Dependency injection
│   │   └── ...
│   └── ...
├── Docs/
│   ├── DESIGN.md               ← Full game design document
│   ├── ARCHITECTURE.md         ← Unity/C# architecture
│   └── OMEGA.md                ← Mathematical substrate spec
└── ...
```

---

## Development

**Requirements**:
- Unity 2022.3 LTS or later
- DOTween (included)

**Getting Started**:
1. Clone this repository
2. Open in Unity Hub
3. Open `Assets/Scenes/Main.unity`

---

## Documentation

- [DESIGN.md](Docs/DESIGN.md) — Complete game design document
- [ARCHITECTURE.md](Docs/ARCHITECTURE.md) — Unity/C# architecture with Ω̃ integration
- [OMEGA.md](Docs/OMEGA.md) — The mathematical substrate

---

## License

MIT License — see [LICENSE](LICENSE)

---

*The dice are the game. The game is the dice.*
*Ω̃ ∈ Ω̃*
