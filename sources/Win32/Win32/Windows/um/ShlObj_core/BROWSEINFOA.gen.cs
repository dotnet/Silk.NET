// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct BROWSEINFOA
{
    public HWND hwndOwner;

    [NativeTypeName("LPCITEMIDLIST")]
    public ITEMIDLIST* pidlRoot;

    [NativeTypeName("LPSTR")]
    public sbyte* pszDisplayName;

    [NativeTypeName("LPCSTR")]
    public sbyte* lpszTitle;
    public uint ulFlags;

    [NativeTypeName("BFFCALLBACK")]
    public delegate* unmanaged<HWND, uint, LPARAM, LPARAM, int> lpfn;
    public LPARAM lParam;
    public int iImage;
}
