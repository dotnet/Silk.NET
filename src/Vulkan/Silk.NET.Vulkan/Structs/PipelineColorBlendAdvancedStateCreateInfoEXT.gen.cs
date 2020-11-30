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
    [NativeName("Name", "VkPipelineColorBlendAdvancedStateCreateInfoEXT")]
    public unsafe partial struct PipelineColorBlendAdvancedStateCreateInfoEXT
    {
        public PipelineColorBlendAdvancedStateCreateInfoEXT
        (
            StructureType? sType = StructureType.PipelineColorBlendAdvancedStateCreateInfoExt,
            void* pNext = null,
            Bool32? srcPremultiplied = null,
            Bool32? dstPremultiplied = null,
            BlendOverlapEXT? blendOverlap = null
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

            if (srcPremultiplied is not null)
            {
                SrcPremultiplied = srcPremultiplied.Value;
            }

            if (dstPremultiplied is not null)
            {
                DstPremultiplied = dstPremultiplied.Value;
            }

            if (blendOverlap is not null)
            {
                BlendOverlap = blendOverlap.Value;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "srcPremultiplied")]
        public Bool32 SrcPremultiplied;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "dstPremultiplied")]
        public Bool32 DstPremultiplied;
/// <summary></summary>
        [NativeName("Type", "VkBlendOverlapEXT")]
        [NativeName("Type.Name", "VkBlendOverlapEXT")]
        [NativeName("Name", "blendOverlap")]
        public BlendOverlapEXT BlendOverlap;
    }
}
