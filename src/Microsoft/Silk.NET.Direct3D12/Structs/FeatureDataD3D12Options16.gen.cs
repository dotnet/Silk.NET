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
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS16")]
    public unsafe partial struct FeatureDataD3D12Options16
    {
        public FeatureDataD3D12Options16
        (
            Silk.NET.Core.Bool32? dynamicDepthBiasSupported = null,
            Silk.NET.Core.Bool32? gPUUploadHeapSupported = null
        ) : this()
        {
            if (dynamicDepthBiasSupported is not null)
            {
                DynamicDepthBiasSupported = dynamicDepthBiasSupported.Value;
            }

            if (gPUUploadHeapSupported is not null)
            {
                GPUUploadHeapSupported = gPUUploadHeapSupported.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DynamicDepthBiasSupported")]
        public Silk.NET.Core.Bool32 DynamicDepthBiasSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "GPUUploadHeapSupported")]
        public Silk.NET.Core.Bool32 GPUUploadHeapSupported;
    }
}
