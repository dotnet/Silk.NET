// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal sealed class SdlMouse : SdlPointerDevice, IMouse, ISdlDevice<SdlMouse>
{
    public override PointerState State => _state;
    public ICursorConfiguration Cursor { get; }

    private readonly MouseState _state;

    // the mouse is always considered "down" - there is no up/down state for the mouse pointer itself - only its buttons.
    private const bool DownState = true;

    private SdlMouse(ulong sdlDeviceId, nint uniqueId, SdlInputBackend backend, IPointerTarget unboundedPointerTarget,
        ICursorConfiguration cursor)
        : base(backend, uniqueId, sdlDeviceId, unboundedPointerTarget)
    {
        _state = new MouseState(Buttons, Points, Vector2.Zero);
        Cursor = cursor;
        float x = 0, y = 0;
        var mouseInputFlags = GetMouseState(ref x, ref y);
        ApplyMouseButtonState(mouseInputFlags);

        var window = NativeBackend.GetMouseFocus();
        uint windowId;
        if (window == nullptr)
        {
            windowId = 0;
        }
        else
        {
            windowId = NativeBackend.GetWindowID(window);
            if (windowId == 0)
            {
                SdlLog.Error("Mouse has no window");
            }
        }

        // var pressure = _state.Buttons[PointerButton.Primary].Pressure;
        AddOrUpdatePoint(0, windowId, new Vector3(x, y, 0), null, DownState, null, true);
        // var point = _unboundedPointerTarget.GetPoint(this, 0);
    }


    private void ApplyMouseButtonState(SdlMouseInputFlags mouseState)
    {
        foreach (var pointerButtonName in EnumInfo<PointerButton>.UniqueValues)
        {
            if (mouseState.Has(pointerButtonName))
            {
                AddButtonEvent(pointerButtonName, 0, true);
            }
        }
    }

    private unsafe SdlMouseInputFlags GetMouseState(ref float x, ref float y) =>
        (SdlMouseInputFlags)NativeBackend.GetMouseState((float*)Unsafe.AsPointer(ref x),
            (float*)Unsafe.AsPointer(ref y));

    public static SdlMouse CreateDevice(ulong sdlDeviceId, SdlInputBackend backend)
    {
        var deviceName = backend.Sdl.GetMouseNameForID((uint)sdlDeviceId);
        nint uniqueId = 0;
        if (!backend.AttemptUniqueId(deviceName, ref uniqueId))
        {
            uniqueId = SdlInputBackend.FallbackUniqueId(sdlDeviceId, uniqueId);
        }

        return new SdlMouse(sdlDeviceId, uniqueId, backend, backend.UnboundedPointerTarget,
            backend.CursorConfiguration);
    }

    public override string Name => NativeBackend.GetMouseNameForID((uint)SdlDeviceId).ReadToString();

    protected override void Release()
    {
    }

    MouseState IMouse.State => _state;

    // todo (maybe): pair with simulated touch device if simulated touch events occur
    // though, we can probably only pair if there is *one* mouse - multiple mice
    // would make it difficult to pair, as simulated touch input does not specify the mouse
    // it comes from
    public int? TouchId { get; private set; }

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
    /// todo: this is the most straightforward way to do window-relative movement,
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
                if(NativeBackend.SetHint(Sdl.HintMouseRelativeWarpMotion, new Ref<sbyte>(ref hintVal)))
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

    public void AddMotion(in MouseMotionEvent evtMotion) =>
        AddOrUpdatePoint(null, evtMotion.WindowID, new Vector3(evtMotion.X, evtMotion.Y, 0), 1, null, null,
            evtMotion.WindowID != 0);


    public void AddButtonEvent(in MouseButtonEvent evtButton)
    {
        var button = PointerButton.Primary + evtButton.Button;
        const float mult = 1 / 255f;
        AddButtonEvent(button, evtButton.Timestamp, evtButton.Down > 0, evtButton.Down * mult);
    }

    public void AddWheelEvent(in MouseWheelEvent evtWheel)
    {
        var wheelState = _state.WheelPosition = new Vector2(evtWheel.X, evtWheel.Y);
        AddMouseScrollEvent(
            scrollWheelPosition: wheelState,
            windowId: evtWheel.WindowID,
            position: new Vector3(evtWheel.MouseX, evtWheel.MouseY, 0),
            isMouseRelative: evtWheel.WindowID != 0);
    }
}
