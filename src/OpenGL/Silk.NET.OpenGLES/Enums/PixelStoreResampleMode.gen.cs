// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PixelStoreResampleMode")]
    public enum PixelStoreResampleMode : int
    {
        [Obsolete("Deprecated in favour of \"DecimateSgix\"")]
        [NativeName("Name", "GL_RESAMPLE_DECIMATE_SGIX")]
        ResampleDecimateSgix = 0x8430,
        [Obsolete("Deprecated in favour of \"ReplicateSgix\"")]
        [NativeName("Name", "GL_RESAMPLE_REPLICATE_SGIX")]
        ResampleReplicateSgix = 0x8433,
        [Obsolete("Deprecated in favour of \"ZeroFillSgix\"")]
        [NativeName("Name", "GL_RESAMPLE_ZERO_FILL_SGIX")]
        ResampleZeroFillSgix = 0x8434,
        [NativeName("Name", "GL_RESAMPLE_DECIMATE_SGIX")]
        DecimateSgix = 0x8430,
        [NativeName("Name", "GL_RESAMPLE_REPLICATE_SGIX")]
        ReplicateSgix = 0x8433,
        [NativeName("Name", "GL_RESAMPLE_ZERO_FILL_SGIX")]
        ZeroFillSgix = 0x8434,
    }
}
