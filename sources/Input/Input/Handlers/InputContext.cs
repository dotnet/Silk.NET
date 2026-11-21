using System.Diagnostics;

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
public partial class InputContext
{
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
    /// <remarks>
    /// This is only updated when <see cref="Update"/> is called. In particular, the devices of a backend added to
    /// <see cref="Backends"/> are not enumerated until the next call to <see cref="Update"/>.
    /// </remarks>
    public IReadOnlyList<IInputDevice> Devices => _devices;

    /// <summary>
    /// Gets a list denoting the <see cref="IInputBackend"/> attached to this context.
    /// </summary>
    public IList<IInputBackend> Backends => this;

    /// <summary>
    /// Raised when a device is added or removed from the list of connected <see cref="Devices"/>.
    /// </summary>
    /// <remarks>
    /// Subscribers are invoked individually, such that a subscriber throwing an exception does not prevent the
    /// remaining subscribers from receiving the event.
    /// </remarks>
    public event Action<ConnectionEvent> ConnectionChanged
    {
        add => _connectionEventHandler.Add(value);
        remove => _connectionEventHandler.Remove(value);
    }

    /// <summary>
    /// Polls and updates the state of the <see cref="IInputDevice"/> objects connected to each
    /// <see cref="IInputBackend"/> attached to this context, raising appropriate events for each state change.
    /// </summary>
    /// <remarks>
    /// This calls <see cref="IInputBackend.Update"/> for each <see cref="IInputBackend"/> attached to this context.
    /// </remarks>
    public void Update()
    {
        while (_newBackends.TryDequeue(out var backend))
        {
            if (!_backends.Contains(backend))
            {
                // it was already removed
                continue;
            }

            var timestamp = Stopwatch.GetTimestamp();

            foreach (var device in backend.Devices)
            {
                if (!_devices.Contains(device))
                {
                    HandleDeviceConnectionChanged(new ConnectionEvent(device, timestamp, true));
                }
            }
        }

        for (var index = 0; index < _backends.Count; index++)
        {
            _backends[index].Update(this);
        }

        _pointers?.ProcessClicks();
    }

    private void DisconnectBackendDevices(IInputBackend backend)
    {
        var timestamp = Stopwatch.GetTimestamp();

        // remove all of their devices
        var devices = backend.Devices;
        for (var index = 0; index < devices.Count; index++)
        {
            var device = devices[index];
            HandleDeviceConnectionChanged(new ConnectionEvent(device, timestamp, false));
        }
    }

    private void HandleDeviceConnectionChanged(ConnectionEvent evt)
    {
#if DEBUG
        InputLog.Debug($"Input device connection changed: {evt}");
#endif
        _pointers?.HandleDeviceConnectionChanged(evt);
        _joysticks?.HandleDeviceConnectionChanged(evt);
        _gamepads?.HandleDeviceConnectionChanged(evt);
        _keyboards?.HandleDeviceConnectionChanged(evt);


        if (evt.IsConnected)
        {
            if (!_devices.Contains(evt.Device))
            {
                _devices.Add(evt.Device);
            }
        }
        else
        {
            _devices.Remove(evt.Device);
        }

        _connectionEventHandler.Invoke(evt);
    }

    // These are lazy-initialized as they contain their own device lists in addition to the device list stored here and
    // the device lists stored in each of the backends. You could argue having this many duplicated lists is inefficient
    // and you'd be absolutely right, but realistically: how many devices will the average user have connected to their
    // PC? If you're worried about your game's memory consumption, you're probably not looking at the small lists that
    // input allocates... This way we can also provide sane/consistent indices.
    private Pointers? _pointers;
    private Keyboards? _keyboards;
    private Gamepads? _gamepads;
    private Joysticks? _joysticks;
    private readonly List<IInputBackend> _backends = [];

    private readonly Queue<IInputBackend> _newBackends = [];
    private readonly List<IInputDevice> _devices = [];
    private readonly InputContextEventHandler<ConnectionEvent> _connectionEventHandler = new();
}
