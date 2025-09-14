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
    [NativeName("Name", "VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV")]
    public unsafe partial struct ClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV
    {
        public ClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV
        (
            uint? geometryIndex = null,
            uint? reserved = null,
            uint? geometryFlags = null
        ) : this()
        {
            if (geometryIndex is not null)
            {
                GeometryIndex = geometryIndex.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }

            if (geometryFlags is not null)
            {
                GeometryFlags = geometryFlags.Value;
            }
        }


        private uint _bitfield1;

        public uint GeometryIndex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0xFFFFFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0xFFFFFFu) | (uint)((uint)(value) & 0xFFFFFFu));
        }

        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 24) & 0x1Fu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1Fu << 24)) | (uint)(((uint)(value) & 0x1Fu) << 24));
        }

        public uint GeometryFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 29) & 0x7u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x7u << 29)) | (uint)(((uint)(value) & 0x7u) << 29));
        }
    }
}
