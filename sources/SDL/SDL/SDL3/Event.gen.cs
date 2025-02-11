// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[StructLayout(LayoutKind.Explicit)]
public partial struct Event
{
    [FieldOffset(0)]
    [NativeTypeName("Uint32")]
    public uint Type;

    [FieldOffset(0)]
    public CommonEvent Common;

    [FieldOffset(0)]
    public DisplayEvent Display;

    [FieldOffset(0)]
    public WindowEvent Window;

    [FieldOffset(0)]
    public KeyboardDeviceEvent Kdevice;

    [FieldOffset(0)]
    public KeyboardEvent Key;

    [FieldOffset(0)]
    public TextEditingEvent Edit;

    [FieldOffset(0)]
    public TextEditingCandidatesEvent EditCandidates;

    [FieldOffset(0)]
    public TextInputEvent Text;

    [FieldOffset(0)]
    public MouseDeviceEvent Mdevice;

    [FieldOffset(0)]
    public MouseMotionEvent Motion;

    [FieldOffset(0)]
    public MouseButtonEvent Button;

    [FieldOffset(0)]
    public MouseWheelEvent Wheel;

    [FieldOffset(0)]
    public JoyDeviceEvent Jdevice;

    [FieldOffset(0)]
    public JoyAxisEvent Jaxis;

    [FieldOffset(0)]
    public JoyBallEvent Jball;

    [FieldOffset(0)]
    public JoyHatEvent Jhat;

    [FieldOffset(0)]
    public JoyButtonEvent Jbutton;

    [FieldOffset(0)]
    public JoyBatteryEvent Jbattery;

    [FieldOffset(0)]
    public GamepadDeviceEvent Gdevice;

    [FieldOffset(0)]
    public GamepadAxisEvent Gaxis;

    [FieldOffset(0)]
    public GamepadButtonEvent Gbutton;

    [FieldOffset(0)]
    public GamepadTouchpadEvent Gtouchpad;

    [FieldOffset(0)]
    public GamepadSensorEvent Gsensor;

    [FieldOffset(0)]
    public AudioDeviceEvent Adevice;

    [FieldOffset(0)]
    public CameraDeviceEvent Cdevice;

    [FieldOffset(0)]
    public SensorEvent Sensor;

    [FieldOffset(0)]
    public QuitEvent Quit;

    [FieldOffset(0)]
    public UserEvent User;

    [FieldOffset(0)]
    public TouchFingerEvent Tfinger;

    [FieldOffset(0)]
    public PenProximityEvent Pproximity;

    [FieldOffset(0)]
    public PenTouchEvent Ptouch;

    [FieldOffset(0)]
    public PenMotionEvent Pmotion;

    [FieldOffset(0)]
    public PenButtonEvent Pbutton;

    [FieldOffset(0)]
    public PenAxisEvent Paxis;

    [FieldOffset(0)]
    public RenderEvent Render;

    [FieldOffset(0)]
    public DropEvent Drop;

    [FieldOffset(0)]
    public ClipboardEvent Clipboard;

    [FieldOffset(0)]
    [NativeTypeName("Uint8[128]")]
    public EventPadding Padding;
}
