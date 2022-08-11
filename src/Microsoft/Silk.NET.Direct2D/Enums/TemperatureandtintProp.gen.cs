// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_TEMPERATUREANDTINT_PROP")]
    public enum TemperatureandtintProp : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Temperature\"")]
        [NativeName("Name", "D2D1_TEMPERATUREANDTINT_PROP_TEMPERATURE")]
        TemperatureandtintPropTemperature = 0x0,
        [Obsolete("Deprecated in favour of \"Tint\"")]
        [NativeName("Name", "D2D1_TEMPERATUREANDTINT_PROP_TINT")]
        TemperatureandtintPropTint = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_TEMPERATUREANDTINT_PROP_FORCE_DWORD")]
        TemperatureandtintPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_TEMPERATUREANDTINT_PROP_TEMPERATURE")]
        Temperature = 0x0,
        [NativeName("Name", "D2D1_TEMPERATUREANDTINT_PROP_TINT")]
        Tint = 0x1,
        [NativeName("Name", "D2D1_TEMPERATUREANDTINT_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
