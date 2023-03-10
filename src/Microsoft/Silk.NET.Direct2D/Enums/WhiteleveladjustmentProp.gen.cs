// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_WHITELEVELADJUSTMENT_PROP")]
    public enum WhiteleveladjustmentProp : int
    {
        [Obsolete("Deprecated in favour of \"InputWhiteLevel\"")]
        [NativeName("Name", "D2D1_WHITELEVELADJUSTMENT_PROP_INPUT_WHITE_LEVEL")]
        WhiteleveladjustmentPropInputWhiteLevel = 0x0,
        [Obsolete("Deprecated in favour of \"OutputWhiteLevel\"")]
        [NativeName("Name", "D2D1_WHITELEVELADJUSTMENT_PROP_OUTPUT_WHITE_LEVEL")]
        WhiteleveladjustmentPropOutputWhiteLevel = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_WHITELEVELADJUSTMENT_PROP_FORCE_DWORD")]
        WhiteleveladjustmentPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_WHITELEVELADJUSTMENT_PROP_INPUT_WHITE_LEVEL")]
        InputWhiteLevel = 0x0,
        [NativeName("Name", "D2D1_WHITELEVELADJUSTMENT_PROP_OUTPUT_WHITE_LEVEL")]
        OutputWhiteLevel = 0x1,
        [NativeName("Name", "D2D1_WHITELEVELADJUSTMENT_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
