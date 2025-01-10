// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/tlogstg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WINDOWDATA
{
    [NativeTypeName("DWORD")]
    public uint dwWindowID;
    public uint uiCP;

    [NativeTypeName("LPITEMIDLIST")]
    public ITEMIDLIST* pidl;

    [NativeTypeName("LPWSTR")]
    public ushort* lpszUrl;

    [NativeTypeName("LPWSTR")]
    public ushort* lpszUrlLocation;

    [NativeTypeName("LPWSTR")]
    public ushort* lpszTitle;
}
