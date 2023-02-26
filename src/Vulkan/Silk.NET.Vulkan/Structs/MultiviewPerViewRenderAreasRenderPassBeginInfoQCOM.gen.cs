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
    [NativeName("Name", "VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM")]
    public unsafe partial struct MultiviewPerViewRenderAreasRenderPassBeginInfoQCOM : IExtendsChain<RenderPassBeginInfo>, IExtendsChain<RenderingInfo>, IExtendsChain<RenderingInfoKHR>
    {
        public MultiviewPerViewRenderAreasRenderPassBeginInfoQCOM
        (
            StructureType? sType = StructureType.MultiviewPerViewRenderAreasRenderPassBeginInfoQCom,
            void* pNext = null,
            uint? perViewRenderAreaCount = null,
            Rect2D* pPerViewRenderAreas = null
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

            if (perViewRenderAreaCount is not null)
            {
                PerViewRenderAreaCount = perViewRenderAreaCount.Value;
            }

            if (pPerViewRenderAreas is not null)
            {
                PPerViewRenderAreas = pPerViewRenderAreas;
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
        [NativeName("Name", "perViewRenderAreaCount")]
        public uint PerViewRenderAreaCount;
/// <summary></summary>
        [NativeName("Type", "VkRect2D*")]
        [NativeName("Type.Name", "VkRect2D")]
        [NativeName("Name", "pPerViewRenderAreas")]
        public Rect2D* PPerViewRenderAreas;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.MultiviewPerViewRenderAreasRenderPassBeginInfoQCom;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
