// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace Silk.NET.Windows;

/// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT"]/*' />
public partial struct COMSTAT
{
    public uint _bitfield;

    /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.fCtsHold"]/*' />
    [NativeTypeName("DWORD : 1")]
    public uint fCtsHold
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

    /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.fDsrHold"]/*' />
    [NativeTypeName("DWORD : 1")]
    public uint fDsrHold
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

    /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.fRlsdHold"]/*' />
    [NativeTypeName("DWORD : 1")]
    public uint fRlsdHold
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 2) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
        }
    }

    /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.fXoffHold"]/*' />
    [NativeTypeName("DWORD : 1")]
    public uint fXoffHold
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 3) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
        }
    }

    /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.fXoffSent"]/*' />
    [NativeTypeName("DWORD : 1")]
    public uint fXoffSent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 4) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4);
        }
    }

    /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.fEof"]/*' />
    [NativeTypeName("DWORD : 1")]
    public uint fEof
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 5) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5);
        }
    }

    /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.fTxim"]/*' />
    [NativeTypeName("DWORD : 1")]
    public uint fTxim
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 6) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6);
        }
    }

    /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.fReserved"]/*' />
    [NativeTypeName("DWORD : 25")]
    public uint fReserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 7) & 0x1FFFFFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1FFFFFFu << 7)) | ((value & 0x1FFFFFFu) << 7);
        }
    }

    /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.cbInQue"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbInQue;

    /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.cbOutQue"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbOutQue;
}
