// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.ANGLE
{
    [NativeName("Name", "GLenum")]
    public enum ANGLE : int
    {
        [NativeName("Name", "EGL_D3D_TEXTURE_2D_SHARE_HANDLE_ANGLE")]
        D3DTexture2DShareHandleAngle = 0x3200,
        [NativeName("Name", "EGL_D3D9_DEVICE_ANGLE")]
        D3D9DeviceAngle = 0x33A0,
        [NativeName("Name", "EGL_D3D11_DEVICE_ANGLE")]
        D3D11DeviceAngle = 0x33A1,
        [NativeName("Name", "EGL_FIXED_SIZE_ANGLE")]
        FixedSizeAngle = 0x3201,
    }
}
