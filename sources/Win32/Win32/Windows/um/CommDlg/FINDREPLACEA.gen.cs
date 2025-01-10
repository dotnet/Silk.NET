// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct FINDREPLACEA
{
    [NativeTypeName("DWORD")]
    public uint lStructSize;
    public HWND hwndOwner;
    public HINSTANCE hInstance;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("LPSTR")]
    public sbyte* lpstrFindWhat;

    [NativeTypeName("LPSTR")]
    public sbyte* lpstrReplaceWith;

    [NativeTypeName("WORD")]
    public ushort wFindWhatLen;

    [NativeTypeName("WORD")]
    public ushort wReplaceWithLen;
    public LPARAM lCustData;

    [NativeTypeName("LPFRHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnHook;

    [NativeTypeName("LPCSTR")]
    public sbyte* lpTemplateName;
}
