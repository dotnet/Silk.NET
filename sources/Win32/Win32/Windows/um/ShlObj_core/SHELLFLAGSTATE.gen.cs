// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHELLFLAGSTATE
{
    public BOOL _bitfield;

    [NativeTypeName("BOOL : 1")]
    public BOOL fShowAllObjects
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 31) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~0x1) | ((BOOL)(value) & 0x1); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fShowExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 30) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 1)) | (((BOOL)(value) & 0x1) << 1); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fNoConfirmRecycle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 29) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 2)) | (((BOOL)(value) & 0x1) << 2); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fShowSysFiles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 28) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 3)) | (((BOOL)(value) & 0x1) << 3); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fShowCompColor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 27) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 4)) | (((BOOL)(value) & 0x1) << 4); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fDoubleClickInWebView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 26) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 5)) | (((BOOL)(value) & 0x1) << 5); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fDesktopHTML
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 25) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 6)) | (((BOOL)(value) & 0x1) << 6); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fWin95Classic
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 24) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 7)) | (((BOOL)(value) & 0x1) << 7); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fDontPrettyPath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 23) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 8)) | (((BOOL)(value) & 0x1) << 8); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fShowAttribCol
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 22) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 9)) | (((BOOL)(value) & 0x1) << 9); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fMapNetDrvBtn
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 21) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 10)) | (((BOOL)(value) & 0x1) << 10); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fShowInfoTip
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 20) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 11)) | (((BOOL)(value) & 0x1) << 11); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fHideIcons
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 19) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 12)) | (((BOOL)(value) & 0x1) << 12); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fAutoCheckSelect
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 18) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 13)) | (((BOOL)(value) & 0x1) << 13); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fIconsOnly
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 17) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 14)) | (((BOOL)(value) & 0x1) << 14); }
    }

    [NativeTypeName("uint : 1")]
    public uint fRestFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (uint)((_bitfield >> 15) & 0x1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 15)) | (BOOL)((value & 0x1u) << 15); }
    }
}
