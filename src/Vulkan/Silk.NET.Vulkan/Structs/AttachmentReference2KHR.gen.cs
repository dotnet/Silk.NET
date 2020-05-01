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
    public unsafe struct AttachmentReference2KHR
    {
        public AttachmentReference2KHR
        (
            StructureType sType = StructureType.AttachmentReference2,
            void* pNext = default,
            uint attachment = default,
            ImageLayout layout = default,
            ImageAspectFlags aspectMask = default
        )
        {
           SType = sType;
           PNext = pNext;
           Attachment = attachment;
           Layout = layout;
           AspectMask = aspectMask;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Attachment;
/// <summary></summary>
        public ImageLayout Layout;
/// <summary></summary>
        public ImageAspectFlags AspectMask;
    }
}
