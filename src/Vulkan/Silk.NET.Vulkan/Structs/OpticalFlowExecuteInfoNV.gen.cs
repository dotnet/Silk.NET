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
    [NativeName("Name", "VkOpticalFlowExecuteInfoNV")]
    public unsafe partial struct OpticalFlowExecuteInfoNV : IChainable
    {
        public OpticalFlowExecuteInfoNV
        (
            StructureType? sType = StructureType.OpticalFlowExecuteInfoNV,
            void* pNext = null,
            OpticalFlowExecuteFlagsNV? flags = null,
            uint? regionCount = null,
            Rect2D* pRegions = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (regionCount is not null)
            {
                RegionCount = regionCount.Value;
            }

            if (pRegions is not null)
            {
                PRegions = pRegions;
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
        [NativeName("Type", "VkOpticalFlowExecuteFlagsNV")]
        [NativeName("Type.Name", "VkOpticalFlowExecuteFlagsNV")]
        [NativeName("Name", "flags")]
        public OpticalFlowExecuteFlagsNV Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "regionCount")]
        public uint RegionCount;
/// <summary></summary>
        [NativeName("Type", "VkRect2D*")]
        [NativeName("Type.Name", "VkRect2D")]
        [NativeName("Name", "pRegions")]
        public Rect2D* PRegions;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.OpticalFlowExecuteInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
