// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct TTTOOLINFOA
{
    public uint cbSize;
    public uint uFlags;
    public HWND hwnd;

    [NativeTypeName("UINT_PTR")]
    public nuint uId;
    public RECT rect;
    public HINSTANCE hinst;

    [NativeTypeName("LPSTR")]
    public sbyte* lpszText;
    public LPARAM lParam;
    public void* lpReserved;
}
