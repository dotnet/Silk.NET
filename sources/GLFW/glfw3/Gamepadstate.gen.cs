// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.GLFW;

public partial struct Gamepadstate
{
    [NativeTypeName("unsigned char[15]")]
    public _buttons_e__FixedBuffer Buttons;

    [NativeTypeName("float[6]")]
    public _axes_e__FixedBuffer Axes;

    [InlineArray(15)]
    public partial struct _buttons_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(6)]
    public partial struct _axes_e__FixedBuffer
    {
        public float e0;
    }
}
