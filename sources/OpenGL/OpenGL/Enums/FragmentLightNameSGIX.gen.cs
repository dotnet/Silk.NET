// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum FragmentLightNameSGIX : uint
{
    Light0 = unchecked((uint)0x840C),
    Light1 = unchecked((uint)0x840D),
    Light2 = unchecked((uint)0x840E),
    Light3 = unchecked((uint)0x840F),
    Light4 = unchecked((uint)0x8410),
    Light5 = unchecked((uint)0x8411),
    Light6 = unchecked((uint)0x8412),
    Light7 = unchecked((uint)0x8413),
}
