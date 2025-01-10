// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PROCESSOR_POWER_POLICY_INFO
{
    [NativeTypeName("DWORD")]
    public uint TimeCheck;

    [NativeTypeName("DWORD")]
    public uint DemoteLimit;

    [NativeTypeName("DWORD")]
    public uint PromoteLimit;
    public byte DemotePercent;
    public byte PromotePercent;

    [NativeTypeName("BYTE[2]")]
    public _Spare_e__FixedBuffer Spare;
    public uint _bitfield;

    [NativeTypeName("DWORD : 1")]
    public uint AllowDemotion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return _bitfield & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~0x1u) | (value & 0x1u); }
    }

    [NativeTypeName("DWORD : 1")]
    public uint AllowPromotion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 1) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1); }
    }

    [NativeTypeName("DWORD : 30")]
    public uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 2) & 0x3FFFFFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFFu) << 2); }
    }

    [InlineArray(2)]
    public partial struct _Spare_e__FixedBuffer
    {
        public byte e0;
    }
}
