// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='PROCESSOR_POWER_POLICY.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY"]/*'/>
public unsafe partial struct PROCESSOR_POWER_POLICY
{
    /// <include file='PROCESSOR_POWER_POLICY.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY.Revision"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Revision;
    /// <include file='PROCESSOR_POWER_POLICY.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY.DynamicThrottle"]/*'/>
    public byte DynamicThrottle;
    /// <include file='PROCESSOR_POWER_POLICY.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY.Spare"]/*'/>
    [NativeTypeName("BYTE[3]")]
    public fixed byte Spare[3];
    public uint _bitfield;
    /// <include file='PROCESSOR_POWER_POLICY.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY.DisableCStates"]/*'/>
    [NativeTypeName("DWORD : 1")]
    public uint DisableCStates
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return _bitfield & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
        }
    }

    /// <include file='PROCESSOR_POWER_POLICY.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY.Reserved"]/*'/>
    [NativeTypeName("DWORD : 31")]
    public uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 1) & 0x7FFFFFFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFFu) << 1);
        }
    }

    /// <include file='PROCESSOR_POWER_POLICY.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY.PolicyCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PolicyCount;
    /// <include file='PROCESSOR_POWER_POLICY.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY.Policy"]/*'/>
    [NativeTypeName("PROCESSOR_POWER_POLICY_INFO[3]")]
    public _Policy_e__FixedBuffer Policy;
    /// <include file='_Policy_e__FixedBuffer.xml' path='doc/member[@name="_Policy_e__FixedBuffer"]/*'/>
    public partial struct _Policy_e__FixedBuffer
    {
        public PROCESSOR_POWER_POLICY_INFO e0;
        public PROCESSOR_POWER_POLICY_INFO e1;
        public PROCESSOR_POWER_POLICY_INFO e2;
        [UnscopedRef]
        public ref PROCESSOR_POWER_POLICY_INFO this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<PROCESSOR_POWER_POLICY_INFO> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 3);
    }
}