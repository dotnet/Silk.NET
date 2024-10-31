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
    [NativeName("Name", "VkLayerSettingsCreateInfoEXT")]
    public unsafe partial struct LayerSettingsCreateInfoEXT : IExtendsChain<InstanceCreateInfo>
    {
        public LayerSettingsCreateInfoEXT
        (
            StructureType? sType = StructureType.LayerSettingsCreateInfoExt,
            void* pNext = null,
            uint? settingCount = null,
            LayerSettingEXT* pSettings = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (settingCount is not null)
            {
                SettingCount = settingCount.Value;
            }

            if (pSettings is not null)
            {
                PSettings = pSettings;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "settingCount")]
        public uint SettingCount;
/// <summary></summary>
        [NativeName("Type", "VkLayerSettingEXT*")]
        [NativeName("Type.Name", "VkLayerSettingEXT")]
        [NativeName("Name", "pSettings")]
        public LayerSettingEXT* PSettings;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.LayerSettingsCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
