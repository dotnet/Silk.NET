// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.TIZEN
{
    [NativeName("Name", "GLenum")]
    public enum TIZEN : int
    {
        [NativeName("Name", "EGL_NATIVE_BUFFER_TIZEN")]
        NativeBufferTizen = 0x32A0,
        [NativeName("Name", "EGL_NATIVE_SURFACE_TIZEN")]
        NativeSurfaceTizen = 0x32A1,
    }
}
