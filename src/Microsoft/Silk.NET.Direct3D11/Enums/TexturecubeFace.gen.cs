// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TEXTURECUBE_FACE")]
    public enum TexturecubeFace : int
    {
        [NativeName("Name", "D3D11_TEXTURECUBE_FACE_POSITIVE_X")]
        TexturecubeFacePositiveX = 0x0,
        [NativeName("Name", "D3D11_TEXTURECUBE_FACE_NEGATIVE_X")]
        TexturecubeFaceNegativeX = 0x1,
        [NativeName("Name", "D3D11_TEXTURECUBE_FACE_POSITIVE_Y")]
        TexturecubeFacePositiveY = 0x2,
        [NativeName("Name", "D3D11_TEXTURECUBE_FACE_NEGATIVE_Y")]
        TexturecubeFaceNegativeY = 0x3,
        [NativeName("Name", "D3D11_TEXTURECUBE_FACE_POSITIVE_Z")]
        TexturecubeFacePositiveZ = 0x4,
        [NativeName("Name", "D3D11_TEXTURECUBE_FACE_NEGATIVE_Z")]
        TexturecubeFaceNegativeZ = 0x5,
    }
}
