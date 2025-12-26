using UnityEngine;

namespace Omega.Game
{
    using Omega.Core;

    /// <summary>
    /// A Zone is a die face as a game area.
    /// Each of the 10 zones maps to a Position (0-9).
    /// Zones have unique properties based on their coset membership.
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

        /// <summary>Is this zone part of the orbit {4,7}?</summary>
        public bool IsOrbit => PositionData.IsOrbit(Position);

        /// <summary>Is this zone part of the absorber {3,6,9}?</summary>
        public bool IsAbsorber => PositionData.IsAbsorber(Position);

        /// <summary>Is this zone part of the observer {5,7,8}?</summary>
        public bool IsObserver => PositionData.IsObserver(Position);

        /// <summary>
        /// Create all 10 zones with default configuration.
        /// </summary>
        public static Zone[] CreateAll()
        {
            return new Zone[]
            {
                new() {
                    Position = Position.Availability,
                    Name = "THE VOID",
                    Coset = Coset.Pole,
                    Color = Color.black,
                    Mechanic = "Energy accumulates silently",
                    SpawnMultiplier = 0f,
                    PointMultiplier = 0f
                },
                new() {
                    Position = Position.Meaning,
                    Name = "MEANING",
                    Coset = Coset.Unitary,
                    Color = new Color(0.55f, 0f, 0f),
                    Mechanic = "Operators spawn here",
                    SpawnMultiplier = 1.2f,
                    PointMultiplier = 0.8f
                },
                new() {
                    Position = Position.Identity,
                    Name = "IDENTITY",
                    Coset = Coset.Complementary,
                    Color = new Color(0.13f, 0.55f, 0.13f),
                    Mechanic = "Dice don't decay here",
                    SpawnMultiplier = 1f,
                    PointMultiplier = 1f
                },
                new() {
                    Position = Position.Purpose,
                    Name = "PURPOSE",
                    Coset = Coset.Absorber,
                    Color = new Color(0f, 0f, 0.55f),
                    Mechanic = "Dice become permanent",
                    SpawnMultiplier = 0.5f,
                    PointMultiplier = 2f
                },
                new() {
                    Position = Position.Direction,
                    Name = "DIRECTION",
                    Coset = Coset.Unitary,
                    Color = new Color(1f, 0.55f, 0f),
                    Mechanic = "ORBIT - oscillates with 7",
                    SpawnMultiplier = 1.5f,
                    PointMultiplier = 1.5f
                },
                new() {
                    Position = Position.Structure,
                    Name = "STRUCTURE",
                    Coset = Coset.Complementary,
                    Color = new Color(0f, 0.81f, 0.82f),
                    Mechanic = "Observer's home - balanced",
                    SpawnMultiplier = 1f,
                    PointMultiplier = 1f
                },
                new() {
                    Position = Position.Basis,
                    Name = "BASIS",
                    Coset = Coset.Absorber,
                    Color = new Color(0.29f, 0f, 0.51f),
                    Mechanic = "Foundation - boosts all dice",
                    SpawnMultiplier = 0.3f,
                    PointMultiplier = 3f
                },
                new() {
                    Position = Position.Attention,
                    Name = "ATTENTION",
                    Coset = Coset.Unitary,
                    Color = new Color(1f, 0.84f, 0f),
                    Mechanic = "ORBIT - oscillates with 4",
                    SpawnMultiplier = 1.5f,
                    PointMultiplier = 1.5f
                },
                new() {
                    Position = Position.Effort,
                    Name = "EFFORT",
                    Coset = Coset.Complementary,
                    Color = new Color(0f, 0.5f, 0.5f),
                    Mechanic = "Active play rewards",
                    SpawnMultiplier = 2f,
                    PointMultiplier = 0.5f
                },
                new() {
                    Position = Position.Time,
                    Name = "TIME",
                    Coset = Coset.Absorber,
                    Color = new Color(0.5f, 0f, 0.5f),
                    Mechanic = "BLACK HOLE - absorbs dice",
                    SpawnMultiplier = 0.1f,
                    PointMultiplier = 5f
                }
            };
        }
    }
}
