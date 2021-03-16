// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_OUTDUPL_FLAG")]
    public enum OutduplFlag : int
    {
        [NativeName("Name", "DXGI_OUTDUPL_COMPOSITED_UI_CAPTURE_ONLY")]
        OutduplCompositedUICaptureOnly = 0x1,
    }
}
