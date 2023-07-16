// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace Silk.NET.Windows;
/// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA"]/*'/>
public partial struct FPO_DATA
{
    /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.ulOffStart"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ulOffStart;
    /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.cbProcSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbProcSize;
    /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.cdwLocals"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cdwLocals;
    /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.cdwParams"]/*'/>
    [NativeTypeName("WORD")]
    public ushort cdwParams;
    public ushort _bitfield;
    /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.cbProlog"]/*'/>
    [NativeTypeName("WORD : 8")]
    public ushort cbProlog
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (ushort)(_bitfield & 0xFFu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (ushort)((_bitfield & ~0xFFu) | (value & 0xFFu));
        }
    }

    /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.cbRegs"]/*'/>
    [NativeTypeName("WORD : 3")]
    public ushort cbRegs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (ushort)((_bitfield >> 8) & 0x7u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (ushort)((_bitfield & ~(0x7u << 8)) | ((value & 0x7u) << 8));
        }
    }

    /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.fHasSEH"]/*'/>
    [NativeTypeName("WORD : 1")]
    public ushort fHasSEH
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (ushort)((_bitfield >> 11) & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (ushort)((_bitfield & ~(0x1u << 11)) | ((value & 0x1u) << 11));
        }
    }

    /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.fUseBP"]/*'/>
    [NativeTypeName("WORD : 1")]
    public ushort fUseBP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (ushort)((_bitfield >> 12) & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (ushort)((_bitfield & ~(0x1u << 12)) | ((value & 0x1u) << 12));
        }
    }

    /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.reserved"]/*'/>
    [NativeTypeName("WORD : 1")]
    public ushort reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (ushort)((_bitfield >> 13) & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (ushort)((_bitfield & ~(0x1u << 13)) | ((value & 0x1u) << 13));
        }
    }

    /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.cbFrame"]/*'/>
    [NativeTypeName("WORD : 2")]
    public ushort cbFrame
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (ushort)((_bitfield >> 14) & 0x3u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (ushort)((_bitfield & ~(0x3u << 14)) | ((value & 0x3u) << 14));
        }
    }
}