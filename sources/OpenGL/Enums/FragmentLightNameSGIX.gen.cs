// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum FragmentLightNameSGIX : uint
{
    Light0 = 0x840C,
    Light1 = 0x840D,
    Light2 = 0x840E,
    Light3 = 0x840F,
    Light4 = 0x8410,
    Light5 = 0x8411,
    Light6 = 0x8412,
    Light7 = 0x8413
}
