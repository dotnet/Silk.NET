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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrVirtualKeyboardTextureDataMETA")]
    public unsafe partial struct VirtualKeyboardTextureDataMETA
    {
        public VirtualKeyboardTextureDataMETA
        (
            StructureType? type = StructureType.TypeVirtualKeyboardTextureDataMeta,
            void* next = null,
            uint? textureWidth = null,
            uint? textureHeight = null,
            uint? bufferCapacityInput = null,
            uint? bufferCountOutput = null,
            byte* buffer = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (textureWidth is not null)
            {
                TextureWidth = textureWidth.Value;
            }

            if (textureHeight is not null)
            {
                TextureHeight = textureHeight.Value;
            }

            if (bufferCapacityInput is not null)
            {
                BufferCapacityInput = bufferCapacityInput.Value;
            }

            if (bufferCountOutput is not null)
            {
                BufferCountOutput = bufferCountOutput.Value;
            }

            if (buffer is not null)
            {
                Buffer = buffer;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "textureWidth")]
        public uint TextureWidth;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "textureHeight")]
        public uint TextureHeight;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bufferCapacityInput")]
        public uint BufferCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bufferCountOutput")]
        public uint BufferCountOutput;
/// <summary></summary>
        [NativeName("Type", "uint8_t*")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "buffer")]
        public byte* Buffer;
    }
}
