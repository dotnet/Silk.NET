// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal class SdlMouse : SdlPointerDevice, IMouse, ISdlDevice<SdlMouse>
{
    public override PointerState State => _state;
    public ICursorConfiguration Cursor { get; }

    private readonly MouseState _state;

    private SdlMouse(uint sdlDeviceId, nint uniqueId, SdlInputBackend backend, IPointerTarget unboundedPointerTarget,
        ICursorConfiguration cursor)
        : base(backend, uniqueId, sdlDeviceId, unboundedPointerTarget)
    {
        _state = new MouseState(Buttons, Points, Vector2.Zero);
        Cursor = cursor;
        float x = 0, y = 0;
        _ = NativeBackend.GetMouseState(x.AsRef(), y.AsRef());

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

        _mouseWindowId = windowId;
        var pressure = _state.Buttons[PointerButton.Primary].Pressure;
        SetTargetPoint(windowId, new Vector3(x, y, 0), pressure);
        // var point = _unboundedPointerTarget.GetPoint(this, 0);
    }

    protected override uint GetButtonMaskSdl() => NativeBackend.GetMouseState(nullptr, nullptr);


    public static unsafe SdlMouse CreateDevice(uint sdlDeviceId, SdlInputBackend backend)
    {
        var deviceName = backend.Sdl.GetMouseNameForID(sdlDeviceId);
        nint uniqueId = 0;
        if (!backend.AttemptUniqueId(deviceName, ref uniqueId))
        {
            uniqueId = backend.FallbackUniqueId(sdlDeviceId, uniqueId);
        }

        backend.Sdl.Free(deviceName);
        return new SdlMouse(sdlDeviceId, uniqueId, backend, backend.UnboundedPointerTarget,
            backend.CursorConfiguration);
    }

    public override string Name => NativeBackend.GetMouseNameForID(SdlDeviceId).ReadToString();

    protected override void Release()
    {
    }

    MouseState IMouse.State => _state;

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
            SetTargetPoint(_mouseWindowId, new Vector3(position.X, position.Y, 0), 0);
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

        SetTargetPoint(mouseWindowId, _accumulatedMotion, 0);
    }

    public void AddButtonEvent(in MouseButtonEvent evtButton)
    {
        var button = PointerButton.Primary + evtButton.Button;
        const float mult = 1 / 255f;
        AddButtonEvent(button, evtButton.Down > 0, evtButton.Down * mult);
    }

    public void AddWheelEvent(in MouseWheelEvent evtWheel)
    {
        _mouseScroll[0] += evtWheel.X;
        _mouseScroll[1] += evtWheel.Y;

        // todo - evt.Which?
        var hMagnitude = MathF.Abs(_mouseScroll[0]);
        var vMagnitude = MathF.Abs(_mouseScroll[1]);

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


    private void SetTargetPoint(uint windowId, in Vector3 pos, float pressure)
    {
        _ = Backend.TryGetPointerTargetForWindow(windowId, out var windowTarget);

        if (TryGetPointIndexForTarget(windowTarget, out var index))
        {
            UpdatePoint(ToTargetPoint(pos, pressure, windowTarget), index);
        }
        else
        {
            AddPoint(ToTargetPoint(pos, pressure, windowTarget));
        }

#if DEBUG
        if (_mouseWindowId != windowId)
        {
            InputLog.Warn($"Mouse window changed from {_mouseWindowId} to {windowId}");
        }
#endif

        _mouseWindowId = windowId;
    }


    private uint _mouseWindowId;
    private Vector2 _mouseScroll;
    private Vector3 _accumulatedMotion;
}
