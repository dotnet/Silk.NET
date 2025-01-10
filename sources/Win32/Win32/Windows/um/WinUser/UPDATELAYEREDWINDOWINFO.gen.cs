// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct UPDATELAYEREDWINDOWINFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;
    public HDC hdcDst;

    [NativeTypeName("const POINT *")]
    public POINT* pptDst;

    [NativeTypeName("const SIZE *")]
    public SIZE* psize;
    public HDC hdcSrc;

    [NativeTypeName("const POINT *")]
    public POINT* pptSrc;
    public COLORREF crKey;

    [NativeTypeName("const BLENDFUNCTION *")]
    public BLENDFUNCTION* pblend;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("const RECT *")]
    public RECT* prcDirty;
}
