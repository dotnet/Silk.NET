// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_OUTDUPL_FLAG")]
    public enum OutduplFlag : int
    {
        [Obsolete("Deprecated in favour of \"CompositedUICaptureOnly\"")]
        [NativeName("Name", "DXGI_OUTDUPL_COMPOSITED_UI_CAPTURE_ONLY")]
        OutduplCompositedUICaptureOnly = 0x1,
        [NativeName("Name", "DXGI_OUTDUPL_COMPOSITED_UI_CAPTURE_ONLY")]
        CompositedUICaptureOnly = 0x1,
    }
}
