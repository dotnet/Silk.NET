// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICJpegYCrCbSubsamplingOption")]
    public enum WICJpegYCrCbSubsamplingOption : int
    {
        [Obsolete("Deprecated in favour of \"JpegYCrCbSubsamplingDefault\"")]
        [NativeName("Name", "WICJpegYCrCbSubsamplingDefault")]
        WicjpegYCrCbSubsamplingDefault = 0x0,
        [Obsolete("Deprecated in favour of \"JpegYCrCbSubsampling420\"")]
        [NativeName("Name", "WICJpegYCrCbSubsampling420")]
        WicjpegYCrCbSubsampling420 = 0x1,
        [Obsolete("Deprecated in favour of \"JpegYCrCbSubsampling422\"")]
        [NativeName("Name", "WICJpegYCrCbSubsampling422")]
        WicjpegYCrCbSubsampling422 = 0x2,
        [Obsolete("Deprecated in favour of \"JpegYCrCbSubsampling444\"")]
        [NativeName("Name", "WICJpegYCrCbSubsampling444")]
        WicjpegYCrCbSubsampling444 = 0x3,
        [Obsolete("Deprecated in favour of \"JpegYCrCbSubsampling440\"")]
        [NativeName("Name", "WICJpegYCrCbSubsampling440")]
        WicjpegYCrCbSubsampling440 = 0x4,
        [Obsolete("Deprecated in favour of \"PegycrcbsubsamplingForceDword\"")]
        [NativeName("Name", "WICJPEGYCRCBSUBSAMPLING_FORCE_DWORD")]
        WicjpegycrcbsubsamplingForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICJpegYCrCbSubsamplingDefault")]
        JpegYCrCbSubsamplingDefault = 0x0,
        [NativeName("Name", "WICJpegYCrCbSubsampling420")]
        JpegYCrCbSubsampling420 = 0x1,
        [NativeName("Name", "WICJpegYCrCbSubsampling422")]
        JpegYCrCbSubsampling422 = 0x2,
        [NativeName("Name", "WICJpegYCrCbSubsampling444")]
        JpegYCrCbSubsampling444 = 0x3,
        [NativeName("Name", "WICJpegYCrCbSubsampling440")]
        JpegYCrCbSubsampling440 = 0x4,
        [NativeName("Name", "WICJPEGYCRCBSUBSAMPLING_FORCE_DWORD")]
        PegycrcbsubsamplingForceDword = 0x7FFFFFFF,
    }
}
