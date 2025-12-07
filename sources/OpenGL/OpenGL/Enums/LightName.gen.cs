// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum LightName : uint
{
    Light0 = unchecked((uint)0x4000),
    Light1 = unchecked((uint)0x4001),
    Light2 = unchecked((uint)0x4002),
    Light3 = unchecked((uint)0x4003),
    Light4 = unchecked((uint)0x4004),
    Light5 = unchecked((uint)0x4005),
    Light6 = unchecked((uint)0x4006),
    Light7 = unchecked((uint)0x4007),
    FragmentLight0SGIX = unchecked((uint)0x840C),
    FragmentLight1SGIX = unchecked((uint)0x840D),
    FragmentLight2SGIX = unchecked((uint)0x840E),
    FragmentLight3SGIX = unchecked((uint)0x840F),
    FragmentLight4SGIX = unchecked((uint)0x8410),
    FragmentLight5SGIX = unchecked((uint)0x8411),
    FragmentLight6SGIX = unchecked((uint)0x8412),
    FragmentLight7SGIX = unchecked((uint)0x8413),
}
