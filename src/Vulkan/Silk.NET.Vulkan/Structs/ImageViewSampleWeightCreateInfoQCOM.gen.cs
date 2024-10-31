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
    [NativeName("Name", "VkImageViewSampleWeightCreateInfoQCOM")]
    public unsafe partial struct ImageViewSampleWeightCreateInfoQCOM : IExtendsChain<ImageViewCreateInfo>
    {
        public ImageViewSampleWeightCreateInfoQCOM
        (
            StructureType? sType = StructureType.ImageViewSampleWeightCreateInfoQCom,
            void* pNext = null,
            Offset2D? filterCenter = null,
            Extent2D? filterSize = null,
            uint? numPhases = null
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

            if (filterCenter is not null)
            {
                FilterCenter = filterCenter.Value;
            }

            if (filterSize is not null)
            {
                FilterSize = filterSize.Value;
            }

            if (numPhases is not null)
            {
                NumPhases = numPhases.Value;
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
        [NativeName("Type", "VkOffset2D")]
        [NativeName("Type.Name", "VkOffset2D")]
        [NativeName("Name", "filterCenter")]
        public Offset2D FilterCenter;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "filterSize")]
        public Extent2D FilterSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "numPhases")]
        public uint NumPhases;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }


        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ImageViewSampleWeightCreateInfoQCom;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
