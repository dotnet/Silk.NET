// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICTiffCompressionOption")]
    public enum WICTiffCompressionOption : int
    {
        [Obsolete("Deprecated in favour of \"TiffCompressionDontCare\"")]
        [NativeName("Name", "WICTiffCompressionDontCare")]
        WictiffCompressionDontCare = 0x0,
        [Obsolete("Deprecated in favour of \"TiffCompressionNone\"")]
        [NativeName("Name", "WICTiffCompressionNone")]
        WictiffCompressionNone = 0x1,
        [Obsolete("Deprecated in favour of \"TiffCompressionCcitt3\"")]
        [NativeName("Name", "WICTiffCompressionCCITT3")]
        WictiffCompressionCcitt3 = 0x2,
        [Obsolete("Deprecated in favour of \"TiffCompressionCcitt4\"")]
        [NativeName("Name", "WICTiffCompressionCCITT4")]
        WictiffCompressionCcitt4 = 0x3,
        [Obsolete("Deprecated in favour of \"TiffCompressionLzw\"")]
        [NativeName("Name", "WICTiffCompressionLZW")]
        WictiffCompressionLzw = 0x4,
        [Obsolete("Deprecated in favour of \"TiffCompressionRle\"")]
        [NativeName("Name", "WICTiffCompressionRLE")]
        WictiffCompressionRle = 0x5,
        [Obsolete("Deprecated in favour of \"TiffCompressionZip\"")]
        [NativeName("Name", "WICTiffCompressionZIP")]
        WictiffCompressionZip = 0x6,
        [Obsolete("Deprecated in favour of \"TiffCompressionLzwhDifferencing\"")]
        [NativeName("Name", "WICTiffCompressionLZWHDifferencing")]
        WictiffCompressionLzwhdifferencing = 0x7,
        [Obsolete("Deprecated in favour of \"IffcompressionoptionForceDword\"")]
        [NativeName("Name", "WICTIFFCOMPRESSIONOPTION_FORCE_DWORD")]
        WictiffcompressionoptionForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICTiffCompressionDontCare")]
        TiffCompressionDontCare = 0x0,
        [NativeName("Name", "WICTiffCompressionNone")]
        TiffCompressionNone = 0x1,
        [NativeName("Name", "WICTiffCompressionCCITT3")]
        TiffCompressionCcitt3 = 0x2,
        [NativeName("Name", "WICTiffCompressionCCITT4")]
        TiffCompressionCcitt4 = 0x3,
        [NativeName("Name", "WICTiffCompressionLZW")]
        TiffCompressionLzw = 0x4,
        [NativeName("Name", "WICTiffCompressionRLE")]
        TiffCompressionRle = 0x5,
        [NativeName("Name", "WICTiffCompressionZIP")]
        TiffCompressionZip = 0x6,
        [NativeName("Name", "WICTiffCompressionLZWHDifferencing")]
        TiffCompressionLzwhDifferencing = 0x7,
        [NativeName("Name", "WICTIFFCOMPRESSIONOPTION_FORCE_DWORD")]
        IffcompressionoptionForceDword = 0x7FFFFFFF,
    }
}
