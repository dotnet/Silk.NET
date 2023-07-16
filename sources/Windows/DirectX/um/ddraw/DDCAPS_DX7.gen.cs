// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7"]/*'/>
public unsafe partial struct DDCAPS_DX7
{
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCaps;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwCaps2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCaps2;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwCKeyCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCKeyCaps;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwFXCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFXCaps;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwFXAlphaCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFXAlphaCaps;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwPalCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPalCaps;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwSVCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSVCaps;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwAlphaBltConstBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaBltConstBitDepths;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwAlphaBltPixelBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaBltPixelBitDepths;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwAlphaBltSurfaceBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaBltSurfaceBitDepths;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwAlphaOverlayConstBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaOverlayConstBitDepths;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwAlphaOverlayPixelBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaOverlayPixelBitDepths;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwAlphaOverlaySurfaceBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaOverlaySurfaceBitDepths;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwZBufferBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwZBufferBitDepths;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwVidMemTotal"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVidMemTotal;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwVidMemFree"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVidMemFree;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwMaxVisibleOverlays"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaxVisibleOverlays;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwCurrVisibleOverlays"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCurrVisibleOverlays;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwNumFourCCCodes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumFourCCCodes;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwAlignBoundarySrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlignBoundarySrc;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwAlignSizeSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlignSizeSrc;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwAlignBoundaryDest"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlignBoundaryDest;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwAlignSizeDest"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlignSizeDest;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwAlignStrideAlign"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlignStrideAlign;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwRops"]/*'/>
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwRops[8];
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.ddsOldCaps"]/*'/>
    public DDSCAPS ddsOldCaps;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwMinOverlayStretch"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMinOverlayStretch;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwMaxOverlayStretch"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaxOverlayStretch;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwMinLiveVideoStretch"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMinLiveVideoStretch;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwMaxLiveVideoStretch"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaxLiveVideoStretch;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwMinHwCodecStretch"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMinHwCodecStretch;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwMaxHwCodecStretch"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaxHwCodecStretch;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwReserved1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved1;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwReserved2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved2;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwReserved3"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved3;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwSVBCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSVBCaps;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwSVBCKeyCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSVBCKeyCaps;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwSVBFXCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSVBFXCaps;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwSVBRops"]/*'/>
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwSVBRops[8];
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwVSBCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVSBCaps;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwVSBCKeyCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVSBCKeyCaps;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwVSBFXCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVSBFXCaps;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwVSBRops"]/*'/>
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwVSBRops[8];
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwSSBCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSSBCaps;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwSSBCKeyCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSSBCKeyCaps;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwSSBFXCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSSBFXCaps;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwSSBRops"]/*'/>
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwSSBRops[8];
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwMaxVideoPorts"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaxVideoPorts;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwCurrVideoPorts"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCurrVideoPorts;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwSVBCaps2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSVBCaps2;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwNLVBCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNLVBCaps;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwNLVBCaps2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNLVBCaps2;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwNLVBCKeyCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNLVBCKeyCaps;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwNLVBFXCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNLVBFXCaps;
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.dwNLVBRops"]/*'/>
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwNLVBRops[8];
    /// <include file='DDCAPS_DX7.xml' path='doc/member[@name="DDCAPS_DX7.ddsCaps"]/*'/>
    public DDSCAPS2 ddsCaps;
}