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
    [NativeName("Name", "VkPhysicalDeviceTransformFeedbackFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceTransformFeedbackFeaturesEXT
    {
        public PhysicalDeviceTransformFeedbackFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceTransformFeedbackFeaturesExt,
            void* pNext = null,
            Bool32? transformFeedback = null,
            Bool32? geometryStreams = null
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

            if (transformFeedback is not null)
            {
                TransformFeedback = transformFeedback.Value;
            }

            if (geometryStreams is not null)
            {
                GeometryStreams = geometryStreams.Value;
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
        [NativeName("Name", "transformFeedback")]
        public Bool32 TransformFeedback;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "geometryStreams")]
        public Bool32 GeometryStreams;
    }
}
