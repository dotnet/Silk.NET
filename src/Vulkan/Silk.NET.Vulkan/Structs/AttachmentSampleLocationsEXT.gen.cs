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
    [NativeName("Name", "VkAttachmentSampleLocationsEXT")]
    public unsafe partial struct AttachmentSampleLocationsEXT
    {
        public AttachmentSampleLocationsEXT
        (
            uint attachmentIndex = default,
            SampleLocationsInfoEXT sampleLocationsInfo = default
        )
        {
            AttachmentIndex = attachmentIndex;
            SampleLocationsInfo = sampleLocationsInfo;
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "attachmentIndex")]
        public uint AttachmentIndex;
/// <summary></summary>
        [NativeName("Type", "VkSampleLocationsInfoEXT")]
        [NativeName("Type.Name", "VkSampleLocationsInfoEXT")]
        [NativeName("Name", "sampleLocationsInfo")]
        public SampleLocationsInfoEXT SampleLocationsInfo;
    }
}
