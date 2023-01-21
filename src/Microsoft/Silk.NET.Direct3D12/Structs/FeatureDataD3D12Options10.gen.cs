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
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS10")]
    public unsafe partial struct FeatureDataD3D12Options10
    {
        public FeatureDataD3D12Options10
        (
            Silk.NET.Core.Bool32? variableRateShadingSumCombinerSupported = null,
            Silk.NET.Core.Bool32? meshShaderPerPrimitiveShadingRateSupported = null
        ) : this()
        {
            if (variableRateShadingSumCombinerSupported is not null)
            {
                VariableRateShadingSumCombinerSupported = variableRateShadingSumCombinerSupported.Value;
            }

            if (meshShaderPerPrimitiveShadingRateSupported is not null)
            {
                MeshShaderPerPrimitiveShadingRateSupported = meshShaderPerPrimitiveShadingRateSupported.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "VariableRateShadingSumCombinerSupported")]
        public Silk.NET.Core.Bool32 VariableRateShadingSumCombinerSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MeshShaderPerPrimitiveShadingRateSupported")]
        public Silk.NET.Core.Bool32 MeshShaderPerPrimitiveShadingRateSupported;
    }
}
