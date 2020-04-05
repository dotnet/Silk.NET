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
    public unsafe struct AttachmentReference
    {
        public AttachmentReference
        (
            uint attachment = default,
            ImageLayout layout = default
        )
        {
           Attachment = attachment;
           Layout = layout;
        }

/// <summary></summary>
        public uint Attachment;
/// <summary></summary>
        public ImageLayout Layout;
    }
}
