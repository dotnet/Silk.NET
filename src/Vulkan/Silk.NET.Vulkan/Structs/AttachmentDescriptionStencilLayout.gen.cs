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
    public unsafe struct AttachmentDescriptionStencilLayout
    {
        public AttachmentDescriptionStencilLayout
        (
            StructureType sType = StructureType.AttachmentDescriptionStencilLayout,
            void* pNext = default,
            ImageLayout stencilInitialLayout = default,
            ImageLayout stencilFinalLayout = default
        )
        {
           SType = sType;
           PNext = pNext;
           StencilInitialLayout = stencilInitialLayout;
           StencilFinalLayout = stencilFinalLayout;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ImageLayout StencilInitialLayout;
/// <summary></summary>
        public ImageLayout StencilFinalLayout;
    }
}
