// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum MaterialParameter : uint
{
    Ambient = unchecked((uint)0x1200),
    Diffuse = unchecked((uint)0x1201),
    Specular = unchecked((uint)0x1202),
    Emission = unchecked((uint)0x1600),
    Shininess = unchecked((uint)0x1601),
    AmbientAndDiffuse = unchecked((uint)0x1602),
    ColorIndexes = unchecked((uint)0x1603),
}
