// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_VERTEX_OPTIONS")]
    public enum VertexOptions : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D2D1_VERTEX_OPTIONS_NONE")]
        VertexOptionsNone = 0x0,
        [Obsolete("Deprecated in favour of \"DONotClear\"")]
        [NativeName("Name", "D2D1_VERTEX_OPTIONS_DO_NOT_CLEAR")]
        VertexOptionsDONotClear = 0x1,
        [Obsolete("Deprecated in favour of \"UseDepthBuffer\"")]
        [NativeName("Name", "D2D1_VERTEX_OPTIONS_USE_DEPTH_BUFFER")]
        VertexOptionsUseDepthBuffer = 0x2,
        [Obsolete("Deprecated in favour of \"AssumeNoOverlap\"")]
        [NativeName("Name", "D2D1_VERTEX_OPTIONS_ASSUME_NO_OVERLAP")]
        VertexOptionsAssumeNoOverlap = 0x4,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_VERTEX_OPTIONS_FORCE_DWORD")]
        VertexOptionsForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
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
