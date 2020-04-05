// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct AttachmentDescription
    {
        public AttachmentDescription
        (
            AttachmentDescriptionFlags flags = default,
            Format format = default,
            SampleCountFlags samples = default,
            AttachmentLoadOp loadOp = default,
            AttachmentStoreOp storeOp = default,
            AttachmentLoadOp stencilLoadOp = default,
            AttachmentStoreOp stencilStoreOp = default,
            ImageLayout initialLayout = default,
            ImageLayout finalLayout = default
        )
        {
           Flags = flags;
           Format = format;
           Samples = samples;
           LoadOp = loadOp;
           StoreOp = storeOp;
           StencilLoadOp = stencilLoadOp;
           StencilStoreOp = stencilStoreOp;
           InitialLayout = initialLayout;
           FinalLayout = finalLayout;
        }

/// <summary></summary>
        public AttachmentDescriptionFlags Flags;
/// <summary></summary>
        public Format Format;
/// <summary></summary>
        public SampleCountFlags Samples;
/// <summary></summary>
        public AttachmentLoadOp LoadOp;
/// <summary></summary>
        public AttachmentStoreOp StoreOp;
/// <summary></summary>
        public AttachmentLoadOp StencilLoadOp;
/// <summary></summary>
        public AttachmentStoreOp StencilStoreOp;
/// <summary></summary>
        public ImageLayout InitialLayout;
/// <summary></summary>
        public ImageLayout FinalLayout;
    }
}
