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

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_FEATURE_DATA_D3D10_X_HARDWARE_OPTIONS")]
    public unsafe partial struct FeatureDataD3D10XHardwareOptions
    {
        public FeatureDataD3D10XHardwareOptions
        (
            Silk.NET.Core.Bool32? computeShadersPlusRawAndStructuredBuffersViaShader4X = null
        ) : this()
        {
            if (computeShadersPlusRawAndStructuredBuffersViaShader4X is not null)
            {
                ComputeShadersPlusRawAndStructuredBuffersViaShader4X = computeShadersPlusRawAndStructuredBuffersViaShader4X.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "computeShaders_Plus_RawAndStructuredBuffers_Via_Shader_4_x")]
        public Silk.NET.Core.Bool32 ComputeShadersPlusRawAndStructuredBuffersViaShader4X;
    }
}
