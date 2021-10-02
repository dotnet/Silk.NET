// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PixelStoreSubsampleRate")]
    public enum PixelStoreSubsampleRate : int
    {
        [NativeName("Name", "GL_PIXEL_SUBSAMPLE_4444_SGIX")]
        PixelSubsample4444Sgix = 0x85A2,
        [NativeName("Name", "GL_PIXEL_SUBSAMPLE_2424_SGIX")]
        PixelSubsample2424Sgix = 0x85A3,
        [NativeName("Name", "GL_PIXEL_SUBSAMPLE_4242_SGIX")]
        PixelSubsample4242Sgix = 0x85A4,
    }
}
