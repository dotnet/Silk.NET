// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum FragmentOp3ATI : uint
{
    Mad = unchecked((uint)0x8968),
    Lerp = unchecked((uint)0x8969),
    Cnd = unchecked((uint)0x896A),
    Cnd0 = unchecked((uint)0x896B),
    Dot2Add = unchecked((uint)0x896C),
}
