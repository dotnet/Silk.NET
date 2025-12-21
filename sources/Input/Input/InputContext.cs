using System.Collections;

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
public class InputContext
    : IJoystickInputHandler,
        IGamepadInputHandler,
        IMouseInputHandler,
        IPointerInputHandler,
        IKeyboardInputHandler,
        IList<IInputBackend>
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
    private List<IInputBackend> _backends = [];
    private List<IInputDevice>? _devices;

    /// <summary>
    /// Gets the <see cref="IPointerDevice"/>s enumerated by the <see cref="IInputBackend"/>s attached to this context.
    /// </summary>
    public Pointers Pointers => _pointers ??= new Pointers(this);

    /// <summary>
    /// Gets the <see cref="IKeyboard"/>s enumerated by the <see cref="IInputBackend"/>s attached to this context.
    /// </summary>
    public Keyboards Keyboards => _keyboards ??= new Keyboards(this);

    /// <summary>
    /// Gets the <see cref="IGamepad"/>s enumerated by the <see cref="IInputBackend"/>s attached to this context.
    /// </summary>
    public Gamepads Gamepads => _gamepads ??= new Gamepads(this);

    /// <summary>
    /// Gets the <see cref="IJoystick"/>s enumerated by the <see cref="IInputBackend"/>s attached to this context.
    /// </summary>
    public Joysticks Joysticks => _joysticks ??= new Joysticks(this);

    /// <summary>
    /// Gets the <see cref="IInputDevice"/>s enumerated by the <see cref="IInputBackend"/>s attached to this context.
    /// </summary>
    public IReadOnlyList<IInputDevice> Devices
    {
        get
        {
            if (_devices is not null)
            {
                return _devices;
            }

            foreach (var backend in Backends)
            {
                _devices ??= new List<IInputDevice>(backend.Devices.Count);
                _devices.AddRange(backend.Devices);
            }

            return _devices ??= [];
        }
    }

    /// <summary>
    /// Gets a list denoting the <see cref="IInputBackend"/> attached to this context.
    /// </summary>
    public IList<IInputBackend> Backends => this;

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

        _pointers?.HandleUpdate();
    }

    private void HandleBackendRemoval(IInputBackend backend)
    {
        foreach (var device in backend.Devices)
        {
            HandleDeviceConnectionChanged(new ConnectionEvent(device, 0, false));
        }
    }

    private void HandleBackendAddition(IInputBackend backend)
    {
        foreach (var device in backend.Devices)
        {
            HandleDeviceConnectionChanged(new ConnectionEvent(device, 0, true));
        }
    }

    private void HandleDeviceConnectionChanged(ConnectionEvent e)
    {
        _pointers?.HandleDeviceConnectionChanged(e);
        _joysticks?.HandleDeviceConnectionChanged(e);
        _gamepads?.HandleDeviceConnectionChanged(e);
        _keyboards?.HandleDeviceConnectionChanged(e);
        if (_devices is null)
        {
            return;
        }

        if (e.IsConnected)
        {
            _devices?.Add(e.Device);
        }
        else
        {
            _devices?.Remove(e.Device);
        }
    }

    void IButtonInputHandler<JoystickButton>.HandleButtonChanged(
        ButtonChangedEvent<JoystickButton> @event
    ) => _joysticks?.HandleButtonChanged(@event);

    void IJoystickInputHandler.HandleAxisMove(JoystickAxisMoveEvent @event) =>
        _joysticks?.HandleAxisMove(@event);

    void IJoystickInputHandler.HandleHatMove(JoystickHatMoveEvent @event) =>
        _joysticks?.HandleHatMove(@event);

    void IGamepadInputHandler.HandleThumbstickMove(GamepadThumbstickMoveEvent @event) =>
        _gamepads?.HandleThumbstickMove(@event);

    void IGamepadInputHandler.HandleTriggerMove(GamepadTriggerMoveEvent @event) =>
        _gamepads?.HandleTriggerMove(@event);

    void IButtonInputHandler<PointerButton>.HandleButtonChanged(
        ButtonChangedEvent<PointerButton> @event
    ) => _pointers?.HandleButtonChanged(@event);

    void IMouseInputHandler.HandleScroll(MouseScrollEvent @event) =>
        _pointers?.HandleScroll(@event);

    void IPointerInputHandler.HandleTargetChanged(PointerTargetChangedEvent @event) =>
        _pointers?.HandleTargetChanged(@event);

    void IPointerInputHandler.HandlePointChanged(PointChangedEvent @event) =>
        _pointers?.HandlePointChanged(@event);

    void IPointerInputHandler.HandleGripChanged(PointerGripChangedEvent @event) =>
        _pointers?.HandleGripChanged(@event);

    void IButtonInputHandler<KeyName>.HandleButtonChanged(ButtonChangedEvent<KeyName> @event) =>
        _keyboards?.HandleButtonChanged(@event);

    void IKeyboardInputHandler.HandleKeyChanged(KeyChangedEvent @event) =>
        _keyboards?.HandleKeyChanged(@event);

    void IKeyboardInputHandler.HandleKeyChar(KeyCharEvent @event) =>
        _keyboards?.HandleKeyChar(@event);

    void IInputHandler.HandleDeviceConnectionChanged(ConnectionEvent @event)
    {
        HandleDeviceConnectionChanged(@event);
        ConnectionChanged?.Invoke(@event);
    }

    IEnumerator<IInputBackend> IEnumerable<IInputBackend>.GetEnumerator() =>
        _backends.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _backends.GetEnumerator();

    void ICollection<IInputBackend>.Add(IInputBackend item)
    {
        HandleBackendAddition(item);
        _backends.Add(item);
    }

    void ICollection<IInputBackend>.Clear()
    {
        foreach (var backend in Backends)
        {
            HandleBackendRemoval(backend);
        }
    }

    bool ICollection<IInputBackend>.Contains(IInputBackend item) => _backends.Contains(item);

    void ICollection<IInputBackend>.CopyTo(IInputBackend[] array, int arrayIndex) =>
        _backends.CopyTo(array, arrayIndex);

    bool ICollection<IInputBackend>.Remove(IInputBackend item)
    {
        HandleBackendRemoval(item);
        return _backends.Remove(item);
    }

    int ICollection<IInputBackend>.Count => _backends.Count;

    bool ICollection<IInputBackend>.IsReadOnly => false;

    int IList<IInputBackend>.IndexOf(IInputBackend item) => _backends.IndexOf(item);

    void IList<IInputBackend>.Insert(int index, IInputBackend item)
    {
        HandleBackendAddition(item);
        _backends.Insert(index, item);
    }

    void IList<IInputBackend>.RemoveAt(int index)
    {
        var backend = _backends[index];
        HandleBackendRemoval(backend);
        _backends.RemoveAt(index);
    }

    IInputBackend IList<IInputBackend>.this[int index]
    {
        get => _backends[index];
        set => _backends[index] = value;
    }
}
