// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PixelStoreSubsampleRate")]
    public enum PixelStoreSubsampleRate : int
    {
        [Obsolete("Deprecated in favour of \"Subsample4444Sgix\"")]
        [NativeName("Name", "GL_PIXEL_SUBSAMPLE_4444_SGIX")]
        PixelSubsample4444Sgix = 0x85A2,
        [Obsolete("Deprecated in favour of \"Subsample2424Sgix\"")]
        [NativeName("Name", "GL_PIXEL_SUBSAMPLE_2424_SGIX")]
        PixelSubsample2424Sgix = 0x85A3,
        [Obsolete("Deprecated in favour of \"Subsample4242Sgix\"")]
        [NativeName("Name", "GL_PIXEL_SUBSAMPLE_4242_SGIX")]
        PixelSubsample4242Sgix = 0x85A4,
        [NativeName("Name", "GL_PIXEL_SUBSAMPLE_4444_SGIX")]
        Subsample4444Sgix = 0x85A2,
        [NativeName("Name", "GL_PIXEL_SUBSAMPLE_2424_SGIX")]
        Subsample2424Sgix = 0x85A3,
        [NativeName("Name", "GL_PIXEL_SUBSAMPLE_4242_SGIX")]
        Subsample4242Sgix = 0x85A4,
    }
}
