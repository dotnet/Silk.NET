// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.MESA
{
    [NativeName("Name", "GLenum")]
    public enum MESA : int
    {
        [NativeName("Name", "EGL_DRM_BUFFER_FORMAT_MESA")]
        DrmBufferFormatMesa = 0x31D0,
        [NativeName("Name", "EGL_DRM_BUFFER_USE_MESA")]
        DrmBufferUseMesa = 0x31D1,
        [NativeName("Name", "EGL_DRM_BUFFER_FORMAT_ARGB32_MESA")]
        DrmBufferFormatArgb32Mesa = 0x31D2,
        [NativeName("Name", "EGL_DRM_BUFFER_MESA")]
        DrmBufferMesa = 0x31D3,
        [NativeName("Name", "EGL_DRM_BUFFER_STRIDE_MESA")]
        DrmBufferStrideMesa = 0x31D4,
        [NativeName("Name", "EGL_DRM_BUFFER_USE_SCANOUT_MESA")]
        DrmBufferUseScanoutMesa = 0x1,
        [NativeName("Name", "EGL_DRM_BUFFER_USE_SHARE_MESA")]
        DrmBufferUseShareMesa = 0x2,
        [NativeName("Name", "EGL_DRM_BUFFER_USE_CURSOR_MESA")]
        DrmBufferUseCursorMesa = 0x4,
        [NativeName("Name", "EGL_PLATFORM_GBM_MESA")]
        PlatformGbmMesa = 0x31D7,
        [NativeName("Name", "EGL_PLATFORM_SURFACELESS_MESA")]
        PlatformSurfacelessMesa = 0x31DD,
    }
}
