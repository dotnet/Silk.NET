// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkNativeBufferANDROID")]
    public unsafe partial struct NativeBufferANDROID
    {
        public NativeBufferANDROID
        (
            StructureType? sType = StructureType.NativeBufferAndroid,
            void* pNext = null,
            void* handle = null,
            int? stride = null,
            int? format = null,
            int? usage = null,
            NativeBufferUsage2ANDROID? usage2 = null
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

            if (handle is not null)
            {
                Handle = handle;
            }

            if (stride is not null)
            {
                Stride = stride.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (usage2 is not null)
            {
                Usage2 = usage2.Value;
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
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "handle")]
        public void* Handle;
/// <summary></summary>
        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "stride")]
        public int Stride;
/// <summary></summary>
        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "format")]
        public int Format;
/// <summary></summary>
        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "usage")]
        public int Usage;
/// <summary></summary>
        [NativeName("Type", "VkNativeBufferUsage2ANDROID")]
        [NativeName("Type.Name", "VkNativeBufferUsage2ANDROID")]
        [NativeName("Name", "usage2")]
        public NativeBufferUsage2ANDROID Usage2;
    }
}
