// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct MDICREATESTRUCTA
{
    [NativeTypeName("LPCSTR")]
    public sbyte* szClass;

    [NativeTypeName("LPCSTR")]
    public sbyte* szTitle;
    public HANDLE hOwner;
    public int x;
    public int y;
    public int cx;
    public int cy;

    [NativeTypeName("DWORD")]
    public uint style;
    public LPARAM lParam;
}
