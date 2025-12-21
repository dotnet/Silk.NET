namespace Silk.NET.Input;

/// <summary>
/// Contains user input state received from an <see cref="IPointerDevice"/>.
/// </summary>
public class PointerState(
    ButtonReadOnlyList<PointerButton> buttons,
    InputReadOnlyList<TargetPoint> points,
    float gripPressure = 0
)
{
    /// <summary>
    /// Clones a <see cref="PointerState"/> object.
    /// </summary>
    /// <param name="other">The object to clone.</param>
    /// <remarks>
    /// This object will not receive any changes from the object it was created from as they are distinct clones.
    /// </remarks>
    public PointerState(PointerState other)
        : this(
            new ButtonReadOnlyList<PointerButton>(other.Buttons),
            new InputReadOnlyList<TargetPoint>(other.Points),
            other.GripPressure
        ) { }

    /// <summary>
    /// Gets the captured state of each of the buttons on the device.
    /// </summary>
    public ButtonReadOnlyList<PointerButton> Buttons { get; } = buttons;

    /// <summary>
    /// Gets the points on the targets at which the user is pointing using the device.
    /// </summary>
    public InputReadOnlyList<TargetPoint> Points { get; } = points;

    /// <summary>
    /// Gets the pressure the user is applying to the grip of the pointer device, where <c>0.0</c> is the lowest
    /// measurable pressure and <c>1.0</c> is the highest measurable pressure.
    /// </summary>
    public float GripPressure { get; internal set; } = gripPressure;
}
