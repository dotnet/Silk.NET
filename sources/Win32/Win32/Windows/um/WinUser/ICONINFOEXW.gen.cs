// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct ICONINFOEXW
{
    [NativeTypeName("DWORD")]
    public uint cbSize;
    public BOOL fIcon;

    [NativeTypeName("DWORD")]
    public uint xHotspot;

    [NativeTypeName("DWORD")]
    public uint yHotspot;
    public HBITMAP hbmMask;
    public HBITMAP hbmColor;

    [NativeTypeName("WORD")]
    public ushort wResID;

    [NativeTypeName("WCHAR[260]")]
    public _szModName_e__FixedBuffer szModName;

    [NativeTypeName("WCHAR[260]")]
    public _szResName_e__FixedBuffer szResName;

    [InlineArray(260)]
    public partial struct _szModName_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(260)]
    public partial struct _szResName_e__FixedBuffer
    {
        public ushort e0;
    }
}
