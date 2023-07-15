// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DXGI_FRAME_PRESENTATION_MODE.xml' path='doc/member[@name="DXGI_FRAME_PRESENTATION_MODE"]/*'/>
public enum DXGI_FRAME_PRESENTATION_MODE
{
    /// <include file='DXGI_FRAME_PRESENTATION_MODE.xml' path='doc/member[@name="DXGI_FRAME_PRESENTATION_MODE.DXGI_FRAME_PRESENTATION_MODE_COMPOSED"]/*'/>
    DXGI_FRAME_PRESENTATION_MODE_COMPOSED = 0,
    /// <include file='DXGI_FRAME_PRESENTATION_MODE.xml' path='doc/member[@name="DXGI_FRAME_PRESENTATION_MODE.DXGI_FRAME_PRESENTATION_MODE_OVERLAY"]/*'/>
    DXGI_FRAME_PRESENTATION_MODE_OVERLAY = 1,
    /// <include file='DXGI_FRAME_PRESENTATION_MODE.xml' path='doc/member[@name="DXGI_FRAME_PRESENTATION_MODE.DXGI_FRAME_PRESENTATION_MODE_NONE"]/*'/>
    DXGI_FRAME_PRESENTATION_MODE_NONE = 2,
    /// <include file='DXGI_FRAME_PRESENTATION_MODE.xml' path='doc/member[@name="DXGI_FRAME_PRESENTATION_MODE.DXGI_FRAME_PRESENTATION_MODE_COMPOSITION_FAILURE"]/*'/>
    DXGI_FRAME_PRESENTATION_MODE_COMPOSITION_FAILURE = 3,
}