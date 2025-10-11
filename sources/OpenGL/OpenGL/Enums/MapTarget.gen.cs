// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum MapTarget : uint
{
    Map1Color4 = unchecked((uint)0x0D90),
    Map1Index = unchecked((uint)0x0D91),
    Map1Normal = unchecked((uint)0x0D92),
    Map1TextureCoord1 = unchecked((uint)0x0D93),
    Map1TextureCoord2 = unchecked((uint)0x0D94),
    Map1TextureCoord3 = unchecked((uint)0x0D95),
    Map1TextureCoord4 = unchecked((uint)0x0D96),
    Map1Vertex3 = unchecked((uint)0x0D97),
    Map1Vertex4 = unchecked((uint)0x0D98),
    Map2Color4 = unchecked((uint)0x0DB0),
    Map2Index = unchecked((uint)0x0DB1),
    Map2Normal = unchecked((uint)0x0DB2),
    Map2TextureCoord1 = unchecked((uint)0x0DB3),
    Map2TextureCoord2 = unchecked((uint)0x0DB4),
    Map2TextureCoord3 = unchecked((uint)0x0DB5),
    Map2TextureCoord4 = unchecked((uint)0x0DB6),
    Map2Vertex3 = unchecked((uint)0x0DB7),
    Map2Vertex4 = unchecked((uint)0x0DB8),
    GeometryDeformationSGIX = unchecked((uint)0x8194),
    TextureDeformationSGIX = unchecked((uint)0x8195),
}
