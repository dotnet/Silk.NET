// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace Silk.NET.Windows;
/// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO"]/*'/>
public unsafe partial struct PROCESSOR_POWER_POLICY_INFO
{
    /// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO.TimeCheck"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TimeCheck;
    /// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO.DemoteLimit"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DemoteLimit;
    /// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO.PromoteLimit"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PromoteLimit;
    /// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO.DemotePercent"]/*'/>
    public byte DemotePercent;
    /// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO.PromotePercent"]/*'/>
    public byte PromotePercent;
    /// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO.Spare"]/*'/>
    [NativeTypeName("BYTE[2]")]
    public fixed byte Spare[2];
    public uint _bitfield;
    /// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO.AllowDemotion"]/*'/>
    [NativeTypeName("DWORD : 1")]
    public uint AllowDemotion
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

    /// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO.AllowPromotion"]/*'/>
    [NativeTypeName("DWORD : 1")]
    public uint AllowPromotion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 1) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
        }
    }

    /// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO.Reserved"]/*'/>
    [NativeTypeName("DWORD : 30")]
    public uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 2) & 0x3FFFFFFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFFu) << 2);
        }
    }
}