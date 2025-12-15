// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_DEBUG_FEATURE")]
    public enum DebugFeature : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_DEBUG_FEATURE_NONE")]
        DebugFeatureNone = 0x0,
        [Obsolete("Deprecated in favour of \"AllowBehaviorChangingDebugAids\"")]
        [NativeName("Name", "D3D12_DEBUG_FEATURE_ALLOW_BEHAVIOR_CHANGING_DEBUG_AIDS")]
        DebugFeatureAllowBehaviorChangingDebugAids = 0x1,
        [Obsolete("Deprecated in favour of \"ConservativeResourceStateTracking\"")]
        [NativeName("Name", "D3D12_DEBUG_FEATURE_CONSERVATIVE_RESOURCE_STATE_TRACKING")]
        DebugFeatureConservativeResourceStateTracking = 0x2,
        [Obsolete("Deprecated in favour of \"DisableVirtualizedBundlesValidation\"")]
        [NativeName("Name", "D3D12_DEBUG_FEATURE_DISABLE_VIRTUALIZED_BUNDLES_VALIDATION")]
        DebugFeatureDisableVirtualizedBundlesValidation = 0x4,
        [Obsolete("Deprecated in favour of \"EmulateWindows7\"")]
        [NativeName("Name", "D3D12_DEBUG_FEATURE_EMULATE_WINDOWS7")]
        DebugFeatureEmulateWindows7 = 0x8,
        [NativeName("Name", "D3D12_DEBUG_FEATURE_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_DEBUG_FEATURE_ALLOW_BEHAVIOR_CHANGING_DEBUG_AIDS")]
        AllowBehaviorChangingDebugAids = 0x1,
        [NativeName("Name", "D3D12_DEBUG_FEATURE_CONSERVATIVE_RESOURCE_STATE_TRACKING")]
        ConservativeResourceStateTracking = 0x2,
        [NativeName("Name", "D3D12_DEBUG_FEATURE_DISABLE_VIRTUALIZED_BUNDLES_VALIDATION")]
        DisableVirtualizedBundlesValidation = 0x4,
        [NativeName("Name", "D3D12_DEBUG_FEATURE_EMULATE_WINDOWS7")]
        EmulateWindows7 = 0x8,
    }
}
