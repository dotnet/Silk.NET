using System.Numerics;

namespace Silk.NET.Input;

/// <summary>
/// Contains user input received from an <see cref="IMouse"/>.
/// </summary>
public class MouseState : PointerState
{
    /// <summary>
    /// Gets the current position of the scroll wheel in number of ratchets.
    /// </summary>
    public Vector2 WheelPosition { get; }
}