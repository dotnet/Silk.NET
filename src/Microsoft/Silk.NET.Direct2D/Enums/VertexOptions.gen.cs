// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_VERTEX_OPTIONS")]
    public enum VertexOptions : int
    {
        [NativeName("Name", "D2D1_VERTEX_OPTIONS_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_VERTEX_OPTIONS_DO_NOT_CLEAR")]
        DONotClear = 0x1,
        [NativeName("Name", "D2D1_VERTEX_OPTIONS_USE_DEPTH_BUFFER")]
        UseDepthBuffer = 0x2,
        [NativeName("Name", "D2D1_VERTEX_OPTIONS_ASSUME_NO_OVERLAP")]
        AssumeNoOverlap = 0x4,
        [NativeName("Name", "D2D1_VERTEX_OPTIONS_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
