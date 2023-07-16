// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1"]/*'/>
public unsafe partial struct DDCAPS_DX1
{
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCaps;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwCaps2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCaps2;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwCKeyCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCKeyCaps;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwFXCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFXCaps;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwFXAlphaCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFXAlphaCaps;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwPalCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPalCaps;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwSVCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSVCaps;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwAlphaBltConstBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaBltConstBitDepths;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwAlphaBltPixelBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaBltPixelBitDepths;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwAlphaBltSurfaceBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaBltSurfaceBitDepths;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwAlphaOverlayConstBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaOverlayConstBitDepths;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwAlphaOverlayPixelBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaOverlayPixelBitDepths;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwAlphaOverlaySurfaceBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaOverlaySurfaceBitDepths;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwZBufferBitDepths"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwZBufferBitDepths;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwVidMemTotal"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVidMemTotal;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwVidMemFree"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVidMemFree;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwMaxVisibleOverlays"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaxVisibleOverlays;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwCurrVisibleOverlays"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCurrVisibleOverlays;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwNumFourCCCodes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumFourCCCodes;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwAlignBoundarySrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlignBoundarySrc;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwAlignSizeSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlignSizeSrc;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwAlignBoundaryDest"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlignBoundaryDest;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwAlignSizeDest"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlignSizeDest;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwAlignStrideAlign"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlignStrideAlign;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwRops"]/*'/>
    [NativeTypeName("DWORD[8]")]
    public fixed uint dwRops[8];
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.ddsCaps"]/*'/>
    public DDSCAPS ddsCaps;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwMinOverlayStretch"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMinOverlayStretch;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwMaxOverlayStretch"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaxOverlayStretch;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwMinLiveVideoStretch"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMinLiveVideoStretch;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwMaxLiveVideoStretch"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaxLiveVideoStretch;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwMinHwCodecStretch"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMinHwCodecStretch;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwMaxHwCodecStretch"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaxHwCodecStretch;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwReserved1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved1;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwReserved2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved2;
    /// <include file='DDCAPS_DX1.xml' path='doc/member[@name="DDCAPS_DX1.dwReserved3"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved3;
}