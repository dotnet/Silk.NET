// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Cpl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct NEWCPLINFOW
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint dwHelpContext;

    [NativeTypeName("LONG_PTR")]
    public nint lData;
    public HICON hIcon;

    [NativeTypeName("WCHAR[32]")]
    public _szName_e__FixedBuffer szName;

    [NativeTypeName("WCHAR[64]")]
    public _szInfo_e__FixedBuffer szInfo;

    [NativeTypeName("WCHAR[128]")]
    public _szHelpFile_e__FixedBuffer szHelpFile;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    public partial struct _szName_e__FixedBuffer
    {
        public ushort e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(64)]
    public partial struct _szInfo_e__FixedBuffer
    {
        public ushort e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(128)]
    public partial struct _szHelpFile_e__FixedBuffer
    {
        public ushort e0;
    }
}
