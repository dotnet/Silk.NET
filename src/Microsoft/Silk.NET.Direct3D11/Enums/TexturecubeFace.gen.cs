// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TEXTURECUBE_FACE")]
    public enum TexturecubeFace : int
    {
        [Obsolete("Deprecated in favour of \"PositiveX\"")]
        [NativeName("Name", "D3D11_TEXTURECUBE_FACE_POSITIVE_X")]
        TexturecubeFacePositiveX = 0x0,
        [Obsolete("Deprecated in favour of \"NegativeX\"")]
        [NativeName("Name", "D3D11_TEXTURECUBE_FACE_NEGATIVE_X")]
        TexturecubeFaceNegativeX = 0x1,
        [Obsolete("Deprecated in favour of \"PositiveY\"")]
        [NativeName("Name", "D3D11_TEXTURECUBE_FACE_POSITIVE_Y")]
        TexturecubeFacePositiveY = 0x2,
        [Obsolete("Deprecated in favour of \"NegativeY\"")]
        [NativeName("Name", "D3D11_TEXTURECUBE_FACE_NEGATIVE_Y")]
        TexturecubeFaceNegativeY = 0x3,
        [Obsolete("Deprecated in favour of \"PositiveZ\"")]
        [NativeName("Name", "D3D11_TEXTURECUBE_FACE_POSITIVE_Z")]
        TexturecubeFacePositiveZ = 0x4,
        [Obsolete("Deprecated in favour of \"NegativeZ\"")]
        [NativeName("Name", "D3D11_TEXTURECUBE_FACE_NEGATIVE_Z")]
        TexturecubeFaceNegativeZ = 0x5,
        [NativeName("Name", "D3D11_TEXTURECUBE_FACE_POSITIVE_X")]
        PositiveX = 0x0,
        [NativeName("Name", "D3D11_TEXTURECUBE_FACE_NEGATIVE_X")]
        NegativeX = 0x1,
        [NativeName("Name", "D3D11_TEXTURECUBE_FACE_POSITIVE_Y")]
        PositiveY = 0x2,
        [NativeName("Name", "D3D11_TEXTURECUBE_FACE_NEGATIVE_Y")]
        NegativeY = 0x3,
        [NativeName("Name", "D3D11_TEXTURECUBE_FACE_POSITIVE_Z")]
        PositiveZ = 0x4,
        [NativeName("Name", "D3D11_TEXTURECUBE_FACE_NEGATIVE_Z")]
        NegativeZ = 0x5,
    }
}
