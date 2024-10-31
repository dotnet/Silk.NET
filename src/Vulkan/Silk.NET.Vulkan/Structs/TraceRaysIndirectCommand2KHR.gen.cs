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
    [NativeName("Name", "VkTraceRaysIndirectCommand2KHR")]
    public unsafe partial struct TraceRaysIndirectCommand2KHR
    {
        public TraceRaysIndirectCommand2KHR
        (
            ulong? raygenShaderRecordAddress = null,
            ulong? raygenShaderRecordSize = null,
            ulong? missShaderBindingTableAddress = null,
            ulong? missShaderBindingTableSize = null,
            ulong? missShaderBindingTableStride = null,
            ulong? hitShaderBindingTableAddress = null,
            ulong? hitShaderBindingTableSize = null,
            ulong? hitShaderBindingTableStride = null,
            ulong? callableShaderBindingTableAddress = null,
            ulong? callableShaderBindingTableSize = null,
            ulong? callableShaderBindingTableStride = null,
            uint? width = null,
            uint? height = null,
            uint? depth = null
        ) : this()
        {
            if (raygenShaderRecordAddress is not null)
            {
                RaygenShaderRecordAddress = raygenShaderRecordAddress.Value;
            }

            if (raygenShaderRecordSize is not null)
            {
                RaygenShaderRecordSize = raygenShaderRecordSize.Value;
            }

            if (missShaderBindingTableAddress is not null)
            {
                MissShaderBindingTableAddress = missShaderBindingTableAddress.Value;
            }

            if (missShaderBindingTableSize is not null)
            {
                MissShaderBindingTableSize = missShaderBindingTableSize.Value;
            }

            if (missShaderBindingTableStride is not null)
            {
                MissShaderBindingTableStride = missShaderBindingTableStride.Value;
            }

            if (hitShaderBindingTableAddress is not null)
            {
                HitShaderBindingTableAddress = hitShaderBindingTableAddress.Value;
            }

            if (hitShaderBindingTableSize is not null)
            {
                HitShaderBindingTableSize = hitShaderBindingTableSize.Value;
            }

            if (hitShaderBindingTableStride is not null)
            {
                HitShaderBindingTableStride = hitShaderBindingTableStride.Value;
            }

            if (callableShaderBindingTableAddress is not null)
            {
                CallableShaderBindingTableAddress = callableShaderBindingTableAddress.Value;
            }

            if (callableShaderBindingTableSize is not null)
            {
                CallableShaderBindingTableSize = callableShaderBindingTableSize.Value;
            }

            if (callableShaderBindingTableStride is not null)
            {
                CallableShaderBindingTableStride = callableShaderBindingTableStride.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (depth is not null)
            {
                Depth = depth.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "raygenShaderRecordAddress")]
        public ulong RaygenShaderRecordAddress;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "raygenShaderRecordSize")]
        public ulong RaygenShaderRecordSize;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "missShaderBindingTableAddress")]
        public ulong MissShaderBindingTableAddress;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "missShaderBindingTableSize")]
        public ulong MissShaderBindingTableSize;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "missShaderBindingTableStride")]
        public ulong MissShaderBindingTableStride;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "hitShaderBindingTableAddress")]
        public ulong HitShaderBindingTableAddress;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "hitShaderBindingTableSize")]
        public ulong HitShaderBindingTableSize;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "hitShaderBindingTableStride")]
        public ulong HitShaderBindingTableStride;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "callableShaderBindingTableAddress")]
        public ulong CallableShaderBindingTableAddress;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "callableShaderBindingTableSize")]
        public ulong CallableShaderBindingTableSize;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "callableShaderBindingTableStride")]
        public ulong CallableShaderBindingTableStride;
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
        [NativeName("Name", "depth")]
        public uint Depth;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
