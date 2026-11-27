// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Numerics;
using Silk.NET.Input.SDL3.Extensions;
using Silk.NET.Input.SDL3.Devices.Pointers.Targets;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal sealed class SdlMouse : SdlPointerDevice, IMouse, ISdlDevice<SdlMouse>, INeedPreUpdate
{

    public override PointerState State => _state;
    public ICursorConfiguration Cursor { get; }

    public override string Name { get; }

    /// <summary>
    /// A user has attempted to modify the hardware mouse position - we need a pump to process these events.
    /// todo - let's pump events immediately before our input update ends. should we have an internal interface
    /// for this?
    /// </summary>
    public bool NeedsPump { get; set; }

    protected override bool OnePointOnly => true;
    private bool _hintsAsEvents;

    private readonly MouseState _state;

    private static readonly SdlUnboundedPointerTarget _rawMouseTarget = new();
    private static SdlCursor? _sdlCursor;

    /// <summary>
    /// The accumulated position of the mouse on the "raw mouse input" target. This is
    /// only updated while the mouse is in relative mode
    /// </summary>
    private Vector3 _rawMousePositionSdl;

    /// <summary>
    /// The last absolute (window-relative) position reported by SDL
    /// </summary>
    private Vector3 _lastMousePositionSdl;

    private static readonly List<SdlMouse> _mice = new();

    public static SdlMouse CreateDevice(ulong sdlDeviceId, long timestamp, bool isSimulated, SdlInputBackend backend,
        SdlInputEventContext sdlInputEvents)
    {
        var deviceName = backend.Sdl.GetMouseNameForID((uint)sdlDeviceId);
        nint uniqueId = 0;
        if (!backend.AttemptUniqueId(deviceName, ref uniqueId))
        {
            uniqueId = SdlInputBackend.FallbackUniqueId<SdlMouse>(sdlDeviceId, uniqueId);
        }

        if (_sdlCursor is null)
        {
            _sdlCursor = new SdlCursor(backend.Sdl);
            _sdlCursor.ModeChanged += OnCursorModeChange;
            OnCursorModeChange(null, _sdlCursor.Mode);
        }

        return new SdlMouse(sdlDeviceId, uniqueId, backend, _sdlCursor) {
            ScrollEvents = sdlInputEvents.MouseScrollEvents,
            PointEvents = sdlInputEvents.PointChangedEvents,
            ClickEvents = sdlInputEvents.PointerClickEvents,
            ButtonEvents = sdlInputEvents.PointerButtonEvents,
            GripEvents = sdlInputEvents.PointerGripChangedEvents,
            TargetEvents = sdlInputEvents.PointerTargetChangedEvents
        };

        void OnCursorModeChange(object? sender, CursorModes cursorMode)
        {
            if (!backend.TryGetFocusedWindowHandle(out var window))
            {
                InputLog.Error("No window handle found - a window handle is required for changing cursor modes.");
                return;
            }

            switch (cursorMode)
            {
                // todo - CursorModes is a flags-based enum. but as far as i know, SDL does not support multiple modes at
                // once. Personally I would love to support multiple modes at once, but is that expected by anyone else?
                // it is a [Flags] after all...
                case CursorModes.Normal:
                {
                    SetGrabbed(sdl: backend.Sdl, window: in window, grabbed: false, relativeMode: false);
                    return;
                }
                case CursorModes.Confined:
                {
                    SetGrabbed(sdl: backend.Sdl, window: in window, grabbed: true, relativeMode: false);
                    break;
                }
                case CursorModes.Unbounded:
                {
                    foreach (var mouse in _mice)
                    {
                        mouse._rawMousePositionSdl = Vector3.Zero;
                    }

                    SetGrabbed(sdl: backend.Sdl, window: in window, grabbed: false, relativeMode: true);
                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException(nameof(cursorMode), cursorMode, null);
            }

            return;

            static bool SetGrabbed(ISdl sdl, ref readonly WindowHandle window, bool grabbed, bool relativeMode)
            {
                var onlySuccess = true;
                if (!sdl.SetWindowMouseGrab(window, grabbed))
                {
                    SdlLog.Error("Failed to set window's mouse grab.");
                    onlySuccess = false;
                }

                if (!sdl.SetWindowRelativeMouseMode(window, relativeMode))
                {
                    SdlLog.Error("Failed to set relative mouse mode.");
                    onlySuccess = false;
                }

                return onlySuccess;
            }
        }
    }

    private SdlMouse(ulong sdlDeviceId, nint uniqueId, SdlInputBackend backend, ICursorConfiguration cursor)
        : base(backend, uniqueId, sdlDeviceId)
    {
        _state = new MouseState(Buttons, StatePoints, Vector2.Zero);
        Cursor = cursor;
        Name = NativeBackend.GetMouseNameForID((uint)SdlDeviceId).ReadToString();
        _mice.Add(this);
    }

    protected internal override void Initialize(long timestamp)
    {
        float x = 0, y = 0;
        var mouseInputFlags = (SdlMouseInputFlags)NativeBackend.GetMouseState(x.AsRef(), y.AsRef());
        foreach (var pointerButtonName in EnumInfo<PointerButton>.UniqueNamedValues)
        {
            if (mouseInputFlags.Has(pointerButtonName))
            {
                AddButtonEvent(pointerButtonName, timestamp, true, 1);
            }
        }

        _rawMousePositionSdl = Vector3.Zero;
        _lastMousePositionSdl = new Vector3(x, y, 0);

        // Whether the mouse is in relative ("raw mouse input") mode is a property of the window it is acting on. Use the
        // backend's focused window as that window.
        if (Backend.TryGetFocusedWindowHandle(out var handle))
        {
            // the mouse is always considered "down" - there is no up/down state for the mouse pointer itself - only its
            // buttons.
            const bool downState = true;
            if (NativeBackend.GetWindowRelativeMouseMode(handle))
            {
                AddOrUpdatePoint(null, _rawMouseTarget, _rawMousePositionSdl, 1, downState, null, timestamp);
            }
            else if (Backend.TryGetOrCreatePointerTargetForWindow(handle, out var target))
            {
                AddOrUpdatePoint(null, target, _lastMousePositionSdl, 1, downState, null, timestamp);
            }
        }
    }


    protected override void Release()
    {
        _mice.Remove(this);
    }

    MouseState IMouse.State => _state;

    // QUESTION: pair with simulated touch device if simulated touch events occur?
    // though, we can probably only pair if there is *one* mouse - multiple mice
    // would make it difficult to pair, as simulated touch input does not specify the mouse
    // it comes from
    // public int? TouchId { get; private set; }

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
    /// Handles an SDL mouse motion event, routing the resulting point to the correct target.
    /// </summary>
    /// <param name="evtMotion">The SDL mouse motion event.</param>
    /// <param name="windowTarget">
    /// The target representing the window the motion applies to, or <c>null</c> if no window target could be
    /// resolved. A null target is acceptable for raw/relative motion.
    /// </param>
    /// <param name="timestamp">The event timestamp.</param>
    /// <remarks>
    /// When the originating window is in relative mouse mode, the event represents "raw mouse input": the movement is
    /// conveyed by the <see cref="MouseMotionEvent.Xrel"/>/<see cref="MouseMotionEvent.Yrel"/>. Per the input
    /// proposal, raw mouse input is reported against the mouse's "unbounded" pointer target, with an accumulated
    /// relative position, rather than against the window target.<br/><br/>
    /// </remarks>
    public void AddMotion(ref readonly MouseMotionEvent evtMotion, IPointerTarget? windowTarget, long timestamp)
    {
        if (IsRawMotion(evtMotion.WindowID, windowTarget, NativeBackend))
        {
            Debug.Assert(Cursor.Mode == CursorModes.Unbounded);
            // raw mouse input, so accumulate the deltas into our
            // raw position and use the unbounded target.
            _rawMousePositionSdl += new Vector3(evtMotion.Xrel, evtMotion.Yrel, 0);
            AddOrUpdatePoint(null, _rawMouseTarget, _rawMousePositionSdl, 1, null, null, timestamp);
            return;
        }

        if (windowTarget is null)
        {
            InputLog.Error("Window target is null for non-relative mouse motion event.");
            return;
        }

        var position = _lastMousePositionSdl = new Vector3(evtMotion.X, evtMotion.Y, 0);
        AddOrUpdatePoint(null, windowTarget, position, 1, null, null, timestamp);

        return;

        // whether a motion event represents "raw mouse input" (relative mode) or windowed input.
        // relative mode is per-window, so we key off the event's window id.
        static bool IsRawMotion(uint winId, IPointerTarget? windowTarget, ISdl nativeBackend)
        {
            if (winId != 0)
            {
                var window = nativeBackend.GetWindowFromID(winId);
                if (window != default)
                {
                    return nativeBackend.GetWindowRelativeMouseMode(window);
                }
            }

            return windowTarget is null;
        }
    }

    public void AddMouseButtonEvent(ref readonly MouseButtonEvent evtButton, long timestamp)
    {
        //var button = PointerButton.Primary + (evtButton.Button - 1);
        var down = evtButton.Down > 0;
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
            isDown: down,
            pressure01: down ? 1 : 0);
    }


    /// <summary>
    /// Handles an SDL mouse wheel event.
    /// </summary>
    /// <param name="evtWheel">The SDL mouse wheel event.</param>
    /// <param name="target">
    /// The window target the scroll applies to, or <c>null</c> when no window target could be resolved, in which case
    /// the scroll is ignored. Scrolling is inherently windowed (it is reported at a window position), so unlike motion
    /// it cannot be attributed to the unbounded target.
    /// </param>
    /// <param name="timestamp">The event timestamp.</param>
    public void AddWheelEvent(ref readonly MouseWheelEvent evtWheel, IPointerTarget? target, long timestamp)
    {
        if (target is null)
        {
            InputLog.Warn("Window target is null for mouse wheel event.");
            return;
        }

        var delta = new Vector2(evtWheel.X, evtWheel.Y);

        AddMouseScrollEvent(
            scrollWheelPosition: _state.WheelPosition += delta,
            scrollWheelDelta: delta,
            target: target,
            mousePos: new Vector3(evtWheel.MouseX, evtWheel.MouseY, 0),
            timestamp: timestamp);
    }

    public void PreUpdate() => _state.WheelPosition = Vector2.Zero;
}
