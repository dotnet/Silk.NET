// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Input.SDL3.DataStructures;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

/// <summary>
/// A base class for SDL input devices that operate in terms of a window's or DWMs bounds.
/// </summary>
internal abstract partial class SdlPointerDevice : SdlDevice, IPointerDevice
{
    /// <summary>
    /// True if the device only supports one point - e.g., a mouse.<br/>
    /// False otherwise - e.g., a multitouch screen.
    /// </summary>
    protected abstract bool OnePointOnly { get; }
    private readonly List<Button<PointerButton>> _buttons = new(EnumInfo<PointerButton>.DistinctCount);
    protected ButtonReadOnlyList<PointerButton> Buttons => new(_buttons);
    protected InputReadOnlyList<TargetPoint> StatePoints => new(other: _actualPoints);

    /// <summary>
    /// This collection is maintained 1:1 with SDL's input events
    /// </summary>
    private readonly List<TargetPoint> _actualPoints = [];

    internal required SdlInputEventQueue<MouseScrollEvent> ScrollEvents { private get; init; }
    internal required SdlInputEventQueue<PointChangedEvent> PointEvents { private get; init; }
    internal required SdlInputEventQueue<PointerClickEvent> ClickEvents { private get; init; }
    internal required SdlInputEventQueue<ButtonChangedEvent<PointerButton>> ButtonEvents { private get; init; }
    internal required SdlInputEventQueue<PointerGripChangedEvent> GripEvents { private get; init; }
    internal required SdlInputEventQueue<PointerTargetChangedEvent> TargetEvents { private get; init; }

    protected SdlPointerDevice(SdlInputBackend backend, nint silkId,
        ulong sdlDeviceId) : base(backend, silkId, sdlDeviceId)
    {
        for (var i = 0; i < EnumInfo<PointerButton>.DistinctCount; i++)
        {
            var button = EnumInfo<PointerButton>.UniqueNamedValues[i];
            _buttons.Add(new Button<PointerButton>(button, false, 0f));
        }
    }

    protected void AddButtonEvent(PointerButton button, long timestamp, bool isDown, float pressure01)
    {
        var idx = button.Index();

        while (idx >= _buttons.Count)
        {
            var buttonName = EnumInfo<PointerButton>.ValueOfIndex(_buttons.Count);
            _buttons.Add(new Button<PointerButton>(buttonName, false, 0f));
        }

        ref var myButton = ref CollectionsMarshal.AsSpan(_buttons)[idx];
        var original = myButton;
        myButton = new Button<PointerButton>(button, isDown, pressure01);

        if (myButton != original)
        {
            ButtonEvents.Enqueue(new ButtonChangedEvent<PointerButton>(this, timestamp, myButton, original));
        }
    }

    protected float GetCurrentPressure(uint? touchId, IPointerTarget target, long timestamp, float x, float y)
    {
        ref var point = ref CreateOrUpdateTargetPoint(
            target: target,
            timestamp: timestamp,
            touchId: ValidateTouchId(touchId),
            positionOnTarget: new Vector3(x, y, 0),
            ray: null,
            pressure: null,
            oldPoint: out _);
        return point.Pressure;
    }


    public abstract PointerState State { get; }

    public IReadOnlyList<IPointerTarget> Targets => _myPointerTargets;

    protected void AddMouseScrollEvent(Vector2 scrollWheelPosition, Vector2 scrollWheelDelta, Vector3 mousePos, IPointerTarget target, long timestamp)
    {
        if (this is not IMouse mouse)
        {
            throw new InvalidOperationException("This device does not support scrolling.");
        }

        ref var point = ref CreateOrUpdateTargetPoint(
            target: target,
            timestamp: timestamp,
            touchId: ValidateTouchId(null),
            positionOnTarget: mousePos,
            ray: null,
            pressure: null,
            oldPoint: out _);

        ScrollEvents.Enqueue(new MouseScrollEvent(
            Mouse: mouse,
            Timestamp: timestamp,
            Point: point,
            WheelPosition: scrollWheelPosition,
            Delta: scrollWheelDelta));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected void SetGripPressure(float pressure, long timestamp)
    {
        // todo (LOW PRIO) -
        //  use only the given events to update the state of each input device later based on their event queues?
        //  is that possible? keyboard character input would probably be a problem..
        GripEvents.Enqueue(new PointerGripChangedEvent(this, timestamp, pressure, pressure - State.GripPressure));

        State.GripPressure = pressure;
    }

    public ISimulatedPointerTarget ApplySimulatedTarget(Func<ISdl, ISimulatedPointerTarget> createTarget) =>
        _falseTarget ??= createTarget(NativeBackend);
}
