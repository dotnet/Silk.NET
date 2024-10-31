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
    [NativeName("Name", "XrSwapchainCreateInfo")]
    public unsafe partial struct SwapchainCreateInfo
    {
        public SwapchainCreateInfo
        (
            StructureType? type = StructureType.TypeSwapchainCreateInfo,
            void* next = null,
            SwapchainCreateFlags? createFlags = null,
            SwapchainUsageFlags? usageFlags = null,
            long? format = null,
            uint? sampleCount = null,
            uint? width = null,
            uint? height = null,
            uint? faceCount = null,
            uint? arraySize = null,
            uint? mipCount = null
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

            if (createFlags is not null)
            {
                CreateFlags = createFlags.Value;
            }

            if (usageFlags is not null)
            {
                UsageFlags = usageFlags.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (sampleCount is not null)
            {
                SampleCount = sampleCount.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (faceCount is not null)
            {
                FaceCount = faceCount.Value;
            }

            if (arraySize is not null)
            {
                ArraySize = arraySize.Value;
            }

            if (mipCount is not null)
            {
                MipCount = mipCount.Value;
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
        [NativeName("Type", "XrSwapchainCreateFlags")]
        [NativeName("Type.Name", "XrSwapchainCreateFlags")]
        [NativeName("Name", "createFlags")]
        public SwapchainCreateFlags CreateFlags;
/// <summary></summary>
        [NativeName("Type", "XrSwapchainUsageFlags")]
        [NativeName("Type.Name", "XrSwapchainUsageFlags")]
        [NativeName("Name", "usageFlags")]
        public SwapchainUsageFlags UsageFlags;
/// <summary></summary>
        [NativeName("Type", "int64_t")]
        [NativeName("Type.Name", "int64_t")]
        [NativeName("Name", "format")]
        public long Format;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sampleCount")]
        public uint SampleCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "width")]
        public uint Width;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "height")]
        public uint Height;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "faceCount")]
        public uint FaceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "arraySize")]
        public uint ArraySize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "mipCount")]
        public uint MipCount;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
