using System.Diagnostics;

namespace Silk.NET.Input;

/// <summary>
/// Contains information pertaining to a button state change (e.g. press, depress, etc).
/// </summary>
/// <param name="Device">The device on which the button being pressed or depressed resides.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Button">The new state of the button being pressed or depressed.</param>
/// <param name="Previous">The previous state of the button.</param>
/// <typeparam name="T">The button type e.g. <see cref="JoystickButton"/>, <see cref="PointerButton"/>, etc.</typeparam>
public readonly record struct ButtonChangedEvent<T>(
    IButtonDevice<T> Device,
    long Timestamp,
    Button<T> Button,
    Button<T> Previous
)
    where T : unmanaged, Enum;
