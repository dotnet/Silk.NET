// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.MESA
{
    public enum MESA
    {
        DrmBufferFormatMesa = 0x31D0,
        DrmBufferUseMesa = 0x31D1,
        DrmBufferFormatArgb32Mesa = 0x31D2,
        DrmBufferMesa = 0x31D3,
        DrmBufferStrideMesa = 0x31D4,
        DrmBufferUseScanoutMesa = 0x1,
        DrmBufferUseShareMesa = 0x2,
        DrmBufferUseCursorMesa = 0x4,
        PlatformGbmMesa = 0x31D7,
        PlatformSurfacelessMesa = 0x31DD,
    }
}
