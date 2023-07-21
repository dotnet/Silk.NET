// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6"]/*' />
public unsafe partial struct DDCAPS_DX6
{
    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCaps;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwCaps2"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCaps2;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwCKeyCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCKeyCaps;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwFXCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFXCaps;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwFXAlphaCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFXAlphaCaps;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwPalCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPalCaps;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwSVCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSVCaps;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwAlphaBltConstBitDepths"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlphaBltConstBitDepths;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwAlphaBltPixelBitDepths"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlphaBltPixelBitDepths;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwAlphaBltSurfaceBitDepths"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlphaBltSurfaceBitDepths;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwAlphaOverlayConstBitDepths"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlphaOverlayConstBitDepths;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwAlphaOverlayPixelBitDepths"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlphaOverlayPixelBitDepths;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwAlphaOverlaySurfaceBitDepths"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlphaOverlaySurfaceBitDepths;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwZBufferBitDepths"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwZBufferBitDepths;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwVidMemTotal"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVidMemTotal;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwVidMemFree"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVidMemFree;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwMaxVisibleOverlays"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMaxVisibleOverlays;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwCurrVisibleOverlays"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCurrVisibleOverlays;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwNumFourCCCodes"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNumFourCCCodes;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwAlignBoundarySrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlignBoundarySrc;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwAlignSizeSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlignSizeSrc;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwAlignBoundaryDest"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlignBoundaryDest;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwAlignSizeDest"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlignSizeDest;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwAlignStrideAlign"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlignStrideAlign;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwRops"]/*' />
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwRops[8];

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.ddsOldCaps"]/*' />
    public DDSCAPS ddsOldCaps;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwMinOverlayStretch"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMinOverlayStretch;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwMaxOverlayStretch"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMaxOverlayStretch;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwMinLiveVideoStretch"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMinLiveVideoStretch;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwMaxLiveVideoStretch"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMaxLiveVideoStretch;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwMinHwCodecStretch"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMinHwCodecStretch;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwMaxHwCodecStretch"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMaxHwCodecStretch;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwReserved1"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved1;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwReserved2"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved2;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwReserved3"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved3;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwSVBCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSVBCaps;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwSVBCKeyCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSVBCKeyCaps;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwSVBFXCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSVBFXCaps;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwSVBRops"]/*' />
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwSVBRops[8];

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwVSBCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVSBCaps;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwVSBCKeyCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVSBCKeyCaps;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwVSBFXCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVSBFXCaps;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwVSBRops"]/*' />
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwVSBRops[8];

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwSSBCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSSBCaps;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwSSBCKeyCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSSBCKeyCaps;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwSSBFXCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSSBFXCaps;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwSSBRops"]/*' />
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwSSBRops[8];

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwMaxVideoPorts"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMaxVideoPorts;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwCurrVideoPorts"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCurrVideoPorts;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwSVBCaps2"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSVBCaps2;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwNLVBCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNLVBCaps;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwNLVBCaps2"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNLVBCaps2;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwNLVBCKeyCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNLVBCKeyCaps;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwNLVBFXCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNLVBFXCaps;

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.dwNLVBRops"]/*' />
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwNLVBRops[8];

    /// <include file='DDCAPS_DX6.xml' path='doc/member[@name="DDCAPS_DX6.ddsCaps"]/*' />
    public DDSCAPS2 ddsCaps;
}
