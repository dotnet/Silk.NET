using System.Numerics;

namespace Silk.NET.Input;

/// <summary>
/// Contains user input received from an <see cref="IMouse"/>.
/// </summary>
public class MouseState(
    ButtonReadOnlyList<PointerButton> buttons,
    InputReadOnlyList<TargetPoint> points,
    Vector2 wheelPosition,
    float gripPressure = 0
) : PointerState(buttons, points, gripPressure)
{
    /// <summary>
    /// Clones a <see cref="MouseState"/> object.
    /// </summary>
    /// <param name="other">The object to clone.</param>
    /// <remarks>
    /// This object will not receive any changes from the object it was created from as they are distinct clones.
    /// </remarks>
    public MouseState(MouseState other)
        : this(
            new ButtonReadOnlyList<PointerButton>(other.Buttons),
            new InputReadOnlyList<TargetPoint>(other.Points),
            other.WheelPosition,
            other.GripPressure
        ) { }

    /// <summary>
    /// Gets the current position of the scroll wheel in number of ratchets.
    /// </summary>
    public Vector2 WheelPosition { get; internal set; } = wheelPosition;
}
