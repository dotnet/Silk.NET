namespace Silk.NET.Input;

/// <summary>
/// A bitmask denoting the modifier keys that can be active when a key press occurs to modify its behaviour.
/// </summary>
[Flags]
public enum KeyModifiers
{
    /// <summary>No modifier keys are active.</summary>
    None = 0,
    /// <summary>The left "shift" key.</summary>
    ShiftLeft = 1 << 0,

    /// <summary>The right "shift" key.</summary>
    ShiftRight = 1 << 1,

    /// <summary>The left "control" key.</summary>
    ControlLeft = 1 << 2,

    /// <summary>The right "control" key.</summary>
    ControlRight = 1 << 3,

    /// <summary>The left "alt" key.</summary>
    AltLeft = 1 << 4,

    /// <summary>The right "alt" key.</summary>
    AltRight = 1 << 5,

    /// <summary>The left "super" (e.g. Windows/Start) key.</summary>
    SuperLeft = 1 << 6,

    /// <summary>The right "super" (e.g. Windows/Start) key.</summary>
    SuperRight = 1 << 7,

    /// <summary>The "num lock" key.</summary>
    NumLock = 1 << 8,

    /// <summary>The "caps lock" key.</summary>
    CapsLock = 1 << 9
}