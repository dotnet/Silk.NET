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
    public unsafe struct PhysicalDeviceTransformFeedbackFeaturesEXT
    {
        public PhysicalDeviceTransformFeedbackFeaturesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceTransformFeedbackFeaturesExt,
            void* pNext = default,
            Bool32 transformFeedback = default,
            Bool32 geometryStreams = default
        )
        {
           SType = sType;
           PNext = pNext;
           TransformFeedback = transformFeedback;
           GeometryStreams = geometryStreams;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 TransformFeedback;
/// <summary></summary>
        public Bool32 GeometryStreams;
    }
}
