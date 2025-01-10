// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_RAYTRACING_INSTANCE_DESC
{
    [NativeTypeName("FLOAT[3][4]")]
    public _Transform_e__FixedBuffer Transform;
    public uint _bitfield1;

    [NativeTypeName("uint : 24")]
    public uint InstanceID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return _bitfield1 & 0xFFFFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield1 = (_bitfield1 & ~0xFFFFFFu) | (value & 0xFFFFFFu); }
    }

    [NativeTypeName("uint : 8")]
    public uint InstanceMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield1 >> 24) & 0xFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield1 = (_bitfield1 & ~(0xFFu << 24)) | ((value & 0xFFu) << 24); }
    }
    public uint _bitfield2;

    [NativeTypeName("uint : 24")]
    public uint InstanceContributionToHitGroupIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return _bitfield2 & 0xFFFFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (_bitfield2 & ~0xFFFFFFu) | (value & 0xFFFFFFu); }
    }

    [NativeTypeName("uint : 8")]
    public uint Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield2 >> 24) & 0xFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (_bitfield2 & ~(0xFFu << 24)) | ((value & 0xFFu) << 24); }
    }

    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong AccelerationStructure;

    [InlineArray(3 * 4)]
    public partial struct _Transform_e__FixedBuffer
    {
        public float e0_0;
    }
}
