// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct AUTO_SCROLL_DATA
{
    public int iNextSample;

    [NativeTypeName("DWORD")]
    public uint dwLastScroll;
    public BOOL bFull;

    [NativeTypeName("POINT[3]")]
    public _pts_e__FixedBuffer pts;

    [NativeTypeName("DWORD[3]")]
    public _dwTimes_e__FixedBuffer dwTimes;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(3)]
    public partial struct _pts_e__FixedBuffer
    {
        public POINT e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(3)]
    public partial struct _dwTimes_e__FixedBuffer
    {
        public uint e0;
    }
}
