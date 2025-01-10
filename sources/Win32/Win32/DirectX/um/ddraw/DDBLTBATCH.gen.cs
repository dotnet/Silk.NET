// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DDBLTBATCH
{
    [NativeTypeName("LPRECT")]
    public RECT* lprDest;

    [NativeTypeName("LPDIRECTDRAWSURFACE")]
    public IDirectDrawSurface lpDDSSrc;

    [NativeTypeName("LPRECT")]
    public RECT* lprSrc;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("LPDDBLTFX")]
    public DDBLTFX* lpDDBltFx;
}
