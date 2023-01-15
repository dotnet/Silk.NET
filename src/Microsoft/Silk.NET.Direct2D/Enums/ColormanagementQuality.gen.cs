// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_COLORMANAGEMENT_QUALITY")]
    public enum ColormanagementQuality : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Proof\"")]
        [NativeName("Name", "D2D1_COLORMANAGEMENT_QUALITY_PROOF")]
        ColormanagementQualityProof = 0x0,
        [Obsolete("Deprecated in favour of \"Normal\"")]
        [NativeName("Name", "D2D1_COLORMANAGEMENT_QUALITY_NORMAL")]
        ColormanagementQualityNormal = 0x1,
        [Obsolete("Deprecated in favour of \"Best\"")]
        [NativeName("Name", "D2D1_COLORMANAGEMENT_QUALITY_BEST")]
        ColormanagementQualityBest = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_COLORMANAGEMENT_QUALITY_FORCE_DWORD")]
        ColormanagementQualityForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_COLORMANAGEMENT_QUALITY_PROOF")]
        Proof = 0x0,
        [NativeName("Name", "D2D1_COLORMANAGEMENT_QUALITY_NORMAL")]
        Normal = 0x1,
        [NativeName("Name", "D2D1_COLORMANAGEMENT_QUALITY_BEST")]
        Best = 0x2,
        [NativeName("Name", "D2D1_COLORMANAGEMENT_QUALITY_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
