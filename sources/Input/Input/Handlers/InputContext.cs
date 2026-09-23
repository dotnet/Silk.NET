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
    public IReadOnlyList<IInputDevice> Devices
    {
        get
        {
            if (_devices is not null)
            {
                return _devices;
            }

            if (_backends.Count == 0)
            {
                return _devices = [];
            }

            var deviceCount = 0;

            for (var index = 0; index < _backends.Count; index++)
            {
                deviceCount += _backends[index].Devices.Count;
            }

            _devices = new List<IInputDevice>(deviceCount);

            for (var index = 0; index < _backends.Count; index++)
            {
                var devices = Backends[index].Devices;
                _devices ??= new List<IInputDevice>(devices.Count);
                _devices.AddRange(devices);
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
        for (var index = 0; index < Backends.Count; index++)
        {
            Backends[index].Update(this);
        }

        _pointers?.ProcessClicks();
    }

    private void HandleBackendRemoval(IInputBackend backend)
    {
        var timestamp = Stopwatch.GetTimestamp();

        // remove all of their devices
        foreach (var device in backend.Devices)
        {
            HandleDeviceConnectionChanged(new ConnectionEvent(device, timestamp, false));
        }
    }

    private void HandleBackendAddition(IInputBackend backend)
    {
        var timestamp = Stopwatch.GetTimestamp();
        InputLog.Debug($"Adding backend {backend.Name}");

        // add all of their devices to ours
        foreach (var device in backend.Devices)
        {
            HandleDeviceConnectionChanged(new ConnectionEvent(device, timestamp, true));
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


        if (_devices is not null)
        {

            if (evt.IsConnected)
            {
                _devices.Add(evt.Device);
            }
            else
            {
                _devices.Remove(evt.Device);
            }
        }

        try
        {
            ConnectionChanged?.Invoke(evt);
        }
        catch (Exception e)
        {
            InputLog.Error(e.ToString());
        }
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
    private List<IInputDevice>? _devices;
}
