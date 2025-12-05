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

    private SdlMouse(uint sdlDeviceId, nint uniqueId, SdlInputBackend backend, IPointerTarget unboundedPointerTarget, ICursorConfiguration cursor)
        : base(backend, uniqueId, sdlDeviceId)
    {
        _state = new MouseState(new ButtonReadOnlyList<PointerButton>(_buttons),
            new InputReadOnlyList<TargetPoint>(_points), Vector2.Zero);
        Cursor = cursor;
        float x = 0, y = 0;
        var buttonMask = NativeBackend.GetMouseState(x.AsRef(), y.AsRef());
        var pos = new Vector2(x, y);

        for (var i = 0; i < EnumInfo<PointerButton>.UniqueValues.Count; i++)
        {
            var button = EnumInfo<PointerButton>.UniqueValues[i];
            var pressed = IsPointerButtonPressedSdl(button, buttonMask);
            _buttons.Add(new Button<PointerButton>(button, pressed, pressed ? 1.0f : 0.0f));
        }

        var window = NativeBackend.GetMouseFocus();
        var pressure = _state.Buttons[PointerButton.Primary].Pressure;
        AddTargetPoint(window, pos, pressure);

        // add unbounded target
        // var point = _unboundedPointerTarget.GetPoint(this, 0);
        _targetListNoWindow = [unboundedPointerTarget];
        _targetListWithWindow = [null!, unboundedPointerTarget];
    }

    private void AddTargetPoint(WindowHandle window, Vector2 pos, float pressure)
    {
        if (!Backend.TryGetPointerTargetForWindow(window, out var windowTarget))
        {
            AddUnboundedPoint(pos, pressure);
        }
        else
        {
            AddWindowPoint(pos, pressure, windowTarget);
        }
    }

    private void AddTargetPoint(uint windowId, Vector2 pos, float pressure)
    {
        if (Backend.TryGetPointerTargetForWindow(windowId, out var windowTarget))
        {
            AddWindowPoint(pos, pressure, windowTarget);
        }
        else
        {
            AddUnboundedPoint(pos, pressure);
        }
    }

    private void AddUnboundedPoint(Vector2 pos, float pressure) =>
        // add raw position (likely just 0, but that's ok for now)
        _points.Add(
            new TargetPoint(0, // todo: use a unique id
                Flags: TargetPointFlags.NotPointingAtTarget,
                Position: new Vector3(pos, 0),
                NormalizedPosition: default,
                Pointer: default,
                Pressure: pressure,
                Target: null
            )
        );

    private void AddWindowPoint(Vector2 pos, float pressure, IPointerTarget windowTarget)
    {
        var bounds = windowTarget.Bounds;
        var min = new Vector2(bounds.Min.X, bounds.Min.Y);
        var max = new Vector2(bounds.Max.X, bounds.Max.Y);

        _points.Add(
            new TargetPoint(
                Id: 0, // todo - use a unique id
                Flags: TargetPointFlags.PointingAtTarget,
                Position: new Vector3(pos, 0),
                NormalizedPosition: new Vector3((pos - min) / (max - min), 0),
                Pointer: default,
                Pressure: pressure,
                Target: windowTarget
            ));
    }

    public static unsafe SdlMouse CreateDevice(uint sdlDeviceId, SdlInputBackend backend)
    {
        var deviceName = backend.Sdl.GetMouseNameForID(sdlDeviceId);
        nint uniqueId = 0;
        if (!backend.AttemptUniqueId(deviceName, ref uniqueId))
        {
            uniqueId = backend.FallbackUniqueId(sdlDeviceId, uniqueId);
        }

        backend.Sdl.Free(deviceName);
        return new SdlMouse(sdlDeviceId, uniqueId, backend, backend.UnboundedPointerTarget, backend.CursorConfiguration);
    }

    public override string Name => NativeBackend.GetMouseNameForID(SdlDeviceId).ReadToString();

    protected override void Release()
    {
    }

    MouseState IMouse.State => _state;

    public override unsafe IReadOnlyList<IPointerTarget> Targets
    {
        get
        {
            if (_mouseWindowId == 0)
            {
                return _targetListNoWindow;
            }

            if (!Backend.TryGetPointerTargetForWindow(_mouseWindowId, out var target))
            {
                return _targetListNoWindow;
            }

            _targetListWithWindow[0] = target;
            return _targetListWithWindow;
        }
    }

    protected override bool IsBounded { get; }


    public bool TrySetPosition(Vector2 position)
    {
        if (NativeBackend.WarpMouseGlobal(position.X, position.Y))
        {
            return true;
        }

        NativeBackend.ClearError();
        return false;
    }


    public void AddMotion(in MouseMotionEvent evtMotion)
    {
        _mouseWindowId = evtMotion.WindowID;
        var movementRelative = new Vector2(evtMotion.Xrel, evtMotion.Yrel);
        _accumulatedMotion += movementRelative;

        // add clear old point, add new point
        _points.Clear();
        AddTargetPoint(_mouseWindowId, _accumulatedMotion, 0);
    }

    public void AddButtonEvent(in MouseButtonEvent evtButton)
    {
        var button = PointerButton.Primary + evtButton.Button;
        var idx = EnumInfo<PointerButton>.ValueIndexOfUnnamed(button);
        const float mult = 1 / 255f;
        _buttons[idx] = new Button<PointerButton>(button, evtButton.Down > 0, evtButton.Down * mult);
    }

    public void AddWheelEvent(in MouseWheelEvent evtWheel)
    {
        _mouseScroll[0] += evtWheel.X;
        _mouseScroll[1] += evtWheel.Y;

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

        // todo - actually do stuff
        throw new NotImplementedException();
    }

    private static bool IsPointerButtonPressedSdl(PointerButton button, uint state)
    {
        var index = EnumInfo<PointerButton>.ValueIndexOf(button);
        if (index is < 0 or >= 32)
        {
            return false;
        }

        return (state & (1 << index)) != 0;
    }

    private uint _mouseWindowId;
    private Vector2 _mouseScroll;
    private Vector2 _accumulatedMotion;
    private readonly List<Button<PointerButton>> _buttons = [];
    private readonly List<TargetPoint> _points = new();
    private readonly IPointerTarget[] _targetListNoWindow;
    private readonly IPointerTarget[] _targetListWithWindow;
}
