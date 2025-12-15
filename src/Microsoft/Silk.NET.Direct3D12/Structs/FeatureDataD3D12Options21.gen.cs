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
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS21")]
    public unsafe partial struct FeatureDataD3D12Options21
    {
        public FeatureDataD3D12Options21
        (
            WorkGraphsTier? workGraphsTier = null,
            ExecuteIndirectTier? executeIndirectTier = null,
            Silk.NET.Core.Bool32? sampleCmpGradientAndBiasSupported = null,
            Silk.NET.Core.Bool32? extendedCommandInfoSupported = null
        ) : this()
        {
            if (workGraphsTier is not null)
            {
                WorkGraphsTier = workGraphsTier.Value;
            }

            if (executeIndirectTier is not null)
            {
                ExecuteIndirectTier = executeIndirectTier.Value;
            }

            if (sampleCmpGradientAndBiasSupported is not null)
            {
                SampleCmpGradientAndBiasSupported = sampleCmpGradientAndBiasSupported.Value;
            }

            if (extendedCommandInfoSupported is not null)
            {
                ExtendedCommandInfoSupported = extendedCommandInfoSupported.Value;
            }
        }


        [NativeName("Type", "D3D12_WORK_GRAPHS_TIER")]
        [NativeName("Type.Name", "D3D12_WORK_GRAPHS_TIER")]
        [NativeName("Name", "WorkGraphsTier")]
        public WorkGraphsTier WorkGraphsTier;

        [NativeName("Type", "D3D12_EXECUTE_INDIRECT_TIER")]
        [NativeName("Type.Name", "D3D12_EXECUTE_INDIRECT_TIER")]
        [NativeName("Name", "ExecuteIndirectTier")]
        public ExecuteIndirectTier ExecuteIndirectTier;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "SampleCmpGradientAndBiasSupported")]
        public Silk.NET.Core.Bool32 SampleCmpGradientAndBiasSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ExtendedCommandInfoSupported")]
        public Silk.NET.Core.Bool32 ExtendedCommandInfoSupported;
    }
}
