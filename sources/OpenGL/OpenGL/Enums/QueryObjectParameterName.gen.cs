// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum QueryObjectParameterName : uint
{
    Result = unchecked((uint)0x8866),
    ResultAvailable = unchecked((uint)0x8867),
    ResultNoWait = unchecked((uint)0x9194),
    Target = unchecked((uint)0x82EA),
}
