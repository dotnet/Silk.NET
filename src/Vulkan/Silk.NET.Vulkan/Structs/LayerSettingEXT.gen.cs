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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkLayerSettingEXT")]
    public unsafe partial struct LayerSettingEXT
    {
        public LayerSettingEXT
        (
            byte* pLayerName = null,
            byte* pSettingName = null,
            LayerSettingTypeEXT? type = null,
            uint? valueCount = null,
            void* pValues = null
        ) : this()
        {
            if (pLayerName is not null)
            {
                PLayerName = pLayerName;
            }

            if (pSettingName is not null)
            {
                PSettingName = pSettingName;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (valueCount is not null)
            {
                ValueCount = valueCount.Value;
            }

            if (pValues is not null)
            {
                PValues = pValues;
            }
        }

/// <summary></summary>
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "pLayerName")]
        public byte* PLayerName;
/// <summary></summary>
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "pSettingName")]
        public byte* PSettingName;
/// <summary></summary>
        [NativeName("Type", "VkLayerSettingTypeEXT")]
        [NativeName("Type.Name", "VkLayerSettingTypeEXT")]
        [NativeName("Name", "type")]
        public LayerSettingTypeEXT Type;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "valueCount")]
        public uint ValueCount;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pValues")]
        public void* PValues;
    }
}
