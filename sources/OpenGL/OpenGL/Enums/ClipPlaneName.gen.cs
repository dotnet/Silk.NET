// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ClipPlaneName : uint
{
    Plane0 = unchecked((uint)0x3000),
    Plane1 = unchecked((uint)0x3001),
    Plane2 = unchecked((uint)0x3002),
    Plane3 = unchecked((uint)0x3003),
    Plane4 = unchecked((uint)0x3004),
    Plane5 = unchecked((uint)0x3005),
    Distance0 = unchecked((uint)0x3000),
    Distance1 = unchecked((uint)0x3001),
    Distance2 = unchecked((uint)0x3002),
    Distance3 = unchecked((uint)0x3003),
    Distance4 = unchecked((uint)0x3004),
    Distance5 = unchecked((uint)0x3005),
    Distance6 = unchecked((uint)0x3006),
    Distance7 = unchecked((uint)0x3007),
}
