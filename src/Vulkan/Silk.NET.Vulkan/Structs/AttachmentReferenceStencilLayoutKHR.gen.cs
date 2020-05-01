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
    public unsafe struct AttachmentReferenceStencilLayoutKHR
    {
        public AttachmentReferenceStencilLayoutKHR
        (
            StructureType sType = StructureType.AttachmentReferenceStencilLayout,
            void* pNext = default,
            ImageLayout stencilLayout = default
        )
        {
           SType = sType;
           PNext = pNext;
           StencilLayout = stencilLayout;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ImageLayout StencilLayout;
    }
}
