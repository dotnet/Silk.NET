// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;
using Silk.NET.Input.SDL3.Extensions;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal sealed class SdlMouse : SdlPointerDevice, IMouse, ISdlDevice<SdlMouse>
{
    public override PointerState State => _state;
    public ICursorConfiguration Cursor { get; }

    private readonly MouseState _state;

    // the mouse is always considered "down" - there is no up/down state for the mouse pointer itself - only its buttons.
    private const bool DownState = true;

    private SdlMouse(ulong sdlDeviceId, nint uniqueId, SdlInputBackend backend,
        ICursorConfiguration cursor)
        : base(backend, uniqueId, sdlDeviceId)
    {
        _state = new MouseState(Buttons, StatePoints, Vector2.Zero);
        Cursor = cursor;
    }

    protected internal override void Initialize(long timestamp, ulong sdlTimestamp)
    {
        float x = 0, y = 0;
        var mouseInputFlags = GetMouseState(ref x, ref y);
        ApplyMouseButtonState(mouseInputFlags, sdlTimestamp, timestamp);

        var window = NativeBackend.GetMouseFocus();
        if (Backend.TryGetOrCreatePointerTargetForWindow(window, out var target))
        {
            AddOrUpdatePoint(null, target, new Vector3(x, y, 0), null, DownState, null, sdlTimestamp, timestamp);
        }
        // var point = _unboundedPointerTarget.GetPoint(this, 0);
    }


    private void ApplyMouseButtonState(SdlMouseInputFlags mouseState, ulong nowSdl, long now)
    {
        foreach (var pointerButtonName in EnumInfo<PointerButton>.UniqueNamedValues)
        {
            if (mouseState.Has(pointerButtonName))
            {
                AddButtonEvent(pointerButtonName, now, nowSdl, true);
            }
        }
    }

    private unsafe SdlMouseInputFlags GetMouseState(ref float x, ref float y) =>
        (SdlMouseInputFlags)NativeBackend.GetMouseState((float*)Unsafe.AsPointer(ref x),
            (float*)Unsafe.AsPointer(ref y));

    public static SdlMouse CreateDevice(ulong sdlDeviceId, long timestamp, ulong sdlTimestamp, bool isSimulated, SdlInputBackend backend, SdlInputEventContext sdlInputEvents)
    {
        var deviceName = backend.Sdl.GetMouseNameForID((uint)sdlDeviceId);
        nint uniqueId = 0;
        if (!backend.AttemptUniqueId(deviceName, ref uniqueId))
        {
            uniqueId = SdlInputBackend.FallbackUniqueId<SdlMouse>(sdlDeviceId, uniqueId);
        }

        var mouse =
            new SdlMouse(sdlDeviceId, uniqueId, backend, backend.CursorConfiguration) {
                ScrollEvents = sdlInputEvents.MouseScrollEvents,
                PointEvents = sdlInputEvents.PointChangedEvents,
                ClickEvents = sdlInputEvents.PointerClickEvents,
                ButtonEvents = sdlInputEvents.PointerButtonEvents,
                GripEvents = sdlInputEvents.PointerGripChangedEvents,
                TargetEvents = sdlInputEvents.PointerTargetChangedEvents
            };

        return mouse;
    }

    public override string Name => NativeBackend.GetMouseNameForID((uint)SdlDeviceId).ReadToString();

    protected override void Release()
    {
    }

    MouseState IMouse.State => _state;

    // QUESTION: pair with simulated touch device if simulated touch events occur?
    // though, we can probably only pair if there is *one* mouse - multiple mice
    // would make it difficult to pair, as simulated touch input does not specify the mouse
    // it comes from
    // public int? TouchId { get; private set; }

    private bool IsMouseRelative
    {
        get
        {
            //var focus = NativeBackend.GetMouseFocus();
            if (!Backend.TryGetWindowHandles(out var windows))
            {
                return false;
            }

            var isRelative = false;

            for (var i = 0; i < windows.Count; i++)
            {
                isRelative |= NativeBackend.GetWindowRelativeMouseMode(windows[i]);
            }

            windows.Dispose();
            return isRelative;
        }
    }

    protected override bool OnePointOnly => true;
    private bool _hintsAsEvents = false;


    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="position">The window-relative position of the mouse</param>
    /// <returns>True if success, but see the below remarks</returns>
    /// <remarks>
    /// todo (LOW PRIO): this is the most straightforward way to do window-relative movement,
    /// but we don't actually get any information about whether or not
    /// it succeeds. The SDL documentation seems to suggest that it "just works" as opposed to their global mouse warp
    /// method, which provides a success result. instead of translating this "global" position to a window-specific one,
    /// we're gonna use SDL's implementation of window-relative movement to keep things simple.<br/><br/>
    /// As a result, we always return true, though the documentation suggests that it does not work specifically for
    /// Microsoft Remote Desktop. not sure how to detect that at the moment.<br/><br/>
    /// Another consequence of doing it this way is that we need to wait for SDL to push these events through the event
    /// queue, so while this may return 'true', this mouse object will not necessarily be in the correct position until
    /// the next time pumped events are processed.<br/><br/>
    /// We could just create a mouse motion event and push it through our internal event queues, bypassing SDL's event
    /// queue, but that could result in a situation where we set our internal state to represent the
    /// movement, even though SDL did not meaningfully succeed.<br/><br/>
    /// The best way around this would probably be to try global mouse warping with translated coordinates,
    /// and if that fails, fall back to window-relative movement.
    /// </remarks>
    public bool TrySetPosition(Vector2 position)
    {
        // make sure we get pumped mouse events for setting the position this way
        if (!_hintsAsEvents)
        {
            var currentHintVal = NativeBackend.GetHintBoolean(Sdl.HintMouseRelativeWarpMotion, new MaybeBool<byte>(0));
            if (currentHintVal == 0)
            {
                sbyte hintVal = 1;
                if (NativeBackend.SetHint(Sdl.HintMouseRelativeWarpMotion, new Ref<sbyte>(ref hintVal)))
                {
                    _hintsAsEvents = true;
                }
            }
            else
            {
                _hintsAsEvents = true;
            }
        }

        // providing a null window handle means that SDL will use the latest position
        NativeBackend.WarpMouseInWindow(default, position.X, position.Y);
        NeedsPump = true; // we should "pump" events immediately, but this isn't a good place to do it.
        return true;
    }

    /// <summary>
    /// A user has attempted to modify the hardware mouse position - we need a pump to process these events.
    /// </summary>
    public bool NeedsPump { get; private set; }

    public void AddMotion(ref readonly MouseMotionEvent evtMotion, IPointerTarget target, long timestamp)
    {
        if (evtMotion is { Xrel: 0, Yrel: 0 })
        {
            return;
        }

        AddOrUpdatePoint(null, target, new Vector3(evtMotion.X, evtMotion.Y, 0), 1, null, null, evtMotion.Timestamp, timestamp);
    }


    public void AddMouseButtonEvent(ref readonly MouseButtonEvent evtButton, long timestamp)
    {
        //var button = PointerButton.Primary + (evtButton.Button - 1);
        const float mult = 1 / 255f;
        AddButtonEvent(
            button: evtButton.Button switch {
                1 => PointerButton.Primary,
                2 => PointerButton.MiddleButton,
                3 => PointerButton.Secondary,
                4 => PointerButton.Button4,
                5 => PointerButton.Button5,
                _ => PointerButton.Button5 + evtButton.Button - 5
            },
            timestamp: timestamp,
            sdlTimestamp: evtButton.Timestamp,
            isDown: evtButton.Down > 0,
            pressure: evtButton.Down * mult);
    }

    public void AddWheelEvent(ref readonly MouseWheelEvent evtWheel, IPointerTarget target, long timestamp)
    {
        var pWheelPosition = _state.WheelPosition;
        const float max = 100f;
        var delta = new Vector2(evtWheel.X, evtWheel.Y);
        if (delta.X != 0 && pWheelPosition.X is > max or < -max)
        {
            pWheelPosition.X = 0;
        }

        if (delta.Y != 0 && pWheelPosition.Y is > max or < -max)
        {
            pWheelPosition.Y = 0;
        }


        AddMouseScrollEvent(
            scrollWheelPosition: _state.WheelPosition = pWheelPosition + delta,
            scrollWheelDelta: delta,
            target: target,
            sdlTimestamp: evtWheel.Timestamp,
            mousePos: new Vector3(evtWheel.X, evtWheel.Y, 0),
            timestamp: timestamp);
    }

}
