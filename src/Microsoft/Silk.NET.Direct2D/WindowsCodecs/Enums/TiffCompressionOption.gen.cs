// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICTiffCompressionOption")]
    public enum TiffCompressionOption : int
    {
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
