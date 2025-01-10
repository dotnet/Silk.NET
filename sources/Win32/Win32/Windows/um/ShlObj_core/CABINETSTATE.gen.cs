// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct CABINETSTATE
{
    [NativeTypeName("WORD")]
    public ushort cLength;

    [NativeTypeName("WORD")]
    public ushort nVersion;
    public BOOL _bitfield;

    [NativeTypeName("BOOL : 1")]
    public BOOL fFullPathTitle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 31) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~0x1) | ((BOOL)(value) & 0x1); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fSaveLocalView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 30) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 1)) | (((BOOL)(value) & 0x1) << 1); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fNotShell
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 29) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 2)) | (((BOOL)(value) & 0x1) << 2); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fSimpleDefault
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 28) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 3)) | (((BOOL)(value) & 0x1) << 3); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fDontShowDescBar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 27) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 4)) | (((BOOL)(value) & 0x1) << 4); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fNewWindowMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 26) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 5)) | (((BOOL)(value) & 0x1) << 5); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fShowCompColor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 25) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 6)) | (((BOOL)(value) & 0x1) << 6); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fDontPrettyNames
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 24) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 7)) | (((BOOL)(value) & 0x1) << 7); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fAdminsCreateCommonGroups
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield << 23) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1 << 8)) | (((BOOL)(value) & 0x1) << 8); }
    }

    [NativeTypeName("uint : 7")]
    public uint fUnusedFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (uint)((_bitfield >> 9) & 0x7F); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x7F << 9)) | (BOOL)((value & 0x7Fu) << 9); }
    }
    public uint fMenuEnumFilter;
}
