// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.WL
{
    [NativeName("Name", "GLenum")]
    public enum WL : int
    {
        [NativeName("Name", "EGL_WAYLAND_BUFFER_WL")]
        WaylandBufferWL = 0x31D5,
        [NativeName("Name", "EGL_WAYLAND_PLANE_WL")]
        WaylandPlaneWL = 0x31D6,
        [NativeName("Name", "EGL_TEXTURE_Y_U_V_WL")]
        TextureYUVWL = 0x31D7,
        [NativeName("Name", "EGL_TEXTURE_Y_XUXV_WL")]
        TextureYXuxvWL = 0x31D9,
        [NativeName("Name", "EGL_TEXTURE_EXTERNAL_WL")]
        TextureExternalWL = 0x31DA,
        [NativeName("Name", "EGL_WAYLAND_Y_INVERTED_WL")]
        WaylandYInvertedWL = 0x31DB,
    }
}
