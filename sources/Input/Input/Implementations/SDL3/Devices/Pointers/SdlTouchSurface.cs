// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;
using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

/// <summary>
/// Our internal representation of an SDL Touch Device.
/// See SDL's <a href="https://wiki.libsdl.org/SDL3/SDL_TouchDeviceType">documentation</a> for more information.
/// <br/><br/>
/// A touch device, according to SDL, can be one of three types:
/// <list type="bullet">
///     <item>Direct: touch screen with window-relative coordinates</item>
///     <item>IndirectAbsolute: trackpad with absolute device coordinates</item>
///     <item>IndirectRelative: trackpad with screen cursor-relative coordinates</item>
/// </list>
/// </summary>
internal class SdlTouchSurface : SdlPointerDevice, ISdlDevice<SdlTouchSurface>, IPointerDevice
{
    // todo - touch surfaces need to stick around forever?
    public static SdlTouchSurface CreateDevice(ulong sdlDeviceId, long timestamp, ulong sdlTimestamp, bool isSimulated,
        SdlInputBackend backend, SilkEventContext silkEvents)
    {
        var namePtr = backend.Sdl.GetTouchDeviceName(sdlDeviceId);

        nint uniqueId = 0;
        if (backend.AttemptUniqueId(sdlDeviceId, ref uniqueId))
        {
            return Create();
        }

        if (backend.AttemptUniqueId(namePtr, ref uniqueId))
        {
            return Create();
        }

        uniqueId = SdlInputBackend.FallbackUniqueId<SdlTouchSurface>(sdlDeviceId, uniqueId);

        return Create();

        SdlTouchSurface Create()
        {
            // https://wiki.libsdl.org/SDL3/SDL_MOUSE_TOUCHID

            // SDL would probably return Invalid itself since our simulated devices are providing fake IDs.
            // that being said, it feels like code smell to ask SDL about something it knows nothing about, so if
            // we're simulated (all-C#-side), we just don't bother asking SDL.
            var deviceType = isSimulated ? TouchDeviceType.Invalid : backend.Sdl.GetTouchDeviceType(sdlDeviceId);
            return new SdlTouchSurface(sdlDeviceId, uniqueId, backend, backend.UnboundedPointerTarget, deviceType,
                isSimulated) {
                ScrollEvents = silkEvents.MouseScrollInputEvents,
                PointEvents = silkEvents.PointChangedInputEvents,
                ClickEvents = silkEvents.PointerClickInputEvents,
                ButtonEvents = silkEvents.PointerButtonInputEvents,
                GripEvents = silkEvents.PointerGripChangedInputEvents,
                TargetEvents = silkEvents.PointerTargetChangedInputEvents
            };
        }
    }

    public bool IsSimulated { get; }

    public override string Name
    {
        get
        {
            var ptr = NativeBackend.GetTouchDeviceName(SdlDeviceId);
            if (ptr == nullptr)
            {
                SdlLog.Debug("Failed to get touch device name");
                return "Unknown Touch Surface";
            }

            return ptr.ReadToString();
        }
    }


    protected internal override void Initialize(long timestamp, ulong sdlTimestamp)
    {
    }

    protected override void Release() =>
        InputLog.Debug("Releasing touch device, but touch devices have no special release logic.");

    public override PointerState State { get; }

    protected override bool OnePointOnly => false;
    private readonly TouchDeviceType _type;

    private SdlTouchSurface(ulong sdlDeviceId, nint uniqueId, SdlInputBackend backend, IPointerTarget unbounded,
        TouchDeviceType type, bool isSimulated) : base(backend, uniqueId, sdlDeviceId, unbounded)
    {
        _type = type;
        IsSimulated = isSimulated;
        if (type == TouchDeviceType.Invalid && !isSimulated)
        {
            InputLog.Error("Invalid touch device type");
        }

        State = new PointerState(Buttons, Points);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Event(in TouchFingerEvent finger, SdlInputBackend.FingerEventType fingerType, long timestamp)
    {
        Vector3 position = new Vector3(finger.X, finger.Y, 0);
        if (Backend.TryGetPointerTargetForWindow(finger.WindowID, out var target))
        {
            position *= target.Bounds.Size.ToSystem();
        }
        else
        {
            throw new InvalidOperationException($"Touch device {this} has no target with window id {finger.WindowID}");
        }

        Event(
            fingerId: (uint)(finger.TouchID % int.MaxValue),
            target: target,
            position: position,
            eventType: fingerType,
            pressure: finger.Pressure,
            sdlTimestamp: finger.Timestamp,
            timestamp: timestamp,
            isPositionInWindowSpace: true);
    }

    public void Event(uint fingerId, IPointerTarget? target, Vector3 position, SdlInputBackend.FingerEventType eventType,
        float pressure, ulong sdlTimestamp, long timestamp, bool isPositionInWindowSpace)
    {
        switch (eventType)
        {
            case SdlInputBackend.FingerEventType.Motion:
                AddOrUpdatePoint(fingerId, target, position, pressure, null, null, isPositionInWindowSpace, sdlTimestamp,
                    timestamp);
                break;
            case SdlInputBackend.FingerEventType.Down:
                AddOrUpdatePoint(fingerId, target, position, pressure, true, null, isPositionInWindowSpace, sdlTimestamp,
                    timestamp);
                break;
            case SdlInputBackend.FingerEventType.Up:
                AddOrUpdatePoint(fingerId, target, position, pressure, false, null, isPositionInWindowSpace, sdlTimestamp,
                    timestamp);
                break;
            case SdlInputBackend.FingerEventType.Canceled:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(eventType), eventType, null);
        }
    }
}
