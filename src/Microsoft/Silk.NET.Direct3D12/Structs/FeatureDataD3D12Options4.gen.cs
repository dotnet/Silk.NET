// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS4")]
    public unsafe partial struct FeatureDataD3D12Options4
    {
        public FeatureDataD3D12Options4
        (
            int mSAA64KBAlignedTextureSupported = default,
            SharedResourceCompatibilityTier sharedResourceCompatibilityTier = default,
            int native16BitShaderOpsSupported = default
        )
        {
            MSAA64KBAlignedTextureSupported = mSAA64KBAlignedTextureSupported;
            SharedResourceCompatibilityTier = sharedResourceCompatibilityTier;
            Native16BitShaderOpsSupported = native16BitShaderOpsSupported;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MSAA64KBAlignedTextureSupported")]
        public int MSAA64KBAlignedTextureSupported;

        [NativeName("Type", "D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER")]
        [NativeName("Type.Name", "D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER")]
        [NativeName("Name", "SharedResourceCompatibilityTier")]
        public SharedResourceCompatibilityTier SharedResourceCompatibilityTier;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Native16BitShaderOpsSupported")]
        public int Native16BitShaderOpsSupported;
    }
}
