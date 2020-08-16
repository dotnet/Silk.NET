// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkRenderPassTransformBeginInfoQCOM")]
    public unsafe partial struct RenderPassTransformBeginInfoQCOM
    {
        public RenderPassTransformBeginInfoQCOM
        (
            StructureType sType = StructureType.RenderPassTransformBeginInfoQCom,
            void* pNext = default,
            SurfaceTransformFlagsKHR transform = default
        )
        {
            SType = sType;
            PNext = pNext;
            Transform = transform;
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
        [NativeName("Type", "VkSurfaceTransformFlagBitsKHR")]
        [NativeName("Type.Name", "VkSurfaceTransformFlagBitsKHR")]
        [NativeName("Name", "transform")]
        public SurfaceTransformFlagsKHR Transform;
    }
}
