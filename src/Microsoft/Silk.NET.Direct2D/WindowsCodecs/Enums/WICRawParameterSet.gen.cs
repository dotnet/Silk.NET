// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICRawParameterSet")]
    public enum WICRawParameterSet : int
    {
        [Obsolete("Deprecated in favour of \"AsShotParameterSet\"")]
        [NativeName("Name", "WICAsShotParameterSet")]
        WicasShotParameterSet = 0x1,
        [Obsolete("Deprecated in favour of \"UserAdjustedParameterSet\"")]
        [NativeName("Name", "WICUserAdjustedParameterSet")]
        WicuserAdjustedParameterSet = 0x2,
        [Obsolete("Deprecated in favour of \"AutoAdjustedParameterSet\"")]
        [NativeName("Name", "WICAutoAdjustedParameterSet")]
        WicautoAdjustedParameterSet = 0x3,
        [Obsolete("Deprecated in favour of \"AwparametersetForceDword\"")]
        [NativeName("Name", "WICRAWPARAMETERSET_FORCE_DWORD")]
        WicrawparametersetForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICAsShotParameterSet")]
        AsShotParameterSet = 0x1,
        [NativeName("Name", "WICUserAdjustedParameterSet")]
        UserAdjustedParameterSet = 0x2,
        [NativeName("Name", "WICAutoAdjustedParameterSet")]
        AutoAdjustedParameterSet = 0x3,
        [NativeName("Name", "WICRAWPARAMETERSET_FORCE_DWORD")]
        AwparametersetForceDword = 0x7FFFFFFF,
    }
}
