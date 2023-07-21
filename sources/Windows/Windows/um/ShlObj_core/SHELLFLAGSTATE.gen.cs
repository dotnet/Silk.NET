// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='SHELLFLAGSTATE.xml' path='doc/member[@name="SHELLFLAGSTATE"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHELLFLAGSTATE
{
    public BOOL _bitfield;

    /// <include file='SHELLFLAGSTATE.xml' path='doc/member[@name="SHELLFLAGSTATE.fShowAllObjects"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL fShowAllObjects
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

    /// <include file='SHELLFLAGSTATE.xml' path='doc/member[@name="SHELLFLAGSTATE.fShowExtensions"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL fShowExtensions
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

    /// <include file='SHELLFLAGSTATE.xml' path='doc/member[@name="SHELLFLAGSTATE.fNoConfirmRecycle"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL fNoConfirmRecycle
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

    /// <include file='SHELLFLAGSTATE.xml' path='doc/member[@name="SHELLFLAGSTATE.fShowSysFiles"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL fShowSysFiles
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

    /// <include file='SHELLFLAGSTATE.xml' path='doc/member[@name="SHELLFLAGSTATE.fShowCompColor"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL fShowCompColor
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

    /// <include file='SHELLFLAGSTATE.xml' path='doc/member[@name="SHELLFLAGSTATE.fDoubleClickInWebView"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL fDoubleClickInWebView
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

    /// <include file='SHELLFLAGSTATE.xml' path='doc/member[@name="SHELLFLAGSTATE.fDesktopHTML"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL fDesktopHTML
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

    /// <include file='SHELLFLAGSTATE.xml' path='doc/member[@name="SHELLFLAGSTATE.fWin95Classic"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL fWin95Classic
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

    /// <include file='SHELLFLAGSTATE.xml' path='doc/member[@name="SHELLFLAGSTATE.fDontPrettyPath"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL fDontPrettyPath
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

    /// <include file='SHELLFLAGSTATE.xml' path='doc/member[@name="SHELLFLAGSTATE.fShowAttribCol"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL fShowAttribCol
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield >> 9) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 9)) | (((BOOL)(value) & 0x1) << 9);
        }
    }

    /// <include file='SHELLFLAGSTATE.xml' path='doc/member[@name="SHELLFLAGSTATE.fMapNetDrvBtn"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL fMapNetDrvBtn
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield >> 10) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 10)) | (((BOOL)(value) & 0x1) << 10);
        }
    }

    /// <include file='SHELLFLAGSTATE.xml' path='doc/member[@name="SHELLFLAGSTATE.fShowInfoTip"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL fShowInfoTip
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield >> 11) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 11)) | (((BOOL)(value) & 0x1) << 11);
        }
    }

    /// <include file='SHELLFLAGSTATE.xml' path='doc/member[@name="SHELLFLAGSTATE.fHideIcons"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL fHideIcons
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield >> 12) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 12)) | (((BOOL)(value) & 0x1) << 12);
        }
    }

    /// <include file='SHELLFLAGSTATE.xml' path='doc/member[@name="SHELLFLAGSTATE.fAutoCheckSelect"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL fAutoCheckSelect
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield >> 13) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 13)) | (((BOOL)(value) & 0x1) << 13);
        }
    }

    /// <include file='SHELLFLAGSTATE.xml' path='doc/member[@name="SHELLFLAGSTATE.fIconsOnly"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL fIconsOnly
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield >> 14) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 14)) | (((BOOL)(value) & 0x1) << 14);
        }
    }

    /// <include file='SHELLFLAGSTATE.xml' path='doc/member[@name="SHELLFLAGSTATE.fRestFlags"]/*' />
    [NativeTypeName("uint : 1")]
    public uint fRestFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (uint)((_bitfield >> 15) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 15)) | (BOOL)((value & 0x1u) << 15);
        }
    }
}
