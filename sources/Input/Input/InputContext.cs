namespace Silk.NET.Input;

/// <summary>
/// Represents an "input context" containing multiple <see cref="IInputBackend"/>s from which
/// <see cref="IInputDevice"/>s, their state, and their events are aggregated and laid-out in a user-friendly fashion.
/// </summary>
/// <remarks>
/// The onus is on the user to coordinate using this type across threads, as the input backend is not thread safe
/// In addition, certain backends may have (unavoidable) restrictions on what thread <see cref="Update"/> can be called
/// on - the user is responsible for respecting these threading rules as well.
/// </remarks>
public class InputContext : IJoystickInputHandler, IGamepadInputHandler, IMouseInputHandler, IPointerInputHandler, IKeyboardInputHandler
{
    // These are lazy-initialized as they contain their own device lists in addition to the device list stored here and
    // the device lists stored in each of the backends. You could argue having this many duplicated lists is inefficient
    // and you'd be absolutely right, but realistically: how many devices will the average user have connected to their
    // PC? If you're worried about your game's memory consumption, you're probably not looking at the small lists that
    // input allocates... This way we can also provide sane/consistent indices.
    private Pointers? _pointers;
    private Keyboards? _keyboards;
    private Gamepads? _gamepads;
    private Joysticks? _joysticks;

    /// <summary>
    /// Gets the <see cref="IPointerDevice"/>s enumerated by the <see cref="IInputBackend"/>s attached to this context.
    /// </summary>
    public Pointers Pointers { get; }

    /// <summary>
    /// Gets the <see cref="IKeyboard"/>s enumerated by the <see cref="IInputBackend"/>s attached to this context.
    /// </summary>
    public Keyboards Keyboards { get; }

    /// <summary>
    /// Gets the <see cref="IGamepad"/>s enumerated by the <see cref="IInputBackend"/>s attached to this context.
    /// </summary>
    public Gamepads Gamepads { get; }

    /// <summary>
    /// Gets the <see cref="IJoystick"/>s enumerated by the <see cref="IInputBackend"/>s attached to this context.
    /// </summary>
    public Joysticks Joysticks { get; }

    /// <summary>
    /// Gets the <see cref="IInputDevice"/>s enumerated by the <see cref="IInputBackend"/>s attached to this context.
    /// </summary>
    public IReadOnlyList<IInputDevice> Devices { get; }

    /// <summary>
    /// Gets a list denoting the <see cref="IInputBackend"/> attached to this context.
    /// </summary>
    public IList<IInputBackend> Backends { get; }

    /// <summary>
    /// Raised when a device is added or removed from the list of connected <see cref="Devices"/>.
    /// </summary>
    public event Action<ConnectionEvent>? ConnectionChanged;

    /// <summary>
    /// Polls and updates the state of the <see cref="IInputDevice"/> objects connected to each
    /// <see cref="IInputBackend"/> attached to this context, raising appropriate events for each state change.
    /// </summary>
    /// <remarks>
    /// This calls <see cref="IInputBackend.Update"/> for each <see cref="IInputBackend"/> attached to this context.
    /// </remarks>
    public void Update()
    {
        foreach (var backend in Backends)
        {
            backend.Update(this);
        }
    }

    void IButtonInputHandler<JoystickButton>.HandleButtonChanged(ButtonChangedEvent<JoystickButton> @event) => throw new NotImplementedException();

    void IJoystickInputHandler.HandleAxisMove(JoystickAxisMoveEvent @event) => throw new NotImplementedException();

    void IJoystickInputHandler.HandleHatMove(JoystickHatMoveEvent @event) => throw new NotImplementedException();

    void IGamepadInputHandler.HandleThumbstickMove(GamepadThumbstickMoveEvent @event) => throw new NotImplementedException();

    void IGamepadInputHandler.HandleTriggerMove(GamepadTriggerMoveEvent @event) => throw new NotImplementedException();

    void IButtonInputHandler<PointerButton>.HandleButtonChanged(ButtonChangedEvent<PointerButton> @event) => throw new NotImplementedException();

    void IMouseInputHandler.HandleScroll(MouseScrollEvent @event) => throw new NotImplementedException();

    void IPointerInputHandler.HandleTargetChanged(PointerTargetChangedEvent @event) => throw new NotImplementedException();

    void IPointerInputHandler.HandlePointChanged(PointChangedEvent @event) => throw new NotImplementedException();

    void IPointerInputHandler.HandleGripChanged(PointerGripChangedEvent @event) => throw new NotImplementedException();

    void IButtonInputHandler<KeyName>.HandleButtonChanged(ButtonChangedEvent<KeyName> @event) => throw new NotImplementedException();

    void IKeyboardInputHandler.HandleKeyChanged(KeyChangedEvent @event) => throw new NotImplementedException();

    void IKeyboardInputHandler.HandleKeyChar(KeyCharEvent @event) => throw new NotImplementedException();
    void IInputHandler.HandleDeviceConnectionChanged(ConnectionEvent @event) => throw new NotImplementedException();
}
