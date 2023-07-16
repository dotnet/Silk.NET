// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='CABINETSTATE.xml' path='doc/member[@name="CABINETSTATE"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct CABINETSTATE
{
    /// <include file='CABINETSTATE.xml' path='doc/member[@name="CABINETSTATE.cLength"]/*'/>
    [NativeTypeName("WORD")]
    public ushort cLength;
    /// <include file='CABINETSTATE.xml' path='doc/member[@name="CABINETSTATE.nVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort nVersion;
    public BOOL _bitfield;
    /// <include file='CABINETSTATE.xml' path='doc/member[@name="CABINETSTATE.fFullPathTitle"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fFullPathTitle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)(_bitfield & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0x1) | ((BOOL)(value) & 0x1);
        }
    }

    /// <include file='CABINETSTATE.xml' path='doc/member[@name="CABINETSTATE.fSaveLocalView"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fSaveLocalView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield >> 1) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 1)) | (((BOOL)(value) & 0x1) << 1);
        }
    }

    /// <include file='CABINETSTATE.xml' path='doc/member[@name="CABINETSTATE.fNotShell"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fNotShell
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield >> 2) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 2)) | (((BOOL)(value) & 0x1) << 2);
        }
    }

    /// <include file='CABINETSTATE.xml' path='doc/member[@name="CABINETSTATE.fSimpleDefault"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fSimpleDefault
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield >> 3) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 3)) | (((BOOL)(value) & 0x1) << 3);
        }
    }

    /// <include file='CABINETSTATE.xml' path='doc/member[@name="CABINETSTATE.fDontShowDescBar"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fDontShowDescBar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield >> 4) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 4)) | (((BOOL)(value) & 0x1) << 4);
        }
    }

    /// <include file='CABINETSTATE.xml' path='doc/member[@name="CABINETSTATE.fNewWindowMode"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fNewWindowMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield >> 5) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 5)) | (((BOOL)(value) & 0x1) << 5);
        }
    }

    /// <include file='CABINETSTATE.xml' path='doc/member[@name="CABINETSTATE.fShowCompColor"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fShowCompColor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield >> 6) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 6)) | (((BOOL)(value) & 0x1) << 6);
        }
    }

    /// <include file='CABINETSTATE.xml' path='doc/member[@name="CABINETSTATE.fDontPrettyNames"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fDontPrettyNames
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield >> 7) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 7)) | (((BOOL)(value) & 0x1) << 7);
        }
    }

    /// <include file='CABINETSTATE.xml' path='doc/member[@name="CABINETSTATE.fAdminsCreateCommonGroups"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fAdminsCreateCommonGroups
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield >> 8) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 8)) | (((BOOL)(value) & 0x1) << 8);
        }
    }

    /// <include file='CABINETSTATE.xml' path='doc/member[@name="CABINETSTATE.fUnusedFlags"]/*'/>
    [NativeTypeName("uint : 7")]
    public uint fUnusedFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (uint)((_bitfield >> 9) & 0x7F);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x7F << 9)) | (BOOL)((value & 0x7Fu) << 9);
        }
    }

    /// <include file='CABINETSTATE.xml' path='doc/member[@name="CABINETSTATE.fMenuEnumFilter"]/*'/>
    public uint fMenuEnumFilter;
}