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
    [NativeName("Name", "VkViSurfaceCreateInfoNN")]
    public unsafe partial struct ViSurfaceCreateInfoNN
    {
        public ViSurfaceCreateInfoNN
        (
            StructureType sType = StructureType.VISurfaceCreateInfoNN,
            void* pNext = default,
            uint flags = default,
            void* window = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            Window = window;
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
        [NativeName("Type", "VkViSurfaceCreateFlagsNN")]
        [NativeName("Type.Name", "VkViSurfaceCreateFlagsNN")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "window")]
        public void* Window;
    }
}
