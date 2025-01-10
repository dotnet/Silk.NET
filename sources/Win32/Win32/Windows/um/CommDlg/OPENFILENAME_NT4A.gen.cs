// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct OPENFILENAME_NT4A
{
    [NativeTypeName("DWORD")]
    public uint lStructSize;
    public HWND hwndOwner;
    public HINSTANCE hInstance;

    [NativeTypeName("LPCSTR")]
    public sbyte* lpstrFilter;

    [NativeTypeName("LPSTR")]
    public sbyte* lpstrCustomFilter;

    [NativeTypeName("DWORD")]
    public uint nMaxCustFilter;

    [NativeTypeName("DWORD")]
    public uint nFilterIndex;

    [NativeTypeName("LPSTR")]
    public sbyte* lpstrFile;

    [NativeTypeName("DWORD")]
    public uint nMaxFile;

    [NativeTypeName("LPSTR")]
    public sbyte* lpstrFileTitle;

    [NativeTypeName("DWORD")]
    public uint nMaxFileTitle;

    [NativeTypeName("LPCSTR")]
    public sbyte* lpstrInitialDir;

    [NativeTypeName("LPCSTR")]
    public sbyte* lpstrTitle;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("WORD")]
    public ushort nFileOffset;

    [NativeTypeName("WORD")]
    public ushort nFileExtension;

    [NativeTypeName("LPCSTR")]
    public sbyte* lpstrDefExt;
    public LPARAM lCustData;

    [NativeTypeName("LPOFNHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnHook;

    [NativeTypeName("LPCSTR")]
    public sbyte* lpTemplateName;
}
