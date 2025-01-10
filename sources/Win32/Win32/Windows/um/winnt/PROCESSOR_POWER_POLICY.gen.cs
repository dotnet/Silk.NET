// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PROCESSOR_POWER_POLICY
{
    [NativeTypeName("DWORD")]
    public uint Revision;
    public byte DynamicThrottle;

    [NativeTypeName("BYTE[3]")]
    public _Spare_e__FixedBuffer Spare;
    public uint _bitfield;

    [NativeTypeName("DWORD : 1")]
    public uint DisableCStates
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return _bitfield & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~0x1u) | (value & 0x1u); }
    }

    [NativeTypeName("DWORD : 31")]
    public uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 1) & 0x7FFFFFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFFu) << 1); }
    }

    [NativeTypeName("DWORD")]
    public uint PolicyCount;

    [NativeTypeName("PROCESSOR_POWER_POLICY_INFO[3]")]
    public _Policy_e__FixedBuffer Policy;

    [InlineArray(3)]
    public partial struct _Spare_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(3)]
    public partial struct _Policy_e__FixedBuffer
    {
        public PROCESSOR_POWER_POLICY_INFO e0;
    }
}
