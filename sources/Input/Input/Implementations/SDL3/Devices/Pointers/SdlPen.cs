// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal class SdlPen : SdlPointerDevice, ISdlDevice<SdlPen>
{
    public SdlPen(SdlInputBackend backend, nint silkId, ulong sdlDeviceId, string name, IPointerTarget unbounded) :
        base(backend, silkId, sdlDeviceId, unbounded)
    {
        Name = name;
        State = new PointerState(_buttons, _points);
    }

    public static SdlPen CreateDevice(ulong sdlDeviceId, SdlInputBackend backend)
    {
        nint uniqueId = 0;

        var name = backend.Sdl.GetTouchDeviceName(sdlDeviceId);
        if (name == nullptr)
        {
            SdlLog.Error("Failed to get pen name");
        }

        if (backend.AttemptUniqueId(name, ref uniqueId))
        {
            return Create();
        }

        if (backend.AttemptUniqueId(name, ref uniqueId))
        {
            return Create();
        }

        if (backend.AttemptUniqueId(sdlDeviceId, ref uniqueId))
        {
            return Create();
        }

        uniqueId = SdlInputBackend.FallbackUniqueId(sdlDeviceId, uniqueId);
        return Create();


        SdlPen Create() => new(backend, uniqueId, sdlDeviceId, name.ReadToString(), backend.UnboundedPointerTarget);
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

    public void Event(IPointerTarget? target, in Vector2? position, SdlInputBackend.SdlPenInputFlags state,
        PenAxis? axis = null, [NotNullIfNotNull(nameof(axis))] float? axisValue = null)
    {
    }

    public void SetProximity(IPointerTarget? target, bool inProximity)
    {
        _isPenClose = inProximity;
        SetWindowTarget(target);
    }
}
