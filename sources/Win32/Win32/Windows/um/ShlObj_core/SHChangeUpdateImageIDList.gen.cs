// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHChangeUpdateImageIDList
{
    public ushort cb;
    public int iIconIndex;
    public int iCurIndex;
    public uint uFlags;

    [NativeTypeName("DWORD")]
    public uint dwProcessID;

    [NativeTypeName("WCHAR[260]")]
    public _szName_e__FixedBuffer szName;
    public ushort cbZero;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(260)]
    public partial struct _szName_e__FixedBuffer
    {
        public ushort e0;
    }
}
