// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_FEATURE")]
    public enum Feature : int
    {
        [Obsolete("Deprecated in favour of \"Threading\"")]
        [NativeName("Name", "D3D11_FEATURE_THREADING")]
        FeatureThreading = 0x0,
        [Obsolete("Deprecated in favour of \"Doubles\"")]
        [NativeName("Name", "D3D11_FEATURE_DOUBLES")]
        FeatureDoubles = 0x1,
        [Obsolete("Deprecated in favour of \"FormatSupport\"")]
        [NativeName("Name", "D3D11_FEATURE_FORMAT_SUPPORT")]
        FeatureFormatSupport = 0x2,
        [Obsolete("Deprecated in favour of \"FormatSupport2\"")]
        [NativeName("Name", "D3D11_FEATURE_FORMAT_SUPPORT2")]
        FeatureFormatSupport2 = 0x3,
        [Obsolete("Deprecated in favour of \"D3D10XHardwareOptions\"")]
        [NativeName("Name", "D3D11_FEATURE_D3D10_X_HARDWARE_OPTIONS")]
        FeatureD3D10XHardwareOptions = 0x4,
        [Obsolete("Deprecated in favour of \"D3D11Options\"")]
        [NativeName("Name", "D3D11_FEATURE_D3D11_OPTIONS")]
        FeatureD3D11Options = 0x5,
        [Obsolete("Deprecated in favour of \"ArchitectureInfo\"")]
        [NativeName("Name", "D3D11_FEATURE_ARCHITECTURE_INFO")]
        FeatureArchitectureInfo = 0x6,
        [Obsolete("Deprecated in favour of \"D3D9Options\"")]
        [NativeName("Name", "D3D11_FEATURE_D3D9_OPTIONS")]
        FeatureD3D9Options = 0x7,
        [Obsolete("Deprecated in favour of \"ShaderMinPrecisionSupport\"")]
        [NativeName("Name", "D3D11_FEATURE_SHADER_MIN_PRECISION_SUPPORT")]
        FeatureShaderMinPrecisionSupport = 0x8,
        [Obsolete("Deprecated in favour of \"D3D9ShadowSupport\"")]
        [NativeName("Name", "D3D11_FEATURE_D3D9_SHADOW_SUPPORT")]
        FeatureD3D9ShadowSupport = 0x9,
        [Obsolete("Deprecated in favour of \"D3D11Options1\"")]
        [NativeName("Name", "D3D11_FEATURE_D3D11_OPTIONS1")]
        FeatureD3D11Options1 = 0xA,
        [Obsolete("Deprecated in favour of \"D3D9SimpleInstancingSupport\"")]
        [NativeName("Name", "D3D11_FEATURE_D3D9_SIMPLE_INSTANCING_SUPPORT")]
        FeatureD3D9SimpleInstancingSupport = 0xB,
        [Obsolete("Deprecated in favour of \"MarkerSupport\"")]
        [NativeName("Name", "D3D11_FEATURE_MARKER_SUPPORT")]
        FeatureMarkerSupport = 0xC,
        [Obsolete("Deprecated in favour of \"D3D9Options1\"")]
        [NativeName("Name", "D3D11_FEATURE_D3D9_OPTIONS1")]
        FeatureD3D9Options1 = 0xD,
        [Obsolete("Deprecated in favour of \"D3D11Options2\"")]
        [NativeName("Name", "D3D11_FEATURE_D3D11_OPTIONS2")]
        FeatureD3D11Options2 = 0xE,
        [Obsolete("Deprecated in favour of \"D3D11Options3\"")]
        [NativeName("Name", "D3D11_FEATURE_D3D11_OPTIONS3")]
        FeatureD3D11Options3 = 0xF,
        [Obsolete("Deprecated in favour of \"GpuVirtualAddressSupport\"")]
        [NativeName("Name", "D3D11_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT")]
        FeatureGpuVirtualAddressSupport = 0x10,
        [Obsolete("Deprecated in favour of \"D3D11Options4\"")]
        [NativeName("Name", "D3D11_FEATURE_D3D11_OPTIONS4")]
        FeatureD3D11Options4 = 0x11,
        [Obsolete("Deprecated in favour of \"ShaderCache\"")]
        [NativeName("Name", "D3D11_FEATURE_SHADER_CACHE")]
        FeatureShaderCache = 0x12,
        [Obsolete("Deprecated in favour of \"D3D11Options5\"")]
        [NativeName("Name", "D3D11_FEATURE_D3D11_OPTIONS5")]
        FeatureD3D11Options5 = 0x13,
        [Obsolete("Deprecated in favour of \"Displayable\"")]
        [NativeName("Name", "D3D11_FEATURE_DISPLAYABLE")]
        FeatureDisplayable = 0x14,
        [NativeName("Name", "D3D11_FEATURE_THREADING")]
        Threading = 0x0,
        [NativeName("Name", "D3D11_FEATURE_DOUBLES")]
        Doubles = 0x1,
        [NativeName("Name", "D3D11_FEATURE_FORMAT_SUPPORT")]
        FormatSupport = 0x2,
        [NativeName("Name", "D3D11_FEATURE_FORMAT_SUPPORT2")]
        FormatSupport2 = 0x3,
        [NativeName("Name", "D3D11_FEATURE_D3D10_X_HARDWARE_OPTIONS")]
        D3D10XHardwareOptions = 0x4,
        [NativeName("Name", "D3D11_FEATURE_D3D11_OPTIONS")]
        D3D11Options = 0x5,
        [NativeName("Name", "D3D11_FEATURE_ARCHITECTURE_INFO")]
        ArchitectureInfo = 0x6,
        [NativeName("Name", "D3D11_FEATURE_D3D9_OPTIONS")]
        D3D9Options = 0x7,
        [NativeName("Name", "D3D11_FEATURE_SHADER_MIN_PRECISION_SUPPORT")]
        ShaderMinPrecisionSupport = 0x8,
        [NativeName("Name", "D3D11_FEATURE_D3D9_SHADOW_SUPPORT")]
        D3D9ShadowSupport = 0x9,
        [NativeName("Name", "D3D11_FEATURE_D3D11_OPTIONS1")]
        D3D11Options1 = 0xA,
        [NativeName("Name", "D3D11_FEATURE_D3D9_SIMPLE_INSTANCING_SUPPORT")]
        D3D9SimpleInstancingSupport = 0xB,
        [NativeName("Name", "D3D11_FEATURE_MARKER_SUPPORT")]
        MarkerSupport = 0xC,
        [NativeName("Name", "D3D11_FEATURE_D3D9_OPTIONS1")]
        D3D9Options1 = 0xD,
        [NativeName("Name", "D3D11_FEATURE_D3D11_OPTIONS2")]
        D3D11Options2 = 0xE,
        [NativeName("Name", "D3D11_FEATURE_D3D11_OPTIONS3")]
        D3D11Options3 = 0xF,
        [NativeName("Name", "D3D11_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT")]
        GpuVirtualAddressSupport = 0x10,
        [NativeName("Name", "D3D11_FEATURE_D3D11_OPTIONS4")]
        D3D11Options4 = 0x11,
        [NativeName("Name", "D3D11_FEATURE_SHADER_CACHE")]
        ShaderCache = 0x12,
        [NativeName("Name", "D3D11_FEATURE_D3D11_OPTIONS5")]
        D3D11Options5 = 0x13,
        [NativeName("Name", "D3D11_FEATURE_DISPLAYABLE")]
        Displayable = 0x14,
    }
}
