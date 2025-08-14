// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICHeifCompressionOption")]
    public enum HeifCompressionOption : int
    {
        [NativeName("Name", "WICHeifCompressionDontCare")]
        HeifCompressionDontCare = 0x0,
        [NativeName("Name", "WICHeifCompressionNone")]
        HeifCompressionNone = 0x1,
        [NativeName("Name", "WICHeifCompressionHEVC")]
        HeifCompressionHevc = 0x2,
        [NativeName("Name", "WICHeifCompressionAV1")]
        HeifCompressionAV1 = 0x3,
        [NativeName("Name", "WICHEIFCOMPRESSIONOPTION_FORCE_DWORD")]
        EifcompressionoptionForceDword = 0x7FFFFFFF,
    }
}
