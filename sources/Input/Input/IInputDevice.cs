namespace Silk.NET.Input;

/// <summary>
/// Represents a connected Human Input Device (HID).
/// </summary>
/// <remarks>
/// All devices originate from a backend.<br />
/// <br />
/// An <see cref="IInputDevice"/> object shall be equatable to any such object retrieved from the same backend where
/// <see cref="Id"/> is equal.<br />
/// <br />
/// <see cref="IInputDevice"/> objects must not store any managed state, and if there is a requirement for this in a
/// future extension of this API then this must be defined in such a way that the state storage and lifetime is
/// user-controlled. While <see cref="IInputDevice"/> objects are equatable based on <see cref="Id"/>s, if a physical
/// device disconnects and reconnects the <see cref="IInputBackend"/> does not provide a guarantee that the same object
/// will be returned (primarily because doing so would require the <see cref="IInputBackend"/> to keep track of every
/// object it's ever created), rather a "compatible" one that acts identically to the original object. This is
/// completely benign if the object is nothing but a wrapper to the backend anyway. If there is unmanaged state (e.g. a
/// handle to a device that must be explicitly closed upon disconnection), then it is expected that even in the event of
/// reconnection, old objects (e.g. created with a now-disposed handle) shall still work for the newly-reconnected
/// device. A common way this could be implemented is storing the handles in the <see cref="IInputBackend"/>
/// implementation instead in the form of a mapping of physical device IDs (<see cref="Id"/>) to those handles. This
/// solves the object lifetime problem while also not adding undue complications to user code.
/// </remarks>
public interface IInputDevice : IEquatable<IInputDevice>
{
    /// <summary>
    /// Gets a globally-unique integral identifier for this device.
    /// </summary>
    nint Id { get; }

    /// <summary>
    /// Gets a rough human-readable description of the input device. Its value is not intrinsically meaningful.
    /// </summary>
    string Name { get; }
}