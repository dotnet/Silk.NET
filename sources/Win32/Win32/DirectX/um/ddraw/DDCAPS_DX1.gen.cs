// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DDCAPS_DX1
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwCaps;

    [NativeTypeName("DWORD")]
    public uint dwCaps2;

    [NativeTypeName("DWORD")]
    public uint dwCKeyCaps;

    [NativeTypeName("DWORD")]
    public uint dwFXCaps;

    [NativeTypeName("DWORD")]
    public uint dwFXAlphaCaps;

    [NativeTypeName("DWORD")]
    public uint dwPalCaps;

    [NativeTypeName("DWORD")]
    public uint dwSVCaps;

    [NativeTypeName("DWORD")]
    public uint dwAlphaBltConstBitDepths;

    [NativeTypeName("DWORD")]
    public uint dwAlphaBltPixelBitDepths;

    [NativeTypeName("DWORD")]
    public uint dwAlphaBltSurfaceBitDepths;

    [NativeTypeName("DWORD")]
    public uint dwAlphaOverlayConstBitDepths;

    [NativeTypeName("DWORD")]
    public uint dwAlphaOverlayPixelBitDepths;

    [NativeTypeName("DWORD")]
    public uint dwAlphaOverlaySurfaceBitDepths;

    [NativeTypeName("DWORD")]
    public uint dwZBufferBitDepths;

    [NativeTypeName("DWORD")]
    public uint dwVidMemTotal;

    [NativeTypeName("DWORD")]
    public uint dwVidMemFree;

    [NativeTypeName("DWORD")]
    public uint dwMaxVisibleOverlays;

    [NativeTypeName("DWORD")]
    public uint dwCurrVisibleOverlays;

    [NativeTypeName("DWORD")]
    public uint dwNumFourCCCodes;

    [NativeTypeName("DWORD")]
    public uint dwAlignBoundarySrc;

    [NativeTypeName("DWORD")]
    public uint dwAlignSizeSrc;

    [NativeTypeName("DWORD")]
    public uint dwAlignBoundaryDest;

    [NativeTypeName("DWORD")]
    public uint dwAlignSizeDest;

    [NativeTypeName("DWORD")]
    public uint dwAlignStrideAlign;

    [NativeTypeName("DWORD[8]")]
    public _dwRops_e__FixedBuffer dwRops;
    public DDSCAPS ddsCaps;

    [NativeTypeName("DWORD")]
    public uint dwMinOverlayStretch;

    [NativeTypeName("DWORD")]
    public uint dwMaxOverlayStretch;

    [NativeTypeName("DWORD")]
    public uint dwMinLiveVideoStretch;

    [NativeTypeName("DWORD")]
    public uint dwMaxLiveVideoStretch;

    [NativeTypeName("DWORD")]
    public uint dwMinHwCodecStretch;

    [NativeTypeName("DWORD")]
    public uint dwMaxHwCodecStretch;

    [NativeTypeName("DWORD")]
    public uint dwReserved1;

    [NativeTypeName("DWORD")]
    public uint dwReserved2;

    [NativeTypeName("DWORD")]
    public uint dwReserved3;

    [InlineArray(8)]
    public partial struct _dwRops_e__FixedBuffer
    {
        public uint e0;
    }
}
