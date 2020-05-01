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
    public unsafe struct ImageFormatProperties
    {
        public ImageFormatProperties
        (
            Extent3D maxExtent = default,
            uint maxMipLevels = default,
            uint maxArrayLayers = default,
            SampleCountFlags sampleCounts = default,
            ulong maxResourceSize = default
        )
        {
           MaxExtent = maxExtent;
           MaxMipLevels = maxMipLevels;
           MaxArrayLayers = maxArrayLayers;
           SampleCounts = sampleCounts;
           MaxResourceSize = maxResourceSize;
        }

/// <summary></summary>
        public Extent3D MaxExtent;
/// <summary></summary>
        public uint MaxMipLevels;
/// <summary></summary>
        public uint MaxArrayLayers;
/// <summary></summary>
        public SampleCountFlags SampleCounts;
/// <summary></summary>
        public ulong MaxResourceSize;
    }
}
