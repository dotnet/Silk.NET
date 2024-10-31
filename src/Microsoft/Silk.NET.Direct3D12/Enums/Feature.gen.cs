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
        [Obsolete("Deprecated in favour of \"D3D12Options\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS")]
        FeatureD3D12Options = 0x0,
        [Obsolete("Deprecated in favour of \"Architecture\"")]
        [NativeName("Name", "D3D12_FEATURE_ARCHITECTURE")]
        FeatureArchitecture = 0x1,
        [Obsolete("Deprecated in favour of \"FeatureLevels\"")]
        [NativeName("Name", "D3D12_FEATURE_FEATURE_LEVELS")]
        FeatureFeatureLevels = 0x2,
        [Obsolete("Deprecated in favour of \"FormatSupport\"")]
        [NativeName("Name", "D3D12_FEATURE_FORMAT_SUPPORT")]
        FeatureFormatSupport = 0x3,
        [Obsolete("Deprecated in favour of \"MultisampleQualityLevels\"")]
        [NativeName("Name", "D3D12_FEATURE_MULTISAMPLE_QUALITY_LEVELS")]
        FeatureMultisampleQualityLevels = 0x4,
        [Obsolete("Deprecated in favour of \"FormatInfo\"")]
        [NativeName("Name", "D3D12_FEATURE_FORMAT_INFO")]
        FeatureFormatInfo = 0x5,
        [Obsolete("Deprecated in favour of \"GpuVirtualAddressSupport\"")]
        [NativeName("Name", "D3D12_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT")]
        FeatureGpuVirtualAddressSupport = 0x6,
        [Obsolete("Deprecated in favour of \"ShaderModel\"")]
        [NativeName("Name", "D3D12_FEATURE_SHADER_MODEL")]
        FeatureShaderModel = 0x7,
        [Obsolete("Deprecated in favour of \"D3D12Options1\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS1")]
        FeatureD3D12Options1 = 0x8,
        [Obsolete("Deprecated in favour of \"ProtectedResourceSessionSupport\"")]
        [NativeName("Name", "D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_SUPPORT")]
        FeatureProtectedResourceSessionSupport = 0xA,
        [Obsolete("Deprecated in favour of \"RootSignature\"")]
        [NativeName("Name", "D3D12_FEATURE_ROOT_SIGNATURE")]
        FeatureRootSignature = 0xC,
        [Obsolete("Deprecated in favour of \"Architecture1\"")]
        [NativeName("Name", "D3D12_FEATURE_ARCHITECTURE1")]
        FeatureArchitecture1 = 0x10,
        [Obsolete("Deprecated in favour of \"D3D12Options2\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS2")]
        FeatureD3D12Options2 = 0x12,
        [Obsolete("Deprecated in favour of \"ShaderCache\"")]
        [NativeName("Name", "D3D12_FEATURE_SHADER_CACHE")]
        FeatureShaderCache = 0x13,
        [Obsolete("Deprecated in favour of \"CommandQueuePriority\"")]
        [NativeName("Name", "D3D12_FEATURE_COMMAND_QUEUE_PRIORITY")]
        FeatureCommandQueuePriority = 0x14,
        [Obsolete("Deprecated in favour of \"D3D12Options3\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS3")]
        FeatureD3D12Options3 = 0x15,
        [Obsolete("Deprecated in favour of \"ExistingHeaps\"")]
        [NativeName("Name", "D3D12_FEATURE_EXISTING_HEAPS")]
        FeatureExistingHeaps = 0x16,
        [Obsolete("Deprecated in favour of \"D3D12Options4\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS4")]
        FeatureD3D12Options4 = 0x17,
        [Obsolete("Deprecated in favour of \"Serialization\"")]
        [NativeName("Name", "D3D12_FEATURE_SERIALIZATION")]
        FeatureSerialization = 0x18,
        [Obsolete("Deprecated in favour of \"CrossNode\"")]
        [NativeName("Name", "D3D12_FEATURE_CROSS_NODE")]
        FeatureCrossNode = 0x19,
        [Obsolete("Deprecated in favour of \"D3D12Options5\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS5")]
        FeatureD3D12Options5 = 0x1B,
        [Obsolete("Deprecated in favour of \"Displayable\"")]
        [NativeName("Name", "D3D12_FEATURE_DISPLAYABLE")]
        FeatureDisplayable = 0x1C,
        [Obsolete("Deprecated in favour of \"D3D12Options6\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS6")]
        FeatureD3D12Options6 = 0x1E,
        [Obsolete("Deprecated in favour of \"QueryMetaCommand\"")]
        [NativeName("Name", "D3D12_FEATURE_QUERY_META_COMMAND")]
        FeatureQueryMetaCommand = 0x1F,
        [Obsolete("Deprecated in favour of \"D3D12Options7\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS7")]
        FeatureD3D12Options7 = 0x20,
        [Obsolete("Deprecated in favour of \"ProtectedResourceSessionTypeCount\"")]
        [NativeName("Name", "D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_TYPE_COUNT")]
        FeatureProtectedResourceSessionTypeCount = 0x21,
        [Obsolete("Deprecated in favour of \"ProtectedResourceSessionTypes\"")]
        [NativeName("Name", "D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_TYPES")]
        FeatureProtectedResourceSessionTypes = 0x22,
        [Obsolete("Deprecated in favour of \"D3D12Options8\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS8")]
        FeatureD3D12Options8 = 0x24,
        [Obsolete("Deprecated in favour of \"D3D12Options9\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS9")]
        FeatureD3D12Options9 = 0x25,
        [Obsolete("Deprecated in favour of \"D3D12Options10\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS10")]
        FeatureD3D12Options10 = 0x27,
        [Obsolete("Deprecated in favour of \"D3D12Options11\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS11")]
        FeatureD3D12Options11 = 0x28,
        [Obsolete("Deprecated in favour of \"D3D12Options12\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS12")]
        FeatureD3D12Options12 = 0x29,
        [Obsolete("Deprecated in favour of \"D3D12Options13\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS13")]
        FeatureD3D12Options13 = 0x2A,
        [Obsolete("Deprecated in favour of \"D3D12Options14\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS14")]
        FeatureD3D12Options14 = 0x2B,
        [Obsolete("Deprecated in favour of \"D3D12Options15\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS15")]
        FeatureD3D12Options15 = 0x2C,
        [Obsolete("Deprecated in favour of \"D3D12Options16\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS16")]
        FeatureD3D12Options16 = 0x2D,
        [Obsolete("Deprecated in favour of \"D3D12Options17\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS17")]
        FeatureD3D12Options17 = 0x2E,
        [Obsolete("Deprecated in favour of \"D3D12Options18\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS18")]
        FeatureD3D12Options18 = 0x2F,
        [Obsolete("Deprecated in favour of \"D3D12Options19\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS19")]
        FeatureD3D12Options19 = 0x30,
        [Obsolete("Deprecated in favour of \"D3D12Options20\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS20")]
        FeatureD3D12Options20 = 0x31,
        [Obsolete("Deprecated in favour of \"Predication\"")]
        [NativeName("Name", "D3D12_FEATURE_PREDICATION")]
        FeaturePredication = 0x32,
        [Obsolete("Deprecated in favour of \"PlacedResourceSupportInfo\"")]
        [NativeName("Name", "D3D12_FEATURE_PLACED_RESOURCE_SUPPORT_INFO")]
        FeaturePlacedResourceSupportInfo = 0x33,
        [Obsolete("Deprecated in favour of \"HardwareCopy\"")]
        [NativeName("Name", "D3D12_FEATURE_HARDWARE_COPY")]
        FeatureHardwareCopy = 0x34,
        [Obsolete("Deprecated in favour of \"D3D12Options21\"")]
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS21")]
        FeatureD3D12Options21 = 0x35,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS")]
        D3D12Options = 0x0,
        [NativeName("Name", "D3D12_FEATURE_ARCHITECTURE")]
        Architecture = 0x1,
        [NativeName("Name", "D3D12_FEATURE_FEATURE_LEVELS")]
        FeatureLevels = 0x2,
        [NativeName("Name", "D3D12_FEATURE_FORMAT_SUPPORT")]
        FormatSupport = 0x3,
        [NativeName("Name", "D3D12_FEATURE_MULTISAMPLE_QUALITY_LEVELS")]
        MultisampleQualityLevels = 0x4,
        [NativeName("Name", "D3D12_FEATURE_FORMAT_INFO")]
        FormatInfo = 0x5,
        [NativeName("Name", "D3D12_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT")]
        GpuVirtualAddressSupport = 0x6,
        [NativeName("Name", "D3D12_FEATURE_SHADER_MODEL")]
        ShaderModel = 0x7,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS1")]
        D3D12Options1 = 0x8,
        [NativeName("Name", "D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_SUPPORT")]
        ProtectedResourceSessionSupport = 0xA,
        [NativeName("Name", "D3D12_FEATURE_ROOT_SIGNATURE")]
        RootSignature = 0xC,
        [NativeName("Name", "D3D12_FEATURE_ARCHITECTURE1")]
        Architecture1 = 0x10,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS2")]
        D3D12Options2 = 0x12,
        [NativeName("Name", "D3D12_FEATURE_SHADER_CACHE")]
        ShaderCache = 0x13,
        [NativeName("Name", "D3D12_FEATURE_COMMAND_QUEUE_PRIORITY")]
        CommandQueuePriority = 0x14,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS3")]
        D3D12Options3 = 0x15,
        [NativeName("Name", "D3D12_FEATURE_EXISTING_HEAPS")]
        ExistingHeaps = 0x16,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS4")]
        D3D12Options4 = 0x17,
        [NativeName("Name", "D3D12_FEATURE_SERIALIZATION")]
        Serialization = 0x18,
        [NativeName("Name", "D3D12_FEATURE_CROSS_NODE")]
        CrossNode = 0x19,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS5")]
        D3D12Options5 = 0x1B,
        [NativeName("Name", "D3D12_FEATURE_DISPLAYABLE")]
        Displayable = 0x1C,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS6")]
        D3D12Options6 = 0x1E,
        [NativeName("Name", "D3D12_FEATURE_QUERY_META_COMMAND")]
        QueryMetaCommand = 0x1F,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS7")]
        D3D12Options7 = 0x20,
        [NativeName("Name", "D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_TYPE_COUNT")]
        ProtectedResourceSessionTypeCount = 0x21,
        [NativeName("Name", "D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_TYPES")]
        ProtectedResourceSessionTypes = 0x22,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS8")]
        D3D12Options8 = 0x24,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS9")]
        D3D12Options9 = 0x25,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS10")]
        D3D12Options10 = 0x27,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS11")]
        D3D12Options11 = 0x28,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS12")]
        D3D12Options12 = 0x29,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS13")]
        D3D12Options13 = 0x2A,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS14")]
        D3D12Options14 = 0x2B,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS15")]
        D3D12Options15 = 0x2C,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS16")]
        D3D12Options16 = 0x2D,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS17")]
        D3D12Options17 = 0x2E,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS18")]
        D3D12Options18 = 0x2F,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS19")]
        D3D12Options19 = 0x30,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS20")]
        D3D12Options20 = 0x31,
        [NativeName("Name", "D3D12_FEATURE_PREDICATION")]
        Predication = 0x32,
        [NativeName("Name", "D3D12_FEATURE_PLACED_RESOURCE_SUPPORT_INFO")]
        PlacedResourceSupportInfo = 0x33,
        [NativeName("Name", "D3D12_FEATURE_HARDWARE_COPY")]
        HardwareCopy = 0x34,
        [NativeName("Name", "D3D12_FEATURE_D3D12_OPTIONS21")]
        D3D12Options21 = 0x35,
    }
}
