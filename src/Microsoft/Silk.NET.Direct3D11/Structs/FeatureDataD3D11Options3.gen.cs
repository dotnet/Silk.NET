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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_FEATURE_DATA_D3D11_OPTIONS3")]
    public unsafe partial struct FeatureDataD3D11Options3
    {
        public FeatureDataD3D11Options3
        (
            Silk.NET.Core.Bool32? vPAndRTArrayIndexFromAnyShaderFeedingRasterizer = null
        ) : this()
        {
            if (vPAndRTArrayIndexFromAnyShaderFeedingRasterizer is not null)
            {
                VPAndRTArrayIndexFromAnyShaderFeedingRasterizer = vPAndRTArrayIndexFromAnyShaderFeedingRasterizer.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "VPAndRTArrayIndexFromAnyShaderFeedingRasterizer")]
        public Silk.NET.Core.Bool32 VPAndRTArrayIndexFromAnyShaderFeedingRasterizer;
    }
}
