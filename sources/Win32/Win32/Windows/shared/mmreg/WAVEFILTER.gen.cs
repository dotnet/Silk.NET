// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WAVEFILTER
{
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    [NativeTypeName("DWORD")]
    public uint dwFilterTag;

    [NativeTypeName("DWORD")]
    public uint fdwFilter;

    [NativeTypeName("DWORD[5]")]
    public _dwReserved_e__FixedBuffer dwReserved;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(5)]
    public partial struct _dwReserved_e__FixedBuffer
    {
        public uint e0;
    }
}
