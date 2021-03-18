// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.OML
{
    [NativeName("Name", "GLenum")]
    public enum OML : int
    {
        [NativeName("Name", "GL_INTERLACE_OML")]
        InterlaceOml = 0x8980,
        [NativeName("Name", "GL_INTERLACE_READ_OML")]
        InterlaceReadOml = 0x8981,
        [NativeName("Name", "GL_PACK_RESAMPLE_OML")]
        PackResampleOml = 0x8984,
        [NativeName("Name", "GL_UNPACK_RESAMPLE_OML")]
        UnpackResampleOml = 0x8985,
        [NativeName("Name", "GL_RESAMPLE_REPLICATE_OML")]
        ResampleReplicateOml = 0x8986,
        [NativeName("Name", "GL_RESAMPLE_ZERO_FILL_OML")]
        ResampleZeroFillOml = 0x8987,
        [NativeName("Name", "GL_RESAMPLE_AVERAGE_OML")]
        ResampleAverageOml = 0x8988,
        [NativeName("Name", "GL_RESAMPLE_DECIMATE_OML")]
        ResampleDecimateOml = 0x8989,
        [NativeName("Name", "GL_FORMAT_SUBSAMPLE_24_24_OML")]
        FormatSubsample2424Oml = 0x8982,
        [NativeName("Name", "GL_FORMAT_SUBSAMPLE_244_244_OML")]
        FormatSubsample244244Oml = 0x8983,
    }
}
