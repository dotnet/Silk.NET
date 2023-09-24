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
        PushConstants = 0x30001,
        [NativeName("Name", "WGPUNativeFeature_TextureAdapterSpecificFormatFeatures")]
        TextureAdapterSpecificFormatFeatures = 0x30002,
        [NativeName("Name", "WGPUNativeFeature_MultiDrawIndirect")]
        MultiDrawIndirect = 0x30003,
        [NativeName("Name", "WGPUNativeFeature_MultiDrawIndirectCount")]
        MultiDrawIndirectCount = 0x30004,
        [NativeName("Name", "WGPUNativeFeature_VertexWritableStorage")]
        VertexWritableStorage = 0x30005,
        [NativeName("Name", "WGPUNativeFeature_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
