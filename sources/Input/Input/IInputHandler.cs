namespace Silk.NET.Input;

/// <summary>
/// A handler of Silk.NET input events of type <see cref="T"/>. This is the base entry point for consuming the given
/// type of input events. Typically, however, you will want to implement more specific interfaces, such as
/// <see cref="IButtonInputHandler{T}"/> or <see cref="IPointerInputHandler"/>.
/// </summary>
/// <seealso cref="InputContext.Gamepads"/>
/// <seealso cref="InputContext.Pointers"/>
/// <seealso cref="InputContext.Joysticks"/>
/// <seealso cref="InputContext.Keyboards"/>
public interface IInputHandler<in T> : IInputHandler where T : struct
{
    /// <summary>
    /// This method is called at the end of each call to <see cref="InputContext.Update"/> if there are events of
    /// the specified type
    /// </summary>
    /// <param name="event"></param>
    void Handle(T @event);
}

/// <summary>
/// Represents a handler of human input. Implementations of this type will receive a method call for each distinctive
/// HID event received in the order they were received, to the best of the backend's ability. All visible changes to
/// device state correspond to a method call using this interface.
/// </summary>
/// <seealso cref="InputContext.Gamepads"/>
/// <seealso cref="InputContext.Pointers"/>
/// <seealso cref="InputContext.Joysticks"/>
/// <seealso cref="InputContext.Keyboards"/>
/// <remarks>
/// Odds are, you don't want to implement this. If you're unsure, check the public properties of
/// <see cref="InputContext"/> to subscribe to input events.<br/><br/>
/// Otherwise, see <see cref="IInputHandler{T}"/>.
/// </remarks>
public interface IInputHandler
{
    /// <summary>
    /// Called when an <see cref="IInputDevice"/> disconnects from the application.
    /// </summary>
    /// <param name="event">The event details.</param>
    void HandleDeviceConnectionChanged(ConnectionEvent @event);
}
