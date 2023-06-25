// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUNativeFeature")]
    public enum NativeFeature : int
    {
        [NativeName("Name", "WGPUNativeFeature_PushConstants")]
        PushConstants = 0x60000001,
        [NativeName("Name", "WGPUNativeFeature_TextureAdapterSpecificFormatFeatures")]
        TextureAdapterSpecificFormatFeatures = 0x60000002,
        [NativeName("Name", "WGPUNativeFeature_MultiDrawIndirect")]
        MultiDrawIndirect = 0x60000003,
        [NativeName("Name", "WGPUNativeFeature_MultiDrawIndirectCount")]
        MultiDrawIndirectCount = 0x60000004,
        [NativeName("Name", "WGPUNativeFeature_VertexWritableStorage")]
        VertexWritableStorage = 0x60000005,
        [NativeName("Name", "WGPUNativeFeature_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
