// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrLocalDimmingModeMETA")]
    public enum LocalDimmingModeMETA : int
    {
        [Obsolete("Deprecated in favour of \"OffMeta\"")]
        [NativeName("Name", "XR_LOCAL_DIMMING_MODE_OFF_META")]
        LocalDimmingModeOffMeta = 0,
        [Obsolete("Deprecated in favour of \"OnMeta\"")]
        [NativeName("Name", "XR_LOCAL_DIMMING_MODE_ON_META")]
        LocalDimmingModeOnMeta = 1,
        [NativeName("Name", "XR_LOCAL_DIMMING_MODE_OFF_META")]
        OffMeta = 0,
        [NativeName("Name", "XR_LOCAL_DIMMING_MODE_ON_META")]
        OnMeta = 1,
    }
}
