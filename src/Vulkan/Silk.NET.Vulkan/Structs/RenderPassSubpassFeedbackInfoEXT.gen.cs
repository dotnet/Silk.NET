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
    [NativeName("Name", "VkRenderPassSubpassFeedbackInfoEXT")]
    public unsafe partial struct RenderPassSubpassFeedbackInfoEXT
    {
        public RenderPassSubpassFeedbackInfoEXT
        (
            SubpassMergeStatusEXT? subpassMergeStatus = null,
            uint? postMergeIndex = null
        ) : this()
        {
            if (subpassMergeStatus is not null)
            {
                SubpassMergeStatus = subpassMergeStatus.Value;
            }

            if (postMergeIndex is not null)
            {
                PostMergeIndex = postMergeIndex.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkSubpassMergeStatusEXT")]
        [NativeName("Type.Name", "VkSubpassMergeStatusEXT")]
        [NativeName("Name", "subpassMergeStatus")]
        public SubpassMergeStatusEXT SubpassMergeStatus;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "description")]
        public fixed byte Description[256];
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "postMergeIndex")]
        public uint PostMergeIndex;
    }
}
