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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_DESC")]
    public unsafe partial struct RaytracingInstanceDesc
    {
        public RaytracingInstanceDesc
        (
            uint? instanceID = null,
            uint? instanceMask = null,
            uint? instanceContributionToHitGroupIndex = null,
            uint? flags = null,
            ulong? accelerationStructure = null
        ) : this()
        {
            if (instanceID is not null)
            {
                InstanceID = instanceID.Value;
            }

            if (instanceMask is not null)
            {
                InstanceMask = instanceMask.Value;
            }

            if (instanceContributionToHitGroupIndex is not null)
            {
                InstanceContributionToHitGroupIndex = instanceContributionToHitGroupIndex.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (accelerationStructure is not null)
            {
                AccelerationStructure = accelerationStructure.Value;
            }
        }

        [NativeName("Type", "FLOAT[3][4]")]
        [NativeName("Type.Name", "FLOAT[3][4]")]
        [NativeName("Name", "Transform")]
        public fixed float Transform[12];

        private uint _bitfield1;

        public uint InstanceID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0xFFFFFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0xFFFFFFu) | (uint)((uint)(value) & 0xFFFFFFu));
        }

        public uint InstanceMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 24) & 0xFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0xFFu << 24)) | (uint)(((uint)(value) & 0xFFu) << 24));
        }

        private uint _bitfield2;

        public uint InstanceContributionToHitGroupIndex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield2 & 0xFFFFFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield2 = (uint)((uint)(_bitfield2 & ~0xFFFFFFu) | (uint)((uint)(value) & 0xFFFFFFu));
        }

        public uint Flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield2 >> 24) & 0xFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield2 = (uint)((uint)(_bitfield2 & ~(0xFFu << 24)) | (uint)(((uint)(value) & 0xFFu) << 24));
        }

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "AccelerationStructure")]
        public ulong AccelerationStructure;
    }
}
