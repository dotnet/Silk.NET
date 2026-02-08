// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal class SdlPen : SdlPointerDevice, ISdlDevice<SdlPen>
{
    public SdlPen(SdlInputBackend backend, nint silkId, ulong sdlDeviceId, string name, IPointerTarget unbounded) :
        base(backend, silkId, sdlDeviceId, unbounded)
    {
        Name = name;
        State = new PointerState(Buttons, Points);
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

    private void ApplyPenInputState(SdlPenInputFlags penState)
    {
        foreach (var pointerButtonName in EnumInfo<PointerButton>.UniqueValues)
        {
            ref var button = ref GetButtonRef(pointerButtonName);
            var isDown = penState.Has(pointerButtonName);
            button = button with { IsDown = isDown, Pressure = isDown ? 1 : 0 };
        }
    }


    public override void Initialize()
    {
    }

    public override PointerState State { get; }

    protected override bool OnePointOnly => true;

    public override string Name { get; }

    protected override void Release()
    {
    }

    public void UpDownEvent(in PenTouchEvent evt)
    {
        MotionEvent(evt.WindowID, evt.X, evt.Y);

        var previousPressure = GetPointPressure(0);
        const float divisor = 1f / 255f;
        var downPressure = evt.Down * divisor;
        if (downPressure > 0)
        {
            AddButtonEvent(PointerButton.Primary, true, Math.Max(previousPressure, downPressure));
        }
        else
        {
            AddButtonEvent(PointerButton.Primary, false, 0);
        }
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void MotionEvent(in PenMotionEvent evt) => MotionEvent(evt.WindowID, evt.X, evt.Y);

    private void MotionEvent(in uint windowId, float x, float y)
    {
        if (!Backend.TryGetPointerTargetForWindow(windowId, out var target))
        {
            return;
        }

        SetTargetPoint(windowId, new Vector3(x, y, 0), GetPointPressure(0),0);
    }


    public void ButtonEvent(in PenButtonEvent evt) => ApplyPenInputState((SdlPenInputFlags)evt.PenState);

    public void AxisEvent(in PenAxisEvent evt)
    {
        switch (evt.Axis)
        {
            case PenAxis.Pressure:
            {
                SetPointPressure(0, evt.Value);
                break;
                ;
            }
            case PenAxis.Xtilt:
            {
                SetPointXTilt(0, evt.Value);
                break;
            }
            case PenAxis.Ytilt:
            {
                SetPointYTilt(0, evt.Value);
                break;
            }
            case PenAxis.Distance:
            {
                SetPointDistance(0, evt.Value);
                break;
            }
            case PenAxis.Rotation: // barrel rotation
            {
                SetPointTwist(0, evt.Value);
                break;
            }
            case PenAxis.Slider:
            {
                // additional "button" or additional "axis" or "pressure"?
                // SetPointSlider(0, evt.Value);
                break;
            }
            case PenAxis.TangentialPressure:
            {
                SetGripPressure(evt.Value);
                break;
            }
            default:
            {
                return;
            }
        }
    }
}
