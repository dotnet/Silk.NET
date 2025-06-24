// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Silk.NET.Input.SDL3.Pointers;
using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal class SdlInputBackend : IInputBackend, ICursorConfiguration
{
    private static readonly double _ticksPerNanosecond = Stopwatch.Frequency / 10e9d;

    private bool _pumped;
    private long _epoch;
    private List<IInputDevice> _devices = [];
    private readonly EventQueue _pumpedEvents = new();
    private WindowHandle _focusedWindow;
    private ISdl _sdl;

    public unsafe SdlInputBackend(SdlPlatformInfo info)
    {
        ArgumentNullException.ThrowIfNull(info.Sdl);
        ArgumentNullException.ThrowIfNull(info.Window.Handle);
        var ptr = new EventFilter(OnEvent);
        _sdl = info.Sdl;
        _focusedWindow = info.Window;
        // TODO overload resolution priority?
        if (!Sdl.AddEventWatch(ptr, (Ref)nullptr))
        {
            Sdl.ThrowError();
        }

        Id = (nint)ptr.Handle;

        // The epoch deals in nanoseconds, so we take multiple measurements for the most accurate timestamps.
        const byte epochMeasurements = 3;
        var epoch = 0L;
        for (byte i = 0; i < epochMeasurements; i++)
        {
            // We know the ticks per nanosecond, so to get the epoch timestamp we multiply the TicksNS by the ticks per
            // nanosecond to get the number of ticks relative to SDL's epoch, and then subtract that from the timestamp
            // now to get the timestamp of SDL's epoch. From there, when we receive an event we can just report the
            // timestamp as _epoch + (timestamp * _ticksPerNanosecond).
            var nowTimestamp = Stopwatch.GetTimestamp();
            var nowTicks = Sdl.GetTicksNS();
            epoch += unchecked(nowTimestamp - (long)(nowTicks * _ticksPerNanosecond));
        }

        _epoch = epoch / epochMeasurements;

        // ===============================================================================================
        // === If we ever need to share common state across window-specific "backends", use the below: ===
        // ===============================================================================================
        // // Get the root surface - our windowing backend assumes there is only one root surface. If this is not the
        // // case then this is undefined behaviour.
        // var rootSurface = info.Window;
        // var parent = rootSurface;
        // while ((parent = Sdl.GetWindowParent(rootSurface)) != nullptr)
        // {
        //     rootSurface = parent;
        // }
        // // Get the surface properties.
        // var props = Sdl.GetWindowProperties(rootSurface);
        // if (props == 0)
        // {
        //     Sdl.ThrowError();
        // }
        // // Get or create the root object.
        // Ref<sbyte> pname = "org.dotnetfoundation.silkdotnet.inputroot";
        // var root = (nint)Sdl.GetPointerProperty(props, pname, nullptr);
        // if (root != 0)
        // {
        //     Root =
        //         GCHandle.FromIntPtr(root).Target as SdlBackendRoot
        //         ?? throw new InvalidOperationException(
        //             "The global input data for this ancestry of SDL windows was not in an expected format."
        //         );
        // }
        // else
        // {
        //     Root = new SdlBackendRoot();
        //     var newHandle = GCHandle.Alloc(Root);
        //     if (
        //         Sdl.SetPointerPropertyWithCleanup(
        //             props,
        //             pname,
        //             (Ptr)GCHandle.ToIntPtr(newHandle),
        //             new CleanupPropertyCallback(&CleanupRoot),
        //             nullptr
        //         )
        //     )
        //     {
        //         return;
        //     }
        //     newHandle.Free();
        //     Sdl.ThrowError();
        // }
        // // Register ourselves with the root.
        // Root.Backends.Add(this, null);
        // Id = (nint)Root.EventFilter.Handle + Root.Backends.Count() - 1;
    }

    // [UnmanagedCallersOnly]
    // private static unsafe void CleanupRoot(void* _, void* value)
    // {
    //     var gch = GCHandle.FromIntPtr((nint)value);
    //     (gch.Target as SdlBackendRoot)?.Dispose();
    //     gch.Free();
    // }
    // public SdlBackendRoot Root { get; }

    // NOTE: Be careful where these are used!
    public SdlPlatformInfo Info { get; }

    [field: MaybeNull]
    public SdlBoundedPointerTarget BoundedPointerTarget =>
        field ??= new SdlBoundedPointerTarget(this);

    [field: MaybeNull]
    public SdlUnboundedPointerTarget UnboundedPointerTarget =>
        field ??= new SdlUnboundedPointerTarget(this);

    public ISdl Sdl => Info.Sdl ?? SDL.Sdl.Instance;

    public string Name =>
        $"Silk.NET.Input Reference Implementation using SDL3 ({Sdl.GetPlatform().ReadToString()})";

    public nint Id { get; }

    public IReadOnlyList<IInputDevice> Devices => _devices;

    // TODO we can't query support for these modes, but should we try-it-and-see to be accurate?
    public CursorModes SupportedModes =>
        CursorModes.Normal | CursorModes.Confined | CursorModes.Unbounded;

    // TODO if you're using one input context for all windows, there is no way to specify a window for grabbed cursor mode

    public CursorModes Mode
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CursorStyles SupportedStyles => throw new NotImplementedException();

    public CursorStyles Style
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CustomCursor Image
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    // This is complicated, as the input proposal mandates that nothing happens until Update is called (so the events
    // can be received on the given actor) but to also track logical events that happen between calls (i.e. from a
    // timestamp perspective). Compound this with the fact that the user might do something silly like make multiple
    // input backends (which is feasible for multiple windows I guess), or not be running anything other than input
    // (having obviously created a window beforehand but not actually polling events I guess)
    public void Update(IInputHandler? handler = null)
    {
        if (!_pumped)
        {
            Sdl.PumpEvents();
        }

        _pumped = false;
        if (handler == null)
        {
            return;
        }

        // process all events that have been queued?
    }

    private enum QueuedEventType : byte
    {
        /// <summary>
        /// The mouse has exited the window and the shared point should be marked inactive until proven otherwise by
        /// further mouse motion (indicating it has entered another window).
        /// </summary>
        /// <remarks>
        /// We do not track the mouse enter events as this would cause us to fire twice for a mouse entering a window:
        /// once for the entering, and once for new position.
        /// </remarks>
        MouseExitedWindow,

        /// <summary>
        /// The display bounds have been changed, meaning that <see cref="SdlBoundedPointerTarget"/>'s
        /// <see cref="IPointerTarget.Bounds"/> will have changed.
        /// </summary>
        BoundedPointerTargetUpdate,
    }

    private ulong GetTimestamp(ref readonly Event @event) =>
        unchecked((ulong)(_epoch + (@event.Common.Timestamp * _ticksPerNanosecond)));

    private unsafe byte OnEvent(void* arg0, Event* arg1)
    {
        _pumped = true;
        _pumpedEvents.Add(ref *arg1);
        return 1;
    }

    private void ProcessEvent(ref Event arg1, IInputHandler handler)
    {
         var timestamp = GetTimestamp(ref arg1);
        // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
        switch ((EventType)arg1.Common.Type)
        {
            //  Device changed events -------------------------------------------------
            case EventType.KeymapChanged:
                break;
            case EventType.KeyboardAdded:
            {
                var id = arg1.Kdevice.Which;
                Debug.Assert(_devices.All(x => x.Id != AsSilkId(id)));
                _ = GetOrCreateDevice<SdlKeyboard>(id);
                break;
            }
            case EventType.KeyboardRemoved:
            {
                RemoveDevice(arg1.Kdevice.Which);
                break;
            }


            case EventType.MouseAdded:
                break;
            case EventType.MouseRemoved:
                RemoveDevice(arg1.Mdevice.Which);
                break;

            case EventType.GamepadAdded:
            {
                var id = arg1.Kdevice.Which;
                Debug.Assert(_devices.All(x => x.Id != AsSilkId(id)));
                _ = GetOrCreateDevice<SdlGamepad>(id);
                break;
            }
            case EventType.GamepadRemoved:
            {
                RemoveDevice(arg1.Gdevice.Which);
                break;
            }
            case EventType.GamepadRemapped:
                break;

            case EventType.JoystickAdded:
                RemoveDevice(arg1.Jdevice.Which);
                break;
            case EventType.JoystickRemoved:
                break;

            //  Input events ----------------------------------------------------------
            case EventType.KeyDown:
                break;
            case EventType.KeyUp:
                break;

            case EventType.JoystickAxisMotion:
                break;
            case EventType.JoystickBallMotion:
                break;
            case EventType.JoystickHatMotion:
                break;
            case EventType.JoystickButtonDown:
                break;
            case EventType.JoystickButtonUp:
                break;
            case EventType.JoystickBatteryUpdated:
                break;
            case EventType.JoystickUpdateComplete:
                break;
            case EventType.GamepadAxisMotion:
                break;
            case EventType.GamepadButtonDown:
                break;
            case EventType.GamepadButtonUp:
                break;
            case EventType.GamepadTouchpadDown:
                break;
            case EventType.GamepadTouchpadMotion:
                break;
            case EventType.GamepadTouchpadUp:
                break;
            case EventType.GamepadSensorUpdate:
                break;
            case EventType.GamepadUpdateComplete:
                break;
            case EventType.GamepadSteamHandleUpdated:
                break;

            case EventType.SensorUpdate:
                break;


            // ----- Pointer events

            case EventType.MouseMotion:
                break;
            case EventType.MouseButtonDown:
                break;
            case EventType.MouseButtonUp:
                break;
            case EventType.MouseWheel:
                break;

            case EventType.FingerDown:
                break;
            case EventType.FingerUp:
                break;
            case EventType.FingerMotion:
                break;
            case EventType.FingerCanceled:
                break;

            case EventType.PenProximityIn:
                break;
            case EventType.PenProximityOut:
                break;
            case EventType.PenDown:
                break;
            case EventType.PenUp:
                break;
            case EventType.PenButtonDown:
                break;
            case EventType.PenButtonUp:
                break;
            case EventType.PenMotion:
                break;
            case EventType.PenAxis:
                break;

            // Display & window (pointer target) events ----------------------------
            case EventType.DisplayOrientation:
            case EventType.DisplayAdded:
            case EventType.DisplayRemoved:
            case EventType.DisplayMoved:
            case EventType.DisplayDesktopModeChanged:
            case EventType.DisplayCurrentModeChanged:
            case EventType.DisplayContentScaleChanged:
            {
                var bounds = SdlBoundedPointerTarget.CalculateBounds(Sdl);
                var x = (QueuedEventType.BoundedPointerTargetUpdate,
                        timestamp,
                        bounds.Min.ToSystem(),
                        bounds.Max.ToSystem()
                    );
                break;
            }
            case EventType.WindowMouseLeave: // do we need to do anything? we should probably track the current window of the pointer
            {
                var x = (QueuedEventType.MouseExitedWindow, timestamp);
                break;
            }

            // Text input events -------------------------------------------
            case EventType.TextEditing:
                break;
            case EventType.TextInput:
                break;
            case EventType.TextEditingCandidates:
                break;
            case EventType.ClipboardUpdate:
                break;


        }

        return;

        void RemoveDevice(uint id)
        {
            var silkId = AsSilkId(id);
            var deviceIdx = _devices.FindIndex(x => x.Id == silkId);

            if (deviceIdx == -1)
                return; // we never used this device to begin with, so just ignore its removal

            _devices.RemoveAt(deviceIdx);
        }

        T GetOrCreateDevice<T>(uint id) where T : SdlDevice, ISdlDevice<T>
        {
            // If we already have a device with this ID, return it.
            for(var i = 0; i < _devices.Count; i++)
            {
                if (_devices[i] is T typedDevice && typedDevice.SdlDeviceId == id)
                {
                    return typedDevice;
                }
            }

            var device = T.CreateDevice(this, id);
            _devices.Add(device);
            Console.WriteLine($"Gamepad added: (sdl ID: {id})");
            return device;
        }
    }

    /// <summary>
    /// Turns an sdl device id into a universally unique Silk.NET input id.
    /// </summary>
    /// <param name="which"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public nint AsSilkId(uint which)
    {
        return Id + Unsafe.As<uint, nint>(ref which) + 1;
    }

    /// <summary>
    /// Reverts the process of <see cref="AsSilkId(uint)"/> to get the original SDL id.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public uint AsSdlId(nint id)
    {
        return (uint)(id - Id - 1);
    }

    private unsafe void ReleaseUnmanagedResources()
    {
        Sdl.RemoveEventWatch(
            new EventFilter((delegate* unmanaged<void*, Event*, byte>)(void*)Id),
            nullptr
        );
        SilkMarshal.Free((Ptr)Id);
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }

    ~SdlInputBackend() => ReleaseUnmanagedResources();

    private class EventQueue
    {
        private readonly Queue<Event> _events = new(1024);
        public void Add(ref Event p0) => _events.Enqueue(p0);
    }
}
