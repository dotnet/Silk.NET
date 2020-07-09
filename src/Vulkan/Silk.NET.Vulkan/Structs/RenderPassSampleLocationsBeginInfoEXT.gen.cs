// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkRenderPassSampleLocationsBeginInfoEXT")]
    public unsafe struct RenderPassSampleLocationsBeginInfoEXT
    {
        public RenderPassSampleLocationsBeginInfoEXT
        (
            StructureType sType = StructureType.RenderPassSampleLocationsBeginInfoExt,
            void* pNext = default,
            uint attachmentInitialSampleLocationsCount = default,
            AttachmentSampleLocationsEXT* pAttachmentInitialSampleLocations = default,
            uint postSubpassSampleLocationsCount = default,
            SubpassSampleLocationsEXT* pPostSubpassSampleLocations = default
        )
        {
           SType = sType;
           PNext = pNext;
           AttachmentInitialSampleLocationsCount = attachmentInitialSampleLocationsCount;
           PAttachmentInitialSampleLocations = pAttachmentInitialSampleLocations;
           PostSubpassSampleLocationsCount = postSubpassSampleLocationsCount;
           PPostSubpassSampleLocations = pPostSubpassSampleLocations;
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
        [NativeName("Name", "attachmentInitialSampleLocationsCount")]
        public uint AttachmentInitialSampleLocationsCount;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentSampleLocationsEXT*")]
        [NativeName("Type.Name", "VkAttachmentSampleLocationsEXT")]
        [NativeName("Name", "pAttachmentInitialSampleLocations")]
        public AttachmentSampleLocationsEXT* PAttachmentInitialSampleLocations;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "postSubpassSampleLocationsCount")]
        public uint PostSubpassSampleLocationsCount;
/// <summary></summary>
        [NativeName("Type", "VkSubpassSampleLocationsEXT*")]
        [NativeName("Type.Name", "VkSubpassSampleLocationsEXT")]
        [NativeName("Name", "pPostSubpassSampleLocations")]
        public SubpassSampleLocationsEXT* PPostSubpassSampleLocations;
    }
}
