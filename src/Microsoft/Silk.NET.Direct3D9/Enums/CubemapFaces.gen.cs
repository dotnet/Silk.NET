// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DCUBEMAP_FACES")]
    public enum CubemapFaces : int
    {
        [NativeName("Name", "D3DCUBEMAP_FACE_POSITIVE_X")]
        CubemapFacePositiveX = 0x0,
        [NativeName("Name", "D3DCUBEMAP_FACE_NEGATIVE_X")]
        CubemapFaceNegativeX = 0x1,
        [NativeName("Name", "D3DCUBEMAP_FACE_POSITIVE_Y")]
        CubemapFacePositiveY = 0x2,
        [NativeName("Name", "D3DCUBEMAP_FACE_NEGATIVE_Y")]
        CubemapFaceNegativeY = 0x3,
        [NativeName("Name", "D3DCUBEMAP_FACE_POSITIVE_Z")]
        CubemapFacePositiveZ = 0x4,
        [NativeName("Name", "D3DCUBEMAP_FACE_NEGATIVE_Z")]
        CubemapFaceNegativeZ = 0x5,
        [NativeName("Name", "D3DCUBEMAP_FACE_FORCE_DWORD")]
        CubemapFaceForceDword = 0x7FFFFFFF,
    }
}
