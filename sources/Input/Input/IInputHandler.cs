namespace Silk.NET.Input;

/// <summary>
/// Represents a handler of human input. Implementations of this type will receive a method call for each distinctive
/// HID event received in the order they were received, to the best of the backend's ability. All visible changes to
/// device state correspond to a method call using this interface.
/// </summary>
public interface IInputHandler
{
    /// <summary>
    /// Called when an <see cref="IInputDevice"/> disconnects from the application.
    /// </summary>
    /// <param name="event">The event details.</param>
    void HandleDeviceConnectionChanged(ConnectionEvent @event);
}