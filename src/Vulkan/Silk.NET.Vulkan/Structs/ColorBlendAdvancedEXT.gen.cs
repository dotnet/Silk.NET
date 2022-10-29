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
    [NativeName("Name", "VkColorBlendAdvancedEXT")]
    public unsafe partial struct ColorBlendAdvancedEXT
    {
        public ColorBlendAdvancedEXT
        (
            BlendOp? advancedBlendOp = null,
            Bool32? srcPremultiplied = null,
            Bool32? dstPremultiplied = null,
            BlendOverlapEXT? blendOverlap = null,
            Bool32? clampResults = null
        ) : this()
        {
            if (advancedBlendOp is not null)
            {
                AdvancedBlendOp = advancedBlendOp.Value;
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

            if (clampResults is not null)
            {
                ClampResults = clampResults.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkBlendOp")]
        [NativeName("Type.Name", "VkBlendOp")]
        [NativeName("Name", "advancedBlendOp")]
        public BlendOp AdvancedBlendOp;
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
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "clampResults")]
        public Bool32 ClampResults;
    }
}
