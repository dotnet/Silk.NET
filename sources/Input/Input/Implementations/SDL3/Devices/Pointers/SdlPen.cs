// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

/// <remarks>
/// TODO: implement this as a device with continuous lifetime - currently, this is removed and recreated with
///  each pen proximity event
/// </remarks>
internal class SdlPen : SdlPointerDevice, ISdlDevice<SdlPen>
{
    public SdlPen(SdlInputBackend backend, nint silkId, ulong sdlDeviceId, string name, IPointerTarget unbounded) :
        base(backend, silkId, sdlDeviceId, unbounded)
    {
        Name = name;
        State = new PointerState(Buttons, Points);
    }

    public static SdlPen CreateDevice(ulong sdlDeviceId, long timestamp, ulong sdlTimestamp, SdlInputBackend backend, SilkEventContext silkEvents)
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

        uniqueId = SdlInputBackend.FallbackUniqueId<SdlPen>(sdlDeviceId, uniqueId);
        return Create();


        SdlPen Create()
        {
            return new SdlPen(backend, uniqueId, sdlDeviceId, name.ReadToString(), backend.UnboundedPointerTarget) {
                ScrollEvents = silkEvents.MouseScrollSdlEvents,
                PointEvents = silkEvents.PointChangedSdlEvents,
                ClickEvents = silkEvents.PointerClickSdlEvents,
                ButtonEvents = silkEvents.PointerButtonSdlEvents,
                GripEvents = silkEvents.PointerGripChangedSdlEvents,
                TargetEvents = silkEvents.PointerTargetChangedSdlEvents
            };
        }
    }

    public override PointerState State
    {
        get;
    }

    protected override bool OnePointOnly => true;

    public override string Name
    {
        get;
    }

    protected internal override void Initialize(long timestamp, ulong sdlTimestamp)
    {
    }

    protected override void Release()
    {
    }

    public void UpDownEvent(in PenTouchEvent evt, long timestamp)
    {
        MotionEvent(evt.WindowID, evt.X, evt.Y, evt.Timestamp, timestamp);

        if (evt.Down > 0)
        {
            const float divisor = 1f / 255f;
            var downPressure = evt.Down * divisor;
            AddButtonEvent(PointerButton.Primary, timestamp, evt.Timestamp, true, downPressure);
        }
        else
        {
            AddButtonEvent(PointerButton.Primary, timestamp, evt.Timestamp, false, 0);
        }
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void MotionEvent(in PenMotionEvent evt, long timestamp) => MotionEvent(evt.WindowID, evt.X, evt.Y, evt.Timestamp, timestamp);

    private void MotionEvent(in uint windowId, float x, float y, ulong sdlTimestamp, long timestamp) =>
        AddOrUpdatePoint(
            touchId: null,
            windowId: windowId == 0 ? null : windowId,
            pos: new Vector3(x, y, 0),
            pressure: null,
            isDown: null,
            ray: null,
            isPositionInWindowSpace: true,
            sdlTimestamp: sdlTimestamp,
            timestamp: timestamp);

    public void ButtonEvent(in PenButtonEvent evt, long timestamp)
    {
        var button = (SdlPenButton)evt.Button;
        var pointerButton = button switch {
            SdlPenButton.Button1 => PointerButton.Primary,
            SdlPenButton.Button2 => PointerButton.Secondary,
            SdlPenButton.Button3 => PointerButton.MiddleButton,
            SdlPenButton.Button4 => PointerButton.Button4,
            SdlPenButton.Button5 => PointerButton.Button5,
            _ => throw new ArgumentOutOfRangeException(nameof(button), button, null)
        };

        AddButtonEvent(pointerButton, timestamp, evt.Timestamp, evt.Down > 0, evt.Down / 255f);
    }

    private enum SdlPenButton : byte
    {
        Button1 = 1,
        Button2,
        Button3,
        Button4,
        Button5,
    }

    public void AxisEvent(in PenAxisEvent evt, long timestamp)
    {
        switch (evt.Axis)
        {
            case PenAxis.Pressure:
            {
                AddOrUpdatePoint(null, evt.WindowID, new Vector3(evt.X, evt.Y, 0), evt.Value, null, null, true, evt.Timestamp, timestamp);
                break;
            }
            case PenAxis.Xtilt:
            {
                UpdatePointRay(null, evt.Value, null, null, distance: null, evt.Timestamp, timestamp);
                break;
            }
            case PenAxis.Ytilt:
            {
                UpdatePointRay(null, null, evt.Value, null, distance: null, evt.Timestamp, timestamp);
                break;
            }
            case PenAxis.Distance:
            {
                UpdatePointRay(null, null, null, null, distance: evt.Value, evt.Timestamp, timestamp);
                break;
            }
            case PenAxis.Rotation: // barrel rotation
            {
                UpdatePointRay(null, null, null, evt.Value, distance: null, evt.Timestamp, timestamp);
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
                SetGripPressure(evt.Value, evt.Timestamp, timestamp);
                break;
            }
            default:
            {
                return;
            }
        }
    }
}
