// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FEATURE")]
    public enum Feature : int
    {
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS")]
        FeatureD3D12Options = 0x0,
        [NativeName("Name", "D3D12_FEATURE_ARCHITECTURE")]
        FeatureArchitecture = 0x1,
        [NativeName("Name", "D3D12_FEATURE_FEATURE_LEVELS")]
        FeatureFeatureLevels = 0x2,
        [NativeName("Name", "D3D12_FEATURE_FORMAT_SUPPORT")]
        FeatureFormatSupport = 0x3,
        [NativeName("Name", "D3D12_FEATURE_MULTISAMPLE_QUALITY_LEVELS")]
        FeatureMultisampleQualityLevels = 0x4,
        [NativeName("Name", "D3D12_FEATURE_FORMAT_INFO")]
        FeatureFormatInfo = 0x5,
        [NativeName("Name", "D3D12_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT")]
        FeatureGpuVirtualAddressSupport = 0x6,
        [NativeName("Name", "D3D12_FEATURE_SHADER_MODEL")]
        FeatureShaderModel = 0x7,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS1")]
        FeatureD3D12Options1 = 0x8,
        [NativeName("Name", "D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_SUPPORT")]
        FeatureProtectedResourceSessionSupport = 0xA,
        [NativeName("Name", "D3D12_FEATURE_ROOT_SIGNATURE")]
        FeatureRootSignature = 0xC,
        [NativeName("Name", "D3D12_FEATURE_ARCHITECTURE1")]
        FeatureArchitecture1 = 0x10,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS2")]
        FeatureD3D12Options2 = 0x12,
        [NativeName("Name", "D3D12_FEATURE_SHADER_CACHE")]
        FeatureShaderCache = 0x13,
        [NativeName("Name", "D3D12_FEATURE_COMMAND_QUEUE_PRIORITY")]
        FeatureCommandQueuePriority = 0x14,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS3")]
        FeatureD3D12Options3 = 0x15,
        [NativeName("Name", "D3D12_FEATURE_EXISTING_HEAPS")]
        FeatureExistingHeaps = 0x16,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS4")]
        FeatureD3D12Options4 = 0x17,
        [NativeName("Name", "D3D12_FEATURE_SERIALIZATION")]
        FeatureSerialization = 0x18,
        [NativeName("Name", "D3D12_FEATURE_CROSS_NODE")]
        FeatureCrossNode = 0x19,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS5")]
        FeatureD3D12Options5 = 0x1B,
        [NativeName("Name", "D3D12_FEATURE_DISPLAYABLE")]
        FeatureDisplayable = 0x1C,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS6")]
        FeatureD3D12Options6 = 0x1E,
        [NativeName("Name", "D3D12_FEATURE_QUERY_META_COMMAND")]
        FeatureQueryMetaCommand = 0x1F,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS7")]
        FeatureD3D12Options7 = 0x20,
        [NativeName("Name", "D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_TYPE_COUNT")]
        FeatureProtectedResourceSessionTypeCount = 0x21,
        [NativeName("Name", "D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_TYPES")]
        FeatureProtectedResourceSessionTypes = 0x22,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS8")]
        FeatureD3D12Options8 = 0x24,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS9")]
        FeatureD3D12Options9 = 0x25,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS10")]
        FeatureD3D12Options10 = 0x27,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS11")]
        FeatureD3D12Options11 = 0x28,
    }
}
