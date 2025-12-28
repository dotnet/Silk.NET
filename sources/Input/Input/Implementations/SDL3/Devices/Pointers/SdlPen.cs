// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal class SdlPen : SdlPointerDevice, ISdlDevice<SdlPen>
{
    public SdlPen(SdlInputBackend backend, nint silkId, ulong sdlDeviceId, string name, IPointerTarget unbounded) : base(backend, silkId, sdlDeviceId, unbounded)
    {
        Name = name;
        State = new PointerState(_buttons, _points);
    }

    public static SdlPen CreateDevice(ulong sdlDeviceId, SdlInputBackend backend)
    {
        nint uniqueId = 0;
        if(!backend.AttemptUniqueId(sdlDeviceId, ref uniqueId))
        {
            throw new InvalidOperationException("Failed to get unique id for pen device");
        }

        var nameMaybe = backend.Sdl.GetTouchDeviceName(sdlDeviceId);
        string name;
        if (nameMaybe == nullptr)
        {
            SdlLog.Error("Failed to get pen name");
            name = "Unknown Pen";
        }
        else
        {
            name = nameMaybe.ReadToString();
        }
        return new SdlPen(backend, uniqueId, sdlDeviceId, name, backend.UnboundedPointerTarget);
    }

    protected override uint GetButtonMaskSdl()
    {
        throw new NotImplementedException();
    }

    private readonly List<Button<PointerButton>> _buttons = [];
    private readonly List<TargetPoint> _points = [];

    public override PointerState State { get; }

    protected override bool OnePointOnly => true;


    public override string Name { get; }
    protected override void Release() => throw new NotImplementedException();


    private void SetWindowTarget(IPointerTarget? target) => _windowTarget = target;

    private bool _isPenClose;
    private IPointerTarget? _windowTarget;

    public void Event(IPointerTarget? target, in Vector2? position, SdlInputBackend.SdlPenInputFlags state, PenAxis? axis = null, [NotNullIfNotNull(nameof(axis))] float? axisValue = null)
    {

    }

    public void SetProximity(IPointerTarget? target, bool inProximity)
    {
        _isPenClose = inProximity;
        SetWindowTarget(target);
    }
}
