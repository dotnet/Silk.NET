// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICPngGamaProperties")]
    public enum WICPngGamaProperties : int
    {
        [Obsolete("Deprecated in favour of \"Gamma\"")]
        [NativeName("Name", "WICPngGamaGamma")]
        WicpngGamaGamma = 0x1,
        [Obsolete("Deprecated in favour of \"PropertiesForceDword\"")]
        [NativeName("Name", "WICPngGamaProperties_FORCE_DWORD")]
        WicpngGamaPropertiesForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICPngGamaGamma")]
        Gamma = 0x1,
        [NativeName("Name", "WICPngGamaProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
