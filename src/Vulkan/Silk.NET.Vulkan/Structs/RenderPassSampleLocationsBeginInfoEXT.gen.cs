// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint AttachmentInitialSampleLocationsCount;
/// <summary></summary>
        public AttachmentSampleLocationsEXT* PAttachmentInitialSampleLocations;
/// <summary></summary>
        public uint PostSubpassSampleLocationsCount;
/// <summary></summary>
        public SubpassSampleLocationsEXT* PPostSubpassSampleLocations;
    }
}
