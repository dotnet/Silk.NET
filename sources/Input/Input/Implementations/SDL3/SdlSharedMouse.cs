// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Input.SDL3;

internal class SdlSharedMouse : SdlBoundedPointerDevice, IMouse
{
    private readonly MouseState _state;

    public SdlSharedMouse(SdlInputBackend backend)
        : base(backend)
    {
        var buttons = InputMarshal.CreateList<Button<PointerButton>>(32);
        var points = InputMarshal.CreateList<TargetPoint>(1);
        _state = new MouseState(buttons.List.AsButtonList(), points.List, Vector2.Zero);
        float x = 0,
            y = 0;
        var buttonMask = backend.Sdl.GetMouseState(x.AsRef(), y.AsRef());
        for (var i = 0; i < 32; i++)
        {
            InputMarshal.SetButtonState(
                buttons,
                new Button<PointerButton>(
                    i switch
                    {
                        1 => PointerButton.MiddleButton,
                        2 => PointerButton.Secondary,
                        _ => (PointerButton)(i + 1),
                    },
                    (buttonMask & (1 << i)) != 0,
                    0
                ),
                true
            );
        }

        var pos = new Vector2(x, y);
        var bounds = backend.BoundedPointerTarget.Bounds;
        var min = new Vector2(bounds.Min.X, bounds.Min.Y);
        var max = new Vector2(bounds.Max.X, bounds.Max.Y);
        points
            .GetUnderlyingList()!
            .Add(
                new TargetPoint(
                    0,
                    TargetPointFlags.PointingAtTarget,
                    new Vector3(pos - min, 0),
                    new Vector3((pos - min) / (max - min), 0),
                    default,
                    1.0f,
                    backend.BoundedPointerTarget
                )
            );
    }

    public override IntPtr Id => HashCode.Combine(Backend.Id);

    public override string Name => $"{Backend.Name}: Shared/Global Mouse";

    MouseState IMouse.State => _state;

    public ICursorConfiguration Cursor => Backend;

    public bool TrySetPosition(Vector2 position)
    {
        if (Backend.Sdl.WarpMouseGlobal(position.X, position.Y))
        {
            return true;
        }

        Backend.Sdl.ClearError();
        return false;
    }

    public override PointerState State => _state;
}
