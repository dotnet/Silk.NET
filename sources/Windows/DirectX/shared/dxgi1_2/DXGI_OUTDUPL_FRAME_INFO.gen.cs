// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
/// <include file='DXGI_OUTDUPL_FRAME_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO"]/*'/>
public partial struct DXGI_OUTDUPL_FRAME_INFO
{
    /// <include file='DXGI_OUTDUPL_FRAME_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO.LastPresentTime"]/*'/>
    public LARGE_INTEGER LastPresentTime;
    /// <include file='DXGI_OUTDUPL_FRAME_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO.LastMouseUpdateTime"]/*'/>
    public LARGE_INTEGER LastMouseUpdateTime;
    /// <include file='DXGI_OUTDUPL_FRAME_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO.AccumulatedFrames"]/*'/>
    public uint AccumulatedFrames;
    /// <include file='DXGI_OUTDUPL_FRAME_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO.RectsCoalesced"]/*'/>
    public BOOL RectsCoalesced;
    /// <include file='DXGI_OUTDUPL_FRAME_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO.ProtectedContentMaskedOut"]/*'/>
    public BOOL ProtectedContentMaskedOut;
    /// <include file='DXGI_OUTDUPL_FRAME_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO.PointerPosition"]/*'/>
    public DXGI_OUTDUPL_POINTER_POSITION PointerPosition;
    /// <include file='DXGI_OUTDUPL_FRAME_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO.TotalMetadataBufferSize"]/*'/>
    public uint TotalMetadataBufferSize;
    /// <include file='DXGI_OUTDUPL_FRAME_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO.PointerShapeBufferSize"]/*'/>
    public uint PointerShapeBufferSize;
}