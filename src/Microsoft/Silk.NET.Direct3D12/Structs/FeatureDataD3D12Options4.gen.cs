// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
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
            Silk.NET.Core.Bool32? mSAA64KBAlignedTextureSupported = null,
            SharedResourceCompatibilityTier? sharedResourceCompatibilityTier = null,
            Silk.NET.Core.Bool32? native16BitShaderOpsSupported = null
        ) : this()
        {
            if (mSAA64KBAlignedTextureSupported is not null)
            {
                MSAA64KBAlignedTextureSupported = mSAA64KBAlignedTextureSupported.Value;
            }

            if (sharedResourceCompatibilityTier is not null)
            {
                SharedResourceCompatibilityTier = sharedResourceCompatibilityTier.Value;
            }

            if (native16BitShaderOpsSupported is not null)
            {
                Native16BitShaderOpsSupported = native16BitShaderOpsSupported.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MSAA64KBAlignedTextureSupported")]
        public Silk.NET.Core.Bool32 MSAA64KBAlignedTextureSupported;

        [NativeName("Type", "D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER")]
        [NativeName("Type.Name", "D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER")]
        [NativeName("Name", "SharedResourceCompatibilityTier")]
        public SharedResourceCompatibilityTier SharedResourceCompatibilityTier;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Native16BitShaderOpsSupported")]
        public Silk.NET.Core.Bool32 Native16BitShaderOpsSupported;
    }
}
