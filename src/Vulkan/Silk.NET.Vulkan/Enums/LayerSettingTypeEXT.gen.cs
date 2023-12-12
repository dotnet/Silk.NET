// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkLayerSettingTypeEXT")]
    public enum LayerSettingTypeEXT : int
    {
        [Obsolete("Deprecated in favour of \"Bool32Ext\"")]
        [NativeName("Name", "VK_LAYER_SETTING_TYPE_BOOL32_EXT")]
        LayerSettingTypeBool32Ext = 0,
        [Obsolete("Deprecated in favour of \"Int32Ext\"")]
        [NativeName("Name", "VK_LAYER_SETTING_TYPE_INT32_EXT")]
        LayerSettingTypeInt32Ext = 1,
        [Obsolete("Deprecated in favour of \"Int64Ext\"")]
        [NativeName("Name", "VK_LAYER_SETTING_TYPE_INT64_EXT")]
        LayerSettingTypeInt64Ext = 2,
        [Obsolete("Deprecated in favour of \"Uint32Ext\"")]
        [NativeName("Name", "VK_LAYER_SETTING_TYPE_UINT32_EXT")]
        LayerSettingTypeUint32Ext = 3,
        [Obsolete("Deprecated in favour of \"Uint64Ext\"")]
        [NativeName("Name", "VK_LAYER_SETTING_TYPE_UINT64_EXT")]
        LayerSettingTypeUint64Ext = 4,
        [Obsolete("Deprecated in favour of \"Float32Ext\"")]
        [NativeName("Name", "VK_LAYER_SETTING_TYPE_FLOAT32_EXT")]
        LayerSettingTypeFloat32Ext = 5,
        [Obsolete("Deprecated in favour of \"Float64Ext\"")]
        [NativeName("Name", "VK_LAYER_SETTING_TYPE_FLOAT64_EXT")]
        LayerSettingTypeFloat64Ext = 6,
        [Obsolete("Deprecated in favour of \"StringExt\"")]
        [NativeName("Name", "VK_LAYER_SETTING_TYPE_STRING_EXT")]
        LayerSettingTypeStringExt = 7,
        [NativeName("Name", "VK_LAYER_SETTING_TYPE_BOOL32_EXT")]
        Bool32Ext = 0,
        [NativeName("Name", "VK_LAYER_SETTING_TYPE_INT32_EXT")]
        Int32Ext = 1,
        [NativeName("Name", "VK_LAYER_SETTING_TYPE_INT64_EXT")]
        Int64Ext = 2,
        [NativeName("Name", "VK_LAYER_SETTING_TYPE_UINT32_EXT")]
        Uint32Ext = 3,
        [NativeName("Name", "VK_LAYER_SETTING_TYPE_UINT64_EXT")]
        Uint64Ext = 4,
        [NativeName("Name", "VK_LAYER_SETTING_TYPE_FLOAT32_EXT")]
        Float32Ext = 5,
        [NativeName("Name", "VK_LAYER_SETTING_TYPE_FLOAT64_EXT")]
        Float64Ext = 6,
        [NativeName("Name", "VK_LAYER_SETTING_TYPE_STRING_EXT")]
        StringExt = 7,
    }
}
