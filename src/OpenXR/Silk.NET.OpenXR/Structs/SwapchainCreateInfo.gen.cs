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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSwapchainCreateInfo")]
    public unsafe partial struct SwapchainCreateInfo
    {
        public SwapchainCreateInfo
        (
            StructureType type = StructureType.TypeSwapchainCreateInfo,
            void* next = default,
            SwapchainCreateFlags createFlags = default,
            SwapchainUsageFlags usageFlags = default,
            long format = default,
            uint sampleCount = default,
            uint width = default,
            uint height = default,
            uint faceCount = default,
            uint arraySize = default,
            uint mipCount = default
        )
        {
            Type = type;
            Next = next;
            CreateFlags = createFlags;
            UsageFlags = usageFlags;
            Format = format;
            SampleCount = sampleCount;
            Width = width;
            Height = height;
            FaceCount = faceCount;
            ArraySize = arraySize;
            MipCount = mipCount;
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
    }
}
