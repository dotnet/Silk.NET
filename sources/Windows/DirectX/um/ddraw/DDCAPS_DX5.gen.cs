// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5"]/*'/>
public unsafe partial struct DDCAPS_DX5
{
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCaps;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwCaps2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCaps2;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwCKeyCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCKeyCaps;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwFXCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFXCaps;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwFXAlphaCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFXAlphaCaps;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwPalCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPalCaps;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwSVCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSVCaps;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwAlphaBltConstBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaBltConstBitDepths;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwAlphaBltPixelBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaBltPixelBitDepths;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwAlphaBltSurfaceBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaBltSurfaceBitDepths;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwAlphaOverlayConstBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaOverlayConstBitDepths;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwAlphaOverlayPixelBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaOverlayPixelBitDepths;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwAlphaOverlaySurfaceBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaOverlaySurfaceBitDepths;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwZBufferBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwZBufferBitDepths;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwVidMemTotal"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVidMemTotal;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwVidMemFree"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVidMemFree;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwMaxVisibleOverlays"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaxVisibleOverlays;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwCurrVisibleOverlays"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCurrVisibleOverlays;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwNumFourCCCodes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumFourCCCodes;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwAlignBoundarySrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlignBoundarySrc;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwAlignSizeSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlignSizeSrc;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwAlignBoundaryDest"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlignBoundaryDest;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwAlignSizeDest"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlignSizeDest;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwAlignStrideAlign"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlignStrideAlign;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwRops"]/*'/>
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwRops[8];
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.ddsCaps"]/*'/>
    public DDSCAPS ddsCaps;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwMinOverlayStretch"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMinOverlayStretch;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwMaxOverlayStretch"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaxOverlayStretch;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwMinLiveVideoStretch"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMinLiveVideoStretch;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwMaxLiveVideoStretch"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaxLiveVideoStretch;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwMinHwCodecStretch"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMinHwCodecStretch;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwMaxHwCodecStretch"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaxHwCodecStretch;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwReserved1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved1;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwReserved2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved2;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwReserved3"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved3;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwSVBCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSVBCaps;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwSVBCKeyCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSVBCKeyCaps;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwSVBFXCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSVBFXCaps;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwSVBRops"]/*'/>
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwSVBRops[8];
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwVSBCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVSBCaps;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwVSBCKeyCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVSBCKeyCaps;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwVSBFXCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVSBFXCaps;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwVSBRops"]/*'/>
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwVSBRops[8];
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwSSBCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSSBCaps;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwSSBCKeyCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSSBCKeyCaps;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwSSBFXCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSSBFXCaps;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwSSBRops"]/*'/>
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwSSBRops[8];
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwMaxVideoPorts"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaxVideoPorts;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwCurrVideoPorts"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCurrVideoPorts;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwSVBCaps2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSVBCaps2;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwNLVBCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNLVBCaps;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwNLVBCaps2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNLVBCaps2;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwNLVBCKeyCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNLVBCKeyCaps;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwNLVBFXCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNLVBFXCaps;
    /// <include file='DDCAPS_DX5.xml' path='doc/member[@name="DDCAPS_DX5.dwNLVBRops"]/*'/>
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwNLVBRops[8];
}