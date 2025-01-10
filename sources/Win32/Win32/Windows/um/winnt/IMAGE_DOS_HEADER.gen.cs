// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct IMAGE_DOS_HEADER
{
    [NativeTypeName("WORD")]
    public ushort e_magic;

    [NativeTypeName("WORD")]
    public ushort e_cblp;

    [NativeTypeName("WORD")]
    public ushort e_cp;

    [NativeTypeName("WORD")]
    public ushort e_crlc;

    [NativeTypeName("WORD")]
    public ushort e_cparhdr;

    [NativeTypeName("WORD")]
    public ushort e_minalloc;

    [NativeTypeName("WORD")]
    public ushort e_maxalloc;

    [NativeTypeName("WORD")]
    public ushort e_ss;

    [NativeTypeName("WORD")]
    public ushort e_sp;

    [NativeTypeName("WORD")]
    public ushort e_csum;

    [NativeTypeName("WORD")]
    public ushort e_ip;

    [NativeTypeName("WORD")]
    public ushort e_cs;

    [NativeTypeName("WORD")]
    public ushort e_lfarlc;

    [NativeTypeName("WORD")]
    public ushort e_ovno;

    [NativeTypeName("WORD[4]")]
    public _e_res_e__FixedBuffer e_res;

    [NativeTypeName("WORD")]
    public ushort e_oemid;

    [NativeTypeName("WORD")]
    public ushort e_oeminfo;

    [NativeTypeName("WORD[10]")]
    public _e_res2_e__FixedBuffer e_res2;

    [NativeTypeName("LONG")]
    public int e_lfanew;

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    [InlineArray(4)]
    public partial struct _e_res_e__FixedBuffer
    {
        public ushort e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    [InlineArray(10)]
    public partial struct _e_res2_e__FixedBuffer
    {
        public ushort e0;
    }
}
