// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.WGL3DFX
{
    [NativeName("Name", "GLenum")]
    public enum WGL3DFX : int
    {
        [Obsolete("Deprecated in favour of \"Buffers3Dfx\"")]
        [NativeName("Name", "WGL_SAMPLE_BUFFERS_3DFX")]
        SampleBuffers3Dfx = 0x2060,
        [Obsolete("Deprecated in favour of \"WGL3Dfx\"")]
        [NativeName("Name", "WGL_SAMPLES_3DFX")]
        Samples3Dfx = 0x2061,
        [NativeName("Name", "WGL_SAMPLE_BUFFERS_3DFX")]
        Buffers3Dfx = 0x2060,
        [NativeName("Name", "WGL_SAMPLES_3DFX")]
        WGL3Dfx = 0x2061,
    }
}
