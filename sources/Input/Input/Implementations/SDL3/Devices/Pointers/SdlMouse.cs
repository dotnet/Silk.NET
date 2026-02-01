// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;
using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal sealed class SdlMouse : SdlPointerDevice, IMouse, ISdlDevice<SdlMouse>
{
    public override PointerState State => _state;
    public ICursorConfiguration Cursor { get; }

    private readonly MouseState _state;

    private SdlMouse(ulong sdlDeviceId, nint uniqueId, SdlInputBackend backend, IPointerTarget unboundedPointerTarget,
        ICursorConfiguration cursor)
        : base(backend, uniqueId, sdlDeviceId, unboundedPointerTarget)
    {
        _state = new MouseState(Buttons, Points, Vector2.Zero);
        Cursor = cursor;
        float x = 0, y = 0;
        var mouseInputFlags = GetButtonMaskSdl(ref x, ref y);
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

        var pressure = _state.Buttons[PointerButton.Primary].Pressure;
        SetTargetPoint(windowId, new Vector3(x, y, 0), pressure);
        // var point = _unboundedPointerTarget.GetPoint(this, 0);
    }

    private void ApplyMouseButtonState(SdlMouseInputFlags mouseState)
    {
        foreach (var pointerButtonName in EnumInfo<PointerButton>.UniqueValues)
        {
            ref var button = ref GetButtonRef(pointerButtonName);
            var isDown = mouseState.Has(pointerButtonName);
            button = button with { IsDown = isDown, Pressure = isDown ? 1 : 0 };
        }
    }

    public override void Initialize()
    {

    }

    private unsafe SdlMouseInputFlags GetButtonMaskSdl(ref float x, ref float y) =>
        (SdlMouseInputFlags)NativeBackend.GetMouseState((float*)Unsafe.AsPointer(ref x), (float*)Unsafe.AsPointer(ref y));

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

    public bool TrySetPosition(Vector2 position)
    {
        if (NativeBackend.WarpMouseGlobal(position.X, position.Y))
        {
            SetTargetPoint(null, new Vector3(position.X, position.Y, 0), 0);
            return true;
        }

        SdlLog.Error("Failed to set mouse position");
        return false;
    }

    public void AddMotion(in MouseMotionEvent evtMotion)
    {
        var mouseWindowId = evtMotion.WindowID;
        var movementRelative = new Vector3(evtMotion.Xrel, evtMotion.Yrel, 0);
        _accumulatedMotion += movementRelative;
        // todo - test against evtMotion state values

        //SetTargetPoint(mouseWindowId, _accumulatedMotion, 0, 0);
        SetTargetPoint(mouseWindowId, new Vector3(evtMotion.X, evtMotion.Y, 0), 0);
    }



    public void AddButtonEvent(in MouseButtonEvent evtButton)
    {
        var button = PointerButton.Primary + evtButton.Button;
        const float mult = 1 / 255f;
        AddButtonEvent(button, evtButton.Down > 0, evtButton.Down * mult);
    }

    public void AddWheelEvent(in MouseWheelEvent evtWheel)
    {
        ref var x = ref _mouseScroll.X;
        ref var y = ref _mouseScroll.Y;
        x += evtWheel.X;
        y += evtWheel.Y;

        // todo - evt.Which?
        var hMagnitude = MathF.Abs(x);
        var vMagnitude = MathF.Abs(y);

        if (hMagnitude >= 1)
        {
            // horizontal scroll "tick"
            _mouseScroll.X = 0;
        }

        if (vMagnitude >= 1)
        {
            // vertical scroll "tick"
            _mouseScroll.Y = 0;
        }

        _state.WheelPosition = _mouseScroll;
    }


    private Vector2 _mouseScroll;
    private Vector3 _accumulatedMotion;
}
