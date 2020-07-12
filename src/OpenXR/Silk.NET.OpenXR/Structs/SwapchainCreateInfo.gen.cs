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

namespace Silk.NET.OpenXR
{
    public unsafe struct SwapchainCreateInfo
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
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public SwapchainCreateFlags CreateFlags;
/// <summary></summary>
        public SwapchainUsageFlags UsageFlags;
/// <summary></summary>
        public long Format;
/// <summary></summary>
        public uint SampleCount;
/// <summary></summary>
        public uint Width;
/// <summary></summary>
        public uint Height;
/// <summary></summary>
        public uint FaceCount;
/// <summary></summary>
        public uint ArraySize;
/// <summary></summary>
        public uint MipCount;
    }
}
