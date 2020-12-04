// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "VkPipelineRasterizationStateRasterizationOrderAMD")]
    public unsafe partial struct PipelineRasterizationStateRasterizationOrderAMD
    {
        public PipelineRasterizationStateRasterizationOrderAMD
        (
            StructureType? sType = StructureType.PipelineRasterizationStateRasterizationOrderAmd,
            void* pNext = null,
            RasterizationOrderAMD? rasterizationOrder = null
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

            if (rasterizationOrder is not null)
            {
                RasterizationOrder = rasterizationOrder.Value;
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
        [NativeName("Type", "VkRasterizationOrderAMD")]
        [NativeName("Type.Name", "VkRasterizationOrderAMD")]
        [NativeName("Name", "rasterizationOrder")]
        public RasterizationOrderAMD RasterizationOrder;
    }
}
