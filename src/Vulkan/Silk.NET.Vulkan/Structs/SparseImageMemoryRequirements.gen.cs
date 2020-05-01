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
    public unsafe struct SparseImageMemoryRequirements
    {
        public SparseImageMemoryRequirements
        (
            SparseImageFormatProperties formatProperties = default,
            uint imageMipTailFirstLod = default,
            ulong imageMipTailSize = default,
            ulong imageMipTailOffset = default,
            ulong imageMipTailStride = default
        )
        {
           FormatProperties = formatProperties;
           ImageMipTailFirstLod = imageMipTailFirstLod;
           ImageMipTailSize = imageMipTailSize;
           ImageMipTailOffset = imageMipTailOffset;
           ImageMipTailStride = imageMipTailStride;
        }

/// <summary></summary>
        public SparseImageFormatProperties FormatProperties;
/// <summary></summary>
        public uint ImageMipTailFirstLod;
/// <summary></summary>
        public ulong ImageMipTailSize;
/// <summary></summary>
        public ulong ImageMipTailOffset;
/// <summary></summary>
        public ulong ImageMipTailStride;
    }
}
