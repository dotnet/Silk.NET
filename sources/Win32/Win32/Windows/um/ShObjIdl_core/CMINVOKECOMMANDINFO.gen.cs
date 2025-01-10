// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CMINVOKECOMMANDINFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint fMask;
    public HWND hwnd;

    [NativeTypeName("LPCSTR")]
    public sbyte* lpVerb;

    [NativeTypeName("LPCSTR")]
    public sbyte* lpParameters;

    [NativeTypeName("LPCSTR")]
    public sbyte* lpDirectory;
    public int nShow;

    [NativeTypeName("DWORD")]
    public uint dwHotKey;
    public HANDLE hIcon;
}
