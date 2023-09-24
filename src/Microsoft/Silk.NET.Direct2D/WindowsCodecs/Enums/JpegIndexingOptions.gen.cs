// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICJpegIndexingOptions")]
    public enum JpegIndexingOptions : int
    {
        [NativeName("Name", "WICJpegIndexingOptionsGenerateOnDemand")]
        GenerateOnDemand = 0x0,
        [NativeName("Name", "WICJpegIndexingOptionsGenerateOnLoad")]
        GenerateOnLoad = 0x1,
        [NativeName("Name", "WICJpegIndexingOptions_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
