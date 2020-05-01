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
    public unsafe struct BufferImageCopy
    {
        public BufferImageCopy
        (
            ulong bufferOffset = default,
            uint bufferRowLength = default,
            uint bufferImageHeight = default,
            ImageSubresourceLayers imageSubresource = default,
            Offset3D imageOffset = default,
            Extent3D imageExtent = default
        )
        {
           BufferOffset = bufferOffset;
           BufferRowLength = bufferRowLength;
           BufferImageHeight = bufferImageHeight;
           ImageSubresource = imageSubresource;
           ImageOffset = imageOffset;
           ImageExtent = imageExtent;
        }

/// <summary></summary>
        public ulong BufferOffset;
/// <summary></summary>
        public uint BufferRowLength;
/// <summary></summary>
        public uint BufferImageHeight;
/// <summary></summary>
        public ImageSubresourceLayers ImageSubresource;
/// <summary></summary>
        public Offset3D ImageOffset;
/// <summary></summary>
        public Extent3D ImageExtent;
    }
}
