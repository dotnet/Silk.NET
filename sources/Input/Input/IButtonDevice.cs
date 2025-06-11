namespace Silk.NET.Input;

/// <summary>
/// Represents an input device that has buttons.
/// </summary>
/// <typeparam name="T">The type of buttons the input device has.</typeparam>
public interface IButtonDevice<T> : IInputDevice
    where T : unmanaged, Enum
{
    /// <summary>
    /// Gets the current button state for this device.
    /// </summary>
    /// <remarks>
    /// Only updated when <see cref="IInputBackend.Update"/> is called.
    /// </remarks>
    ButtonReadOnlyList<T> State { get; }
}
