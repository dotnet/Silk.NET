// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='DDBLTBATCH.xml' path='doc/member[@name="DDBLTBATCH"]/*' />
public unsafe partial struct DDBLTBATCH
{
    /// <include file='DDBLTBATCH.xml' path='doc/member[@name="DDBLTBATCH.lprDest"]/*' />
    [NativeTypeName("LPRECT")]
    public RECT* lprDest;

    /// <include file='DDBLTBATCH.xml' path='doc/member[@name="DDBLTBATCH.lpDDSSrc"]/*' />
    [NativeTypeName("LPDIRECTDRAWSURFACE")]
    public IDirectDrawSurface* lpDDSSrc;

    /// <include file='DDBLTBATCH.xml' path='doc/member[@name="DDBLTBATCH.lprSrc"]/*' />
    [NativeTypeName("LPRECT")]
    public RECT* lprSrc;

    /// <include file='DDBLTBATCH.xml' path='doc/member[@name="DDBLTBATCH.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='DDBLTBATCH.xml' path='doc/member[@name="DDBLTBATCH.lpDDBltFx"]/*' />
    [NativeTypeName("LPDDBLTFX")]
    public DDBLTFX* lpDDBltFx;
}
