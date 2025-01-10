// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SMDATA
{
    [NativeTypeName("DWORD")]
    public uint dwMask;

    [NativeTypeName("DWORD")]
    public uint dwFlags;
    public HMENU hmenu;
    public HWND hwnd;
    public uint uId;
    public uint uIdParent;
    public uint uIdAncestor;
    public IUnknown punk;

    [NativeTypeName("LPITEMIDLIST")]
    public ITEMIDLIST* pidlFolder;

    [NativeTypeName("LPITEMIDLIST")]
    public ITEMIDLIST* pidlItem;
    public IShellFolder psf;
    public void* pvUserData;
}
