// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct IMAGE_OS2_HEADER
{
    [NativeTypeName("WORD")]
    public ushort ne_magic;

    [NativeTypeName("CHAR")]
    public sbyte ne_ver;

    [NativeTypeName("CHAR")]
    public sbyte ne_rev;

    [NativeTypeName("WORD")]
    public ushort ne_enttab;

    [NativeTypeName("WORD")]
    public ushort ne_cbenttab;

    [NativeTypeName("LONG")]
    public int ne_crc;

    [NativeTypeName("WORD")]
    public ushort ne_flags;

    [NativeTypeName("WORD")]
    public ushort ne_autodata;

    [NativeTypeName("WORD")]
    public ushort ne_heap;

    [NativeTypeName("WORD")]
    public ushort ne_stack;

    [NativeTypeName("LONG")]
    public int ne_csip;

    [NativeTypeName("LONG")]
    public int ne_sssp;

    [NativeTypeName("WORD")]
    public ushort ne_cseg;

    [NativeTypeName("WORD")]
    public ushort ne_cmod;

    [NativeTypeName("WORD")]
    public ushort ne_cbnrestab;

    [NativeTypeName("WORD")]
    public ushort ne_segtab;

    [NativeTypeName("WORD")]
    public ushort ne_rsrctab;

    [NativeTypeName("WORD")]
    public ushort ne_restab;

    [NativeTypeName("WORD")]
    public ushort ne_modtab;

    [NativeTypeName("WORD")]
    public ushort ne_imptab;

    [NativeTypeName("LONG")]
    public int ne_nrestab;

    [NativeTypeName("WORD")]
    public ushort ne_cmovent;

    [NativeTypeName("WORD")]
    public ushort ne_align;

    [NativeTypeName("WORD")]
    public ushort ne_cres;
    public byte ne_exetyp;
    public byte ne_flagsothers;

    [NativeTypeName("WORD")]
    public ushort ne_pretthunks;

    [NativeTypeName("WORD")]
    public ushort ne_psegrefbytes;

    [NativeTypeName("WORD")]
    public ushort ne_swaparea;

    [NativeTypeName("WORD")]
    public ushort ne_expver;
}
