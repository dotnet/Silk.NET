// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct IMAGE_VXD_HEADER
{
    [NativeTypeName("WORD")]
    public ushort e32_magic;
    public byte e32_border;
    public byte e32_worder;

    [NativeTypeName("DWORD")]
    public uint e32_level;

    [NativeTypeName("WORD")]
    public ushort e32_cpu;

    [NativeTypeName("WORD")]
    public ushort e32_os;

    [NativeTypeName("DWORD")]
    public uint e32_ver;

    [NativeTypeName("DWORD")]
    public uint e32_mflags;

    [NativeTypeName("DWORD")]
    public uint e32_mpages;

    [NativeTypeName("DWORD")]
    public uint e32_startobj;

    [NativeTypeName("DWORD")]
    public uint e32_eip;

    [NativeTypeName("DWORD")]
    public uint e32_stackobj;

    [NativeTypeName("DWORD")]
    public uint e32_esp;

    [NativeTypeName("DWORD")]
    public uint e32_pagesize;

    [NativeTypeName("DWORD")]
    public uint e32_lastpagesize;

    [NativeTypeName("DWORD")]
    public uint e32_fixupsize;

    [NativeTypeName("DWORD")]
    public uint e32_fixupsum;

    [NativeTypeName("DWORD")]
    public uint e32_ldrsize;

    [NativeTypeName("DWORD")]
    public uint e32_ldrsum;

    [NativeTypeName("DWORD")]
    public uint e32_objtab;

    [NativeTypeName("DWORD")]
    public uint e32_objcnt;

    [NativeTypeName("DWORD")]
    public uint e32_objmap;

    [NativeTypeName("DWORD")]
    public uint e32_itermap;

    [NativeTypeName("DWORD")]
    public uint e32_rsrctab;

    [NativeTypeName("DWORD")]
    public uint e32_rsrccnt;

    [NativeTypeName("DWORD")]
    public uint e32_restab;

    [NativeTypeName("DWORD")]
    public uint e32_enttab;

    [NativeTypeName("DWORD")]
    public uint e32_dirtab;

    [NativeTypeName("DWORD")]
    public uint e32_dircnt;

    [NativeTypeName("DWORD")]
    public uint e32_fpagetab;

    [NativeTypeName("DWORD")]
    public uint e32_frectab;

    [NativeTypeName("DWORD")]
    public uint e32_impmod;

    [NativeTypeName("DWORD")]
    public uint e32_impmodcnt;

    [NativeTypeName("DWORD")]
    public uint e32_impproc;

    [NativeTypeName("DWORD")]
    public uint e32_pagesum;

    [NativeTypeName("DWORD")]
    public uint e32_datapage;

    [NativeTypeName("DWORD")]
    public uint e32_preload;

    [NativeTypeName("DWORD")]
    public uint e32_nrestab;

    [NativeTypeName("DWORD")]
    public uint e32_cbnrestab;

    [NativeTypeName("DWORD")]
    public uint e32_nressum;

    [NativeTypeName("DWORD")]
    public uint e32_autodata;

    [NativeTypeName("DWORD")]
    public uint e32_debuginfo;

    [NativeTypeName("DWORD")]
    public uint e32_debuglen;

    [NativeTypeName("DWORD")]
    public uint e32_instpreload;

    [NativeTypeName("DWORD")]
    public uint e32_instdemand;

    [NativeTypeName("DWORD")]
    public uint e32_heapsize;

    [NativeTypeName("BYTE[12]")]
    public _e32_res3_e__FixedBuffer e32_res3;

    [NativeTypeName("DWORD")]
    public uint e32_winresoff;

    [NativeTypeName("DWORD")]
    public uint e32_winreslen;

    [NativeTypeName("WORD")]
    public ushort e32_devid;

    [NativeTypeName("WORD")]
    public ushort e32_ddkver;

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    [InlineArray(12)]
    public partial struct _e32_res3_e__FixedBuffer
    {
        public byte e0;
    }
}
