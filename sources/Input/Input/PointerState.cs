namespace Silk.NET.Input;

/// <summary>
/// Contains user input state received from an <see cref="IPointerDevice"/>.
/// </summary>
public class PointerState
{
    /// <summary>
    /// Gets the captured state of each of the buttons on the device.
    /// </summary>
    public ButtonReadOnlyList<PointerButton> Buttons { get; }

    /// <summary>
    /// Gets the points on the targets at which the user is pointing using the device.
    /// </summary>
    public InputReadOnlyList<TargetPoint> Points { get; }

    /// <summary>
    /// Gets the pressure the user is applying to the grip of the pointer device, where <c>0.0</c> is the lowest
    /// measurable pressure and <c>1.0</c> is the highest measurable pressure.
    /// </summary>
    public float GripPressure { get; }
}