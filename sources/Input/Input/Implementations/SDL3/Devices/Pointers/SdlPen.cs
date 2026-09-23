// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;
using Silk.NET.Input.SDL3.Extensions;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal class SdlPen : SdlPointerDevice, ISdlDevice<SdlPen>
{
    public SdlPen(SdlInputBackend backend, nint silkId, ulong sdlDeviceId, string name) :
        base(backend, silkId, sdlDeviceId)
    {
        Name = name;
        State = new PointerState(Buttons, StatePoints);
    }

    public static SdlPen CreateDevice(ulong sdlDeviceId, long timestamp, ulong sdlTimestamp, bool isSimulated, SdlInputBackend backend, SdlInputEventContext sdlInputEvents)
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
            return new SdlPen(backend, uniqueId, sdlDeviceId, name.ReadToString()) {
                ScrollEvents = sdlInputEvents.MouseScrollEvents,
                PointEvents = sdlInputEvents.PointChangedEvents,
                ClickEvents = sdlInputEvents.PointerClickEvents,
                ButtonEvents = sdlInputEvents.PointerButtonEvents,
                GripEvents = sdlInputEvents.PointerGripChangedEvents,
                TargetEvents = sdlInputEvents.PointerTargetChangedEvents
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

    public void UpDownEvent(ref readonly PenTouchEvent evt, IPointerTarget target, long timestamp)
    {
        MotionEvent(target, evt.X, evt.Y, evt.Timestamp, timestamp);

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
    public void MotionEvent(ref readonly PenMotionEvent evt, IPointerTarget target, long timestamp) => MotionEvent(target, evt.X, evt.Y, evt.Timestamp, timestamp);

    private void MotionEvent(IPointerTarget target, float x, float y, ulong sdlTimestamp, long timestamp)
    {
        AddOrUpdatePoint(
            touchId: null,
            target: target,
            pos: new Vector3(x, y, 0),
            pressure: null,
            isDown: null,
            ray: null,
            sdlTimestamp: sdlTimestamp,
            timestamp: timestamp);
    }

    public void ButtonEvent(ref readonly PenButtonEvent evt, long timestamp)
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

    public void AxisEvent(ref readonly PenAxisEvent evt, IPointerTarget target, long timestamp)
    {
        switch (evt.Axis)
        {
            case PenAxis.Pressure:
            {
                AddOrUpdatePoint(null, target, new Vector3(evt.X, evt.Y, 0), evt.Value, null, null, evt.Timestamp, timestamp);
                break;
            }
            case PenAxis.Xtilt:
            {
                UpdatePointRay(null, target, evt.Value, null, null, distance: null, evt.Timestamp, timestamp);
                break;
            }
            case PenAxis.Ytilt:
            {
                UpdatePointRay(null, target, null, evt.Value, null, distance: null, evt.Timestamp, timestamp);
                break;
            }
            case PenAxis.Distance:
            {
                UpdatePointRay(null, target, null, null, null, distance: evt.Value, evt.Timestamp, timestamp);
                break;
            }
            case PenAxis.Rotation: // barrel rotation
            {
                UpdatePointRay(null, target, null, null, evt.Value, distance: null, evt.Timestamp, timestamp);
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

    // ReSharper disable once ArrangeMethodOrOperatorBody
    public void ProximityEvent(ref readonly PenProximityEvent evt, IPointerTarget target, bool proximityIn, long timestamp)
    {
        // quoting the documentation:

        // "Not all platforms have a window associated with the pen during proximity events.
        // Some wait until motion/button/etc events to offer this info."
        // for the sake of uniformity of logic across platforms, we will simply ignore the window provided by this
        // proximity event

        // we also don't really need to do anything here since there's no useful information provided by this event
        // aside from that window information

        // as a result, the only consequence of this event being raised is that we will have guaranteed that we have
        // a pen device to handle subsequent input events

        // however, we will store the proximity state of this device for future reference / debugging purposes

        // update my latest point to be not-looking-at
        SetPointLookAtTarget(null, target, proximityIn, evt.Timestamp, timestamp);
    }
}
