// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CHOOSECOLORA
{
    [NativeTypeName("DWORD")]
    public uint lStructSize;
    public HWND hwndOwner;
    public HWND hInstance;
    public COLORREF rgbResult;
    public COLORREF* lpCustColors;

    [NativeTypeName("DWORD")]
    public uint Flags;
    public LPARAM lCustData;

    [NativeTypeName("LPCCHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnHook;

    [NativeTypeName("LPCSTR")]
    public sbyte* lpTemplateName;
}
