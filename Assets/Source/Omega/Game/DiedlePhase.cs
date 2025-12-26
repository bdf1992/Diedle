namespace Omega.Game
{
    /// <summary>
    /// Game phases for Diedle - from Big Bang to Cosmic Transcendence.
    ///
    /// THE FIRST MOMENT:
    /// Player clicks d6 -> BIG BANG -> 9 d9s scatter -> collect -> combine -> d10 emerges
    /// The void (position 0) is revealed: 9 + 0 = 10
    /// </summary>
    public enum DiedlePhase
    {
        /// <summary>A single d6 floats in the void. Click to begin.</summary>
        PreBang = 0,

        /// <summary>The explosion animation. d6 shatters.</summary>
        BigBang = 1,

        /// <summary>Gather the 9 scattered d9s across the screen.</summary>
        Collecting = 2,

        /// <summary>Combine 9 d9s into the first d10. The void is revealed.</summary>
        FirstCombine = 3,

        /// <summary>Main gameplay loop. Roll, travel, collect, combine, transcend.</summary>
        Playing = 4,

        /// <summary>Inside Zone 0, exploring the parameter space universes.</summary>
        ParameterSpace = 5,

        /// <summary>Mastered all 9 universes. Ultimate achievement.</summary>
        CosmicTranscendence = 6
    }
}
