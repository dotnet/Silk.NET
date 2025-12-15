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
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS14")]
    public unsafe partial struct FeatureDataD3D12Options14
    {
        public FeatureDataD3D12Options14
        (
            Silk.NET.Core.Bool32? advancedTextureOpsSupported = null,
            Silk.NET.Core.Bool32? writeableMSAATexturesSupported = null,
            Silk.NET.Core.Bool32? independentFrontAndBackStencilRefMaskSupported = null
        ) : this()
        {
            if (advancedTextureOpsSupported is not null)
            {
                AdvancedTextureOpsSupported = advancedTextureOpsSupported.Value;
            }

            if (writeableMSAATexturesSupported is not null)
            {
                WriteableMSAATexturesSupported = writeableMSAATexturesSupported.Value;
            }

            if (independentFrontAndBackStencilRefMaskSupported is not null)
            {
                IndependentFrontAndBackStencilRefMaskSupported = independentFrontAndBackStencilRefMaskSupported.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AdvancedTextureOpsSupported")]
        public Silk.NET.Core.Bool32 AdvancedTextureOpsSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "WriteableMSAATexturesSupported")]
        public Silk.NET.Core.Bool32 WriteableMSAATexturesSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "IndependentFrontAndBackStencilRefMaskSupported")]
        public Silk.NET.Core.Bool32 IndependentFrontAndBackStencilRefMaskSupported;
    }
}
