// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkImageBlit")]
    public unsafe partial struct ImageBlit
    {
        public ImageBlit
        (
            ImageSubresourceLayers? srcSubresource = null,
            ImageSubresourceLayers? dstSubresource = null
        ) : this()
        {
            if (srcSubresource is not null)
            {
                SrcSubresource = srcSubresource.Value;
            }

            if (dstSubresource is not null)
            {
                DstSubresource = dstSubresource.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkImageSubresourceLayers")]
        [NativeName("Type.Name", "VkImageSubresourceLayers")]
        [NativeName("Name", "srcSubresource")]
        public ImageSubresourceLayers SrcSubresource;
        /// <summary></summary>
        [NativeName("Type", "VkOffset3D")]
        [NativeName("Type.Name", "VkOffset3D")]
        [NativeName("Name", "srcOffsets")]
        public SrcOffsetsBuffer SrcOffsets;

        public struct SrcOffsetsBuffer
        {
            public Offset3D Element0;
            public Offset3D Element1;
            public ref Offset3D this[int index]
            {
                get
                {
                    if (index > 1 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (Offset3D* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<Offset3D> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 2);
#endif
        }

/// <summary></summary>
        [NativeName("Type", "VkImageSubresourceLayers")]
        [NativeName("Type.Name", "VkImageSubresourceLayers")]
        [NativeName("Name", "dstSubresource")]
        public ImageSubresourceLayers DstSubresource;
        /// <summary></summary>
        [NativeName("Type", "VkOffset3D")]
        [NativeName("Type.Name", "VkOffset3D")]
        [NativeName("Name", "dstOffsets")]
        public DstOffsetsBuffer DstOffsets;

        public struct DstOffsetsBuffer
        {
            public Offset3D Element0;
            public Offset3D Element1;
            public ref Offset3D this[int index]
            {
                get
                {
                    if (index > 1 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (Offset3D* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<Offset3D> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 2);
#endif
        }

    }
}
