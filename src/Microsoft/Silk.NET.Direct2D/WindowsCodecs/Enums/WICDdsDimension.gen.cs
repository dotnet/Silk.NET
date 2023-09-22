// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICDdsDimension")]
    public enum WICDdsDimension : int
    {
        [Obsolete("Deprecated in favour of \"DdsTexture1D\"")]
        [NativeName("Name", "WICDdsTexture1D")]
        WicddsTexture1D = 0x0,
        [Obsolete("Deprecated in favour of \"DdsTexture2D\"")]
        [NativeName("Name", "WICDdsTexture2D")]
        WicddsTexture2D = 0x1,
        [Obsolete("Deprecated in favour of \"DdsTexture3D\"")]
        [NativeName("Name", "WICDdsTexture3D")]
        WicddsTexture3D = 0x2,
        [Obsolete("Deprecated in favour of \"DdsTextureCube\"")]
        [NativeName("Name", "WICDdsTextureCube")]
        WicddsTextureCube = 0x3,
        [Obsolete("Deprecated in favour of \"DstextureForceDword\"")]
        [NativeName("Name", "WICDDSTEXTURE_FORCE_DWORD")]
        WicddstextureForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICDdsTexture1D")]
        DdsTexture1D = 0x0,
        [NativeName("Name", "WICDdsTexture2D")]
        DdsTexture2D = 0x1,
        [NativeName("Name", "WICDdsTexture3D")]
        DdsTexture3D = 0x2,
        [NativeName("Name", "WICDdsTextureCube")]
        DdsTextureCube = 0x3,
        [NativeName("Name", "WICDDSTEXTURE_FORCE_DWORD")]
        DstextureForceDword = 0x7FFFFFFF,
    }
}
