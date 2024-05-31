// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public partial struct GamepadBinding
{
    public GamepadBindingType InputType;

    [NativeTypeName("__AnonymousRecord_SDL_gamepad_L196_C5")]
    public _input_e__Union Input;
    public GamepadBindingType OutputType;

    [NativeTypeName("__AnonymousRecord_SDL_gamepad_L216_C5")]
    public _output_e__Union Output;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _input_e__Union
    {
        [FieldOffset(0)]
        public int button;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_SDL_gamepad_L200_C9")]
        public _axis_e__Struct axis;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_SDL_gamepad_L207_C9")]
        public _hat_e__Struct hat;

        public partial struct _axis_e__Struct
        {
            public int axis;
            public int axis_min;
            public int axis_max;
        }

        public partial struct _hat_e__Struct
        {
            public int hat;
            public int hat_mask;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _output_e__Union
    {
        [FieldOffset(0)]
        public GamepadButton button;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_SDL_gamepad_L220_C9")]
        public _axis_e__Struct axis;

        public partial struct _axis_e__Struct
        {
            public GamepadAxis axis;
            public int axis_min;
            public int axis_max;
        }
    }
}
