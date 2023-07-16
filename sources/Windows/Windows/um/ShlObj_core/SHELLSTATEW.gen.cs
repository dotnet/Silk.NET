// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHELLSTATEW
{
    public BOOL _bitfield1;
    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fShowAllObjects"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fShowAllObjects
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)(_bitfield1 & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~0x1) | ((BOOL)(value) & 0x1);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fShowExtensions"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fShowExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 1) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 1)) | (((BOOL)(value) & 0x1) << 1);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fNoConfirmRecycle"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fNoConfirmRecycle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 2) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 2)) | (((BOOL)(value) & 0x1) << 2);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fShowSysFiles"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fShowSysFiles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 3) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 3)) | (((BOOL)(value) & 0x1) << 3);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fShowCompColor"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fShowCompColor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 4) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 4)) | (((BOOL)(value) & 0x1) << 4);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fDoubleClickInWebView"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fDoubleClickInWebView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 5) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 5)) | (((BOOL)(value) & 0x1) << 5);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fDesktopHTML"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fDesktopHTML
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 6) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 6)) | (((BOOL)(value) & 0x1) << 6);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fWin95Classic"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fWin95Classic
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 7) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 7)) | (((BOOL)(value) & 0x1) << 7);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fDontPrettyPath"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fDontPrettyPath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 8) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 8)) | (((BOOL)(value) & 0x1) << 8);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fShowAttribCol"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fShowAttribCol
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 9) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 9)) | (((BOOL)(value) & 0x1) << 9);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fMapNetDrvBtn"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fMapNetDrvBtn
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 10) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 10)) | (((BOOL)(value) & 0x1) << 10);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fShowInfoTip"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fShowInfoTip
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 11) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 11)) | (((BOOL)(value) & 0x1) << 11);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fHideIcons"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fHideIcons
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 12) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 12)) | (((BOOL)(value) & 0x1) << 12);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fWebView"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fWebView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 13) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 13)) | (((BOOL)(value) & 0x1) << 13);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fFilter"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 14) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 14)) | (((BOOL)(value) & 0x1) << 14);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fShowSuperHidden"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fShowSuperHidden
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 15) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 15)) | (((BOOL)(value) & 0x1) << 15);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fNoNetCrawling"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fNoNetCrawling
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 16) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 16)) | (((BOOL)(value) & 0x1) << 16);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.dwWin95Unused"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwWin95Unused;
    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.uWin95Unused"]/*'/>
    public uint uWin95Unused;
    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.lParamSort"]/*'/>
    [NativeTypeName("LONG")]
    public int lParamSort;
    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.iSortDirection"]/*'/>
    public int iSortDirection;
    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.version"]/*'/>
    public uint version;
    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.uNotUsed"]/*'/>
    public uint uNotUsed;
    public BOOL _bitfield2;
    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fSepProcess"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fSepProcess
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)(_bitfield2 & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~0x1) | ((BOOL)(value) & 0x1);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fStartPanelOn"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fStartPanelOn
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield2 >> 1) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 1)) | (((BOOL)(value) & 0x1) << 1);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fShowStartPage"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fShowStartPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield2 >> 2) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 2)) | (((BOOL)(value) & 0x1) << 2);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fAutoCheckSelect"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fAutoCheckSelect
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield2 >> 3) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 3)) | (((BOOL)(value) & 0x1) << 3);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fIconsOnly"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fIconsOnly
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield2 >> 4) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 4)) | (((BOOL)(value) & 0x1) << 4);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fShowTypeOverlay"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fShowTypeOverlay
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield2 >> 5) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 5)) | (((BOOL)(value) & 0x1) << 5);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fShowStatusBar"]/*'/>
    [NativeTypeName("BOOL : 1")]
    public BOOL fShowStatusBar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield2 >> 6) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 6)) | (((BOOL)(value) & 0x1) << 6);
        }
    }

    /// <include file='SHELLSTATEW.xml' path='doc/member[@name="SHELLSTATEW.fSpareFlags"]/*'/>
    [NativeTypeName("uint : 9")]
    public uint fSpareFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (uint)((_bitfield2 >> 7) & 0x1FF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1FF << 7)) | (BOOL)((value & 0x1FFu) << 7);
        }
    }
}