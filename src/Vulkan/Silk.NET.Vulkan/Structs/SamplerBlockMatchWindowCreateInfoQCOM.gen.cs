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
    [NativeName("Name", "VkSamplerBlockMatchWindowCreateInfoQCOM")]
    public unsafe partial struct SamplerBlockMatchWindowCreateInfoQCOM : IExtendsChain<SamplerCreateInfo>
    {
        public SamplerBlockMatchWindowCreateInfoQCOM
        (
            StructureType? sType = StructureType.SamplerBlockMatchWindowCreateInfoQCom,
            void* pNext = null,
            Extent2D? windowExtent = null,
            BlockMatchWindowCompareModeQCOM? windowCompareMode = null
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

            if (windowExtent is not null)
            {
                WindowExtent = windowExtent.Value;
            }

            if (windowCompareMode is not null)
            {
                WindowCompareMode = windowCompareMode.Value;
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
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "windowExtent")]
        public Extent2D WindowExtent;
/// <summary></summary>
        [NativeName("Type", "VkBlockMatchWindowCompareModeQCOM")]
        [NativeName("Type.Name", "VkBlockMatchWindowCompareModeQCOM")]
        [NativeName("Name", "windowCompareMode")]
        public BlockMatchWindowCompareModeQCOM WindowCompareMode;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SamplerBlockMatchWindowCreateInfoQCom;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
