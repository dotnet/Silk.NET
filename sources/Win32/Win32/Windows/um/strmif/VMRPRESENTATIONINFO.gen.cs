// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct VMRPRESENTATIONINFO
{
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("LPDIRECTDRAWSURFACE7")]
    public IDirectDrawSurface7 lpSurf;

    [NativeTypeName("REFERENCE_TIME")]
    public long rtStart;

    [NativeTypeName("REFERENCE_TIME")]
    public long rtEnd;
    public SIZE szAspectRatio;
    public RECT rcSrc;
    public RECT rcDst;

    [NativeTypeName("DWORD")]
    public uint dwTypeSpecificFlags;

    [NativeTypeName("DWORD")]
    public uint dwInterlaceFlags;
}
