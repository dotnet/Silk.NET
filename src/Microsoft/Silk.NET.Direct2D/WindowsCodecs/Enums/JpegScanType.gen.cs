// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICJpegScanType")]
    public enum JpegScanType : int
    {
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
