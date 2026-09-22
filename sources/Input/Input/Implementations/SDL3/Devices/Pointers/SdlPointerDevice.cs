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
internal abstract partial class SdlPointerDevice : SdlDevice, IPointerDevice, INeedFinalizationEachFrame
{
    /// <summary>
    /// True if the device only supports one point - e.g., a mouse.<br/>
    /// False otherwise - e.g., a multitouch screen.
    /// </summary>
    protected abstract bool OnePointOnly { get; }
    private readonly List<Button<PointerButton>> _buttons = new(EnumInfo<PointerButton>.UniqueNamedValues.Count);
    protected ButtonReadOnlyList<PointerButton> Buttons => new(_buttons);
    protected InputReadOnlyList<TargetPoint> Points => new(other: _points);
    private readonly List<TargetPoint> _points = [];

    internal required ISdlInputEventQueue<MouseScrollEvent> ScrollEvents { private get; init; }
    internal required ISdlInputEventQueue<PointChangedEvent> PointEvents { private get; init; }
    internal required ISdlInputEventQueue<PointerClickEvent> ClickEvents { private get; init; }
    internal required ISdlInputEventQueue<ButtonChangedEvent<PointerButton>> ButtonEvents { private get; init; }
    internal required ISdlInputEventQueue<PointerGripChangedEvent> GripEvents { private get; init; }
    internal required ISdlInputEventQueue<PointerTargetChangedEvent> TargetEvents { private get; init; }

    protected SdlPointerDevice(SdlInputBackend backend, nint silkId,
        ulong sdlDeviceId, IPointerTarget unboundedPointerTarget) : base(backend, silkId, sdlDeviceId)
    {
        _unboundedPointerTarget = unboundedPointerTarget;
        for (var i = 0; i < EnumInfo<PointerButton>.UniqueNamedValues.Count; i++)
        {
            var button = EnumInfo<PointerButton>.UniqueNamedValues[i];
            _buttons.Add(new Button<PointerButton>(button, false, 0f));
        }
    }

    protected void AddButtonEvent(PointerButton button, long timestamp, ulong sdlTimestamp, bool isDown,
        float? pressure = null)
    {
        pressure ??= isDown ? 1.0f : 0.0f;
        var idx = EnumInfo<PointerButton>.ValueIndexOf(button);

        while (idx >= _buttons.Count)
        {
            var buttonName = EnumInfo<PointerButton>.ValueOfIndex(_buttons.Count);
            _buttons.Add(new Button<PointerButton>(buttonName, false, 0f));
        }

        ref var myButton = ref CollectionsMarshal.AsSpan(_buttons)[idx];
        var original = myButton;
        myButton = new Button<PointerButton>(button, isDown, pressure.Value);

        if (myButton != original)
        {
            ButtonEvents.Enqueue(new ButtonChangedEvent<PointerButton>(this, timestamp, myButton, original),
                sdlTimestamp);
        }
    }


    public abstract PointerState State { get; }

    public IReadOnlyList<IPointerTarget> Targets => _myPointerTargets;


    public void FinalizeUpdate()
    {

    }


    protected void AddMouseScrollEvent(Vector2 scrollWheelPosition, Vector2 scrollWheelDelta, Vector3 mousePos, IPointerTarget target, ulong sdlTimestamp, long timestamp)
    {
        if (this is not IMouse mouse)
        {
            throw new InvalidOperationException("This device does not support scrolling.");
        }

        uint? touchId = null;
        touchId = ValidateTouchId(touchId);

        ref var point = ref CreateOrUpdateTargetPoint(
            target: target,
            timestamp: timestamp,
            sdlTimestamp: sdlTimestamp,
            touchId: touchId.Value,
            positionOnTarget: mousePos,
            ray: null,
            pressure: null,
            oldPoint: out _);

        ScrollEvents.Enqueue(new MouseScrollEvent(
            Mouse: mouse,
            Timestamp: timestamp,
            Point: point,
            WheelPosition: scrollWheelPosition,
            Delta: scrollWheelDelta), sdlTimestamp);

    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected void SetGripPressure(float pressure, ulong sdlTimestamp, long timestamp)
    {
        // todo (LOW PRIO) -
        //  use only the given events to update the state of each input device later based on their event queues?
        //  is that possible? keyboard character input would probably be a problem..
        GripEvents.Enqueue(new PointerGripChangedEvent(this, timestamp, pressure, pressure - State.GripPressure),
            sdlTimestamp);

        State.GripPressure = pressure;
    }

    public ISimulatedPointerTarget ApplySimulatedTarget(Func<ISdl, ISimulatedPointerTarget> createTarget) =>
        _falseTarget ??= createTarget(NativeBackend);
}
