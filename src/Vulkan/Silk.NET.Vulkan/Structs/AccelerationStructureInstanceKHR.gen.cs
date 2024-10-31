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
    [NativeName("Name", "VkAccelerationStructureInstanceKHR")]
    [NativeName("Aliases", "VkAccelerationStructureInstanceNV")]
    public unsafe partial struct AccelerationStructureInstanceKHR
    {
        public AccelerationStructureInstanceKHR
        (
            TransformMatrixKHR? transform = null,
            uint? instanceCustomIndex = null,
            uint? mask = null,
            uint? instanceShaderBindingTableRecordOffset = null,
            GeometryInstanceFlagsKHR? flags = null,
            ulong? accelerationStructureReference = null
        ) : this()
        {
            if (transform is not null)
            {
                Transform = transform.Value;
            }

            if (instanceCustomIndex is not null)
            {
                InstanceCustomIndex = instanceCustomIndex.Value;
            }

            if (mask is not null)
            {
                Mask = mask.Value;
            }

            if (instanceShaderBindingTableRecordOffset is not null)
            {
                InstanceShaderBindingTableRecordOffset = instanceShaderBindingTableRecordOffset.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (accelerationStructureReference is not null)
            {
                AccelerationStructureReference = accelerationStructureReference.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkTransformMatrixKHR")]
        [NativeName("Type.Name", "VkTransformMatrixKHR")]
        [NativeName("Name", "transform")]
        public TransformMatrixKHR Transform;

        private uint _bitfield1;

        public uint InstanceCustomIndex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0xFFFFFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0xFFFFFFu) | (uint)((uint)(value) & 0xFFFFFFu));
        }

        public uint Mask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 24) & 0xFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0xFFu << 24)) | (uint)(((uint)(value) & 0xFFu) << 24));
        }

        private uint _bitfield2;

        public uint InstanceShaderBindingTableRecordOffset
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield2 & 0xFFFFFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield2 = (uint)((uint)(_bitfield2 & ~0xFFFFFFu) | (uint)((uint)(value) & 0xFFFFFFu));
        }

        public GeometryInstanceFlagsKHR Flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (GeometryInstanceFlagsKHR)((_bitfield2 >> 24) & 0xFF);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield2 = (uint)((GeometryInstanceFlagsKHR)(_bitfield2 & ~(0xFF << 24)) | (GeometryInstanceFlagsKHR)(((int)(value) & 0xFF) << 24));
        }
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "accelerationStructureReference")]
        public ulong AccelerationStructureReference;
    }
}
