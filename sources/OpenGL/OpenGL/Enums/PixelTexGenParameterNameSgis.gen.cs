// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "SGIS", 0)]
[NativeName("PixelTexGenParameterNameSGIS")]
[Transformed]
public enum PixelTexGenParameterNameSgis : uint
{
    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS")]
    RgbSourcesgis = unchecked((uint)0x8354),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS")]
    AlphaSourcesgis = unchecked((uint)0x8355),
}
