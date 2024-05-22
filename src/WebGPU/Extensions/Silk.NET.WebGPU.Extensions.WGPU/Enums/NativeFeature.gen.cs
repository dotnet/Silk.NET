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
        [Obsolete("Deprecated in favour of \"TextureAdapterSpecificFormatFeatures\"")]
        [NativeName("Name", "WGPUNativeFeature_TEXTURE_ADAPTER_SPECIFIC_FORMAT_FEATURES")]
        NativeFeatureTextureAdapterSpecificFormatFeatures = 0x10000000,
        [NativeName("Name", "WGPUNativeFeature_TEXTURE_ADAPTER_SPECIFIC_FORMAT_FEATURES")]
        TextureAdapterSpecificFormatFeatures = 0x10000000,
    }
}
