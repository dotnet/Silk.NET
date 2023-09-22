// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICJpegScanType")]
    public enum WICJpegScanType : int
    {
        [Obsolete("Deprecated in favour of \"Interleaved\"")]
        [NativeName("Name", "WICJpegScanTypeInterleaved")]
        WicjpegScanTypeInterleaved = 0x0,
        [Obsolete("Deprecated in favour of \"PlanarComponents\"")]
        [NativeName("Name", "WICJpegScanTypePlanarComponents")]
        WicjpegScanTypePlanarComponents = 0x1,
        [Obsolete("Deprecated in favour of \"Progressive\"")]
        [NativeName("Name", "WICJpegScanTypeProgressive")]
        WicjpegScanTypeProgressive = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "WICJpegScanType_FORCE_DWORD")]
        WicjpegScanTypeForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICJpegScanTypeInterleaved")]
        Interleaved = 0x0,
        [NativeName("Name", "WICJpegScanTypePlanarComponents")]
        PlanarComponents = 0x1,
        [NativeName("Name", "WICJpegScanTypeProgressive")]
        Progressive = 0x2,
        [NativeName("Name", "WICJpegScanType_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
