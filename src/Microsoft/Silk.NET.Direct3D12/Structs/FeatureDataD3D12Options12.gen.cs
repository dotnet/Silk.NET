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
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS12")]
    public unsafe partial struct FeatureDataD3D12Options12
    {
        public FeatureDataD3D12Options12
        (
            TriState? mSPrimitivesPipelineStatisticIncludesCulledPrimitives = null,
            Silk.NET.Core.Bool32? enhancedBarriersSupported = null,
            Silk.NET.Core.Bool32? relaxedFormatCastingSupported = null
        ) : this()
        {
            if (mSPrimitivesPipelineStatisticIncludesCulledPrimitives is not null)
            {
                MSPrimitivesPipelineStatisticIncludesCulledPrimitives = mSPrimitivesPipelineStatisticIncludesCulledPrimitives.Value;
            }

            if (enhancedBarriersSupported is not null)
            {
                EnhancedBarriersSupported = enhancedBarriersSupported.Value;
            }

            if (relaxedFormatCastingSupported is not null)
            {
                RelaxedFormatCastingSupported = relaxedFormatCastingSupported.Value;
            }
        }


        [NativeName("Type", "D3D12_TRI_STATE")]
        [NativeName("Type.Name", "D3D12_TRI_STATE")]
        [NativeName("Name", "MSPrimitivesPipelineStatisticIncludesCulledPrimitives")]
        public TriState MSPrimitivesPipelineStatisticIncludesCulledPrimitives;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "EnhancedBarriersSupported")]
        public Silk.NET.Core.Bool32 EnhancedBarriersSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "RelaxedFormatCastingSupported")]
        public Silk.NET.Core.Bool32 RelaxedFormatCastingSupported;
    }
}
