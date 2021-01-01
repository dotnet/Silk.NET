// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DEBUG_FEATURE")]
    public enum DebugFeature : int
    {
        [NativeName("Name", "D3D12_DEBUG_FEATURE_NONE")]
        DebugFeatureNone = 0x0,
        [NativeName("Name", "D3D12_DEBUG_FEATURE_ALLOW_BEHAVIOR_CHANGING_DEBUG_AIDS")]
        DebugFeatureAllowBehaviorChangingDebugAids = 0x1,
        [NativeName("Name", "D3D12_DEBUG_FEATURE_CONSERVATIVE_RESOURCE_STATE_TRACKING")]
        DebugFeatureConservativeResourceStateTracking = 0x2,
        [NativeName("Name", "D3D12_DEBUG_FEATURE_DISABLE_VIRTUALIZED_BUNDLES_VALIDATION")]
        DebugFeatureDisableVirtualizedBundlesValidation = 0x4,
        [NativeName("Name", "D3D12_DEBUG_FEATURE_EMULATE_WINDOWS7")]
        DebugFeatureEmulateWindows7 = 0x8,
    }
}
