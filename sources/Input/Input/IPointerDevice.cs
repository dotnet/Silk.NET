namespace Silk.NET.Input;

/// <summary>
/// Represents a device with which the user can point at a target.
/// </summary>
public interface IPointerDevice : IButtonDevice<PointerButton>
{
    /// <summary>
    /// Gets the device state.
    /// </summary>
    /// <remarks>
    /// Only updated when <see cref="IInputBackend.Update"/> is called.
    /// </remarks>
    new PointerState State { get; }
    ButtonReadOnlyList<PointerButton> IButtonDevice<PointerButton>.State => State.Buttons;
    /// <summary>
    /// Gets the targets at which the user can point with their pointer.
    /// </summary>
    IReadOnlyList<IPointerTarget> Targets { get; }
}