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
    public unsafe struct CommandBufferInheritanceRenderPassTransformInfoQCOM
    {
        public CommandBufferInheritanceRenderPassTransformInfoQCOM
        (
            StructureType sType = StructureType.CommandBufferInheritanceRenderPassTransformInfoQCom,
            void* pNext = default,
            SurfaceTransformFlagsKHR transform = default,
            Rect2D renderArea = default
        )
        {
           SType = sType;
           PNext = pNext;
           Transform = transform;
           RenderArea = renderArea;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public SurfaceTransformFlagsKHR Transform;
/// <summary></summary>
        public Rect2D RenderArea;
    }
}
