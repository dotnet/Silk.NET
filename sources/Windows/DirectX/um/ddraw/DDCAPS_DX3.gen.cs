// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3"]/*' />
public unsafe partial struct DDCAPS_DX3
{
    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCaps;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwCaps2"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCaps2;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwCKeyCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCKeyCaps;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwFXCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFXCaps;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwFXAlphaCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFXAlphaCaps;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwPalCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPalCaps;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwSVCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSVCaps;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwAlphaBltConstBitDepths"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlphaBltConstBitDepths;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwAlphaBltPixelBitDepths"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlphaBltPixelBitDepths;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwAlphaBltSurfaceBitDepths"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlphaBltSurfaceBitDepths;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwAlphaOverlayConstBitDepths"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlphaOverlayConstBitDepths;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwAlphaOverlayPixelBitDepths"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlphaOverlayPixelBitDepths;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwAlphaOverlaySurfaceBitDepths"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlphaOverlaySurfaceBitDepths;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwZBufferBitDepths"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwZBufferBitDepths;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwVidMemTotal"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVidMemTotal;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwVidMemFree"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVidMemFree;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwMaxVisibleOverlays"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMaxVisibleOverlays;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwCurrVisibleOverlays"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCurrVisibleOverlays;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwNumFourCCCodes"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNumFourCCCodes;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwAlignBoundarySrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlignBoundarySrc;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwAlignSizeSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlignSizeSrc;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwAlignBoundaryDest"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlignBoundaryDest;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwAlignSizeDest"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlignSizeDest;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwAlignStrideAlign"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlignStrideAlign;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwRops"]/*' />
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwRops[8];

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.ddsCaps"]/*' />
    public DDSCAPS ddsCaps;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwMinOverlayStretch"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMinOverlayStretch;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwMaxOverlayStretch"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMaxOverlayStretch;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwMinLiveVideoStretch"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMinLiveVideoStretch;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwMaxLiveVideoStretch"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMaxLiveVideoStretch;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwMinHwCodecStretch"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMinHwCodecStretch;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwMaxHwCodecStretch"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMaxHwCodecStretch;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwReserved1"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved1;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwReserved2"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved2;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwReserved3"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved3;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwSVBCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSVBCaps;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwSVBCKeyCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSVBCKeyCaps;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwSVBFXCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSVBFXCaps;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwSVBRops"]/*' />
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwSVBRops[8];

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwVSBCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVSBCaps;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwVSBCKeyCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVSBCKeyCaps;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwVSBFXCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVSBFXCaps;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwVSBRops"]/*' />
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwVSBRops[8];

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwSSBCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSSBCaps;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwSSBCKeyCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSSBCKeyCaps;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwSSBFXCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSSBFXCaps;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwSSBRops"]/*' />
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwSSBRops[8];

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwReserved4"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved4;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwReserved5"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved5;

    /// <include file='DDCAPS_DX3.xml' path='doc/member[@name="DDCAPS_DX3.dwReserved6"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved6;
}
