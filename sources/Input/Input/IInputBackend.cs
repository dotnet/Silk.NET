namespace Silk.NET.Input;

/// <summary>
/// Represents an input backend capable of receiving human input from Human Input Devices (HIDs).
/// </summary>
/// <remarks>
/// The onus is on the user to coordinate using this type across threads, as the input backend is not thread safe
/// In addition, certain backends may have (unavoidable) restrictions on what thread <see cref="Update"/> can be called
/// on - the user is responsible for respecting these threading rules as well.
/// </remarks>
public interface IInputBackend : IDisposable
{
    /// <summary>
    /// Gets a rough human-readable description of the input backend. Its value is not intrinsically meaningful.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Gets a globally-unique integral identifier for this device.
    /// </summary>
    nint Id { get; }

    /// <summary>
    /// Get a list containing all the <b>connected</b> devices available from this input backend.
    /// </summary>
    /// <remarks>
    /// When a device is disconnected, its <see cref="IInputDevice"/> shall no longer function and will not be
    /// enumerated by this list. When a device is connected, an <see cref="IInputDevice"/> with that physical device ID
    /// shall be added to this list. In addition, upon connection any past <see cref="IInputDevice"/> objects previously
    /// enumerated by this list on this <see cref="IInputBackend"/> instance shall also regain function if the device
    /// being added to this list shares the same physical device ID as those previous instances. All such previous
    /// instances shall be equatable to one another and to the <see cref="IInputDevice"/> instance added to this list.
    /// An implementation is welcome to reuse old objects, but this is strictly implementation-defined. A device not
    /// being present in the <see cref="Devices"/> (checked using <see cref="IInputDevice"/>s
    /// <see cref="IEquatable{IInputDevice}"/> implementation) list is sufficient evidence that a device has been
    /// disconnected.
    /// </remarks>
    IReadOnlyList<IInputDevice> Devices { get; }

    /// <summary>
    /// Polls and updates the state of the <see cref="IInputDevice"/> objects connected using this backend, sending
    /// input events to the given <see cref="IInputHandler"/> to reflect the human input received.
    /// </summary>
    /// <remarks>
    /// The value of the <c>State</c> properties on each device must not change until this method is called.
    /// </remarks>
    /// <param name="handler">The input handler.</param>
    void Update(IInputHandler? handler = null);
}
