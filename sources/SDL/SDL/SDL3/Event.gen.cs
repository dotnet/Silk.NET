// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_Event")]
[StructLayout(LayoutKind.Explicit)]
public partial struct Event
{
    [NativeName("type")]
    [FieldOffset(0)]
    public uint Type;

    [NativeName("common")]
    [FieldOffset(0)]
    public CommonEvent Common;

    [NativeName("display")]
    [FieldOffset(0)]
    public DisplayEvent Display;

    [NativeName("window")]
    [FieldOffset(0)]
    public WindowEvent Window;

    [NativeName("kdevice")]
    [FieldOffset(0)]
    public KeyboardDeviceEvent Kdevice;

    [NativeName("key")]
    [FieldOffset(0)]
    public KeyboardEvent Key;

    [NativeName("edit")]
    [FieldOffset(0)]
    public TextEditingEvent Edit;

    [NativeName("edit_candidates")]
    [FieldOffset(0)]
    public TextEditingCandidatesEvent EditCandidates;

    [NativeName("text")]
    [FieldOffset(0)]
    public TextInputEvent Text;

    [NativeName("mdevice")]
    [FieldOffset(0)]
    public MouseDeviceEvent Mdevice;

    [NativeName("motion")]
    [FieldOffset(0)]
    public MouseMotionEvent Motion;

    [NativeName("button")]
    [FieldOffset(0)]
    public MouseButtonEvent Button;

    [NativeName("wheel")]
    [FieldOffset(0)]
    public MouseWheelEvent Wheel;

    [NativeName("jdevice")]
    [FieldOffset(0)]
    public JoyDeviceEvent Jdevice;

    [NativeName("jaxis")]
    [FieldOffset(0)]
    public JoyAxisEvent Jaxis;

    [NativeName("jball")]
    [FieldOffset(0)]
    public JoyBallEvent Jball;

    [NativeName("jhat")]
    [FieldOffset(0)]
    public JoyHatEvent Jhat;

    [NativeName("jbutton")]
    [FieldOffset(0)]
    public JoyButtonEvent Jbutton;

    [NativeName("jbattery")]
    [FieldOffset(0)]
    public JoyBatteryEvent Jbattery;

    [NativeName("gdevice")]
    [FieldOffset(0)]
    public GamepadDeviceEvent Gdevice;

    [NativeName("gaxis")]
    [FieldOffset(0)]
    public GamepadAxisEvent Gaxis;

    [NativeName("gbutton")]
    [FieldOffset(0)]
    public GamepadButtonEvent Gbutton;

    [NativeName("gtouchpad")]
    [FieldOffset(0)]
    public GamepadTouchpadEvent Gtouchpad;

    [NativeName("gsensor")]
    [FieldOffset(0)]
    public GamepadSensorEvent Gsensor;

    [NativeName("adevice")]
    [FieldOffset(0)]
    public AudioDeviceEvent Adevice;

    [NativeName("cdevice")]
    [FieldOffset(0)]
    public CameraDeviceEvent Cdevice;

    [NativeName("sensor")]
    [FieldOffset(0)]
    public SensorEvent Sensor;

    [NativeName("quit")]
    [FieldOffset(0)]
    public QuitEvent Quit;

    [NativeName("user")]
    [FieldOffset(0)]
    public UserEvent User;

    [NativeName("tfinger")]
    [FieldOffset(0)]
    public TouchFingerEvent Tfinger;

    [NativeName("pproximity")]
    [FieldOffset(0)]
    public PenProximityEvent Pproximity;

    [NativeName("ptouch")]
    [FieldOffset(0)]
    public PenTouchEvent Ptouch;

    [NativeName("pmotion")]
    [FieldOffset(0)]
    public PenMotionEvent Pmotion;

    [NativeName("pbutton")]
    [FieldOffset(0)]
    public PenButtonEvent Pbutton;

    [NativeName("paxis")]
    [FieldOffset(0)]
    public PenAxisEvent Paxis;

    [NativeName("render")]
    [FieldOffset(0)]
    public RenderEvent Render;

    [NativeName("drop")]
    [FieldOffset(0)]
    public DropEvent Drop;

    [NativeName("clipboard")]
    [FieldOffset(0)]
    public ClipboardEvent Clipboard;

    [NativeName("padding")]
    [FieldOffset(0)]
    public EventPadding Padding;
}
