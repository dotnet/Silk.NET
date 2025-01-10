// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct VMRALPHABITMAP
{
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    public HDC hdc;

    [NativeTypeName("LPDIRECTDRAWSURFACE7")]
    public IDirectDrawSurface7 pDDS;
    public RECT rSrc;
    public NORMALIZEDRECT rDest;
    public float fAlpha;
    public COLORREF clrSrcKey;
}
