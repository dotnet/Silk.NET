// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrPassthroughPreferenceFlagsMETA")]
    public enum PassthroughPreferenceFlagsMETA : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DefaultToActiveBitMeta\"")]
        [NativeName("Name", "XR_PASSTHROUGH_PREFERENCE_DEFAULT_TO_ACTIVE_BIT_META")]
        PassthroughPreferenceDefaultToActiveBitMeta = 1,
        [NativeName("Name", "XR_PASSTHROUGH_PREFERENCE_DEFAULT_TO_ACTIVE_BIT_META")]
        DefaultToActiveBitMeta = 1,
    }
}
