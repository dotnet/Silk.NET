// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [Flags]
    [NativeName("Name", "ClearBufferMask")]
    public enum ClearBufferMask : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT")]
        DepthBufferBit = 0x100,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT")]
        StencilBufferBit = 0x400,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT")]
        ColorBufferBit = 0x4000,
        [NativeName("Name", "GL_COVERAGE_BUFFER_BIT_NV")]
        CoverageBufferBitNV = 0x8000,
    }
}
