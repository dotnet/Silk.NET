// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DXGI_MODE_SCANLINE_ORDER.xml' path='doc/member[@name="DXGI_MODE_SCANLINE_ORDER"]/*'/>
public enum DXGI_MODE_SCANLINE_ORDER
{
    /// <include file='DXGI_MODE_SCANLINE_ORDER.xml' path='doc/member[@name="DXGI_MODE_SCANLINE_ORDER.DXGI_MODE_SCANLINE_ORDER_UNSPECIFIED"]/*'/>
    DXGI_MODE_SCANLINE_ORDER_UNSPECIFIED = 0,
    /// <include file='DXGI_MODE_SCANLINE_ORDER.xml' path='doc/member[@name="DXGI_MODE_SCANLINE_ORDER.DXGI_MODE_SCANLINE_ORDER_PROGRESSIVE"]/*'/>
    DXGI_MODE_SCANLINE_ORDER_PROGRESSIVE = 1,
    /// <include file='DXGI_MODE_SCANLINE_ORDER.xml' path='doc/member[@name="DXGI_MODE_SCANLINE_ORDER.DXGI_MODE_SCANLINE_ORDER_UPPER_FIELD_FIRST"]/*'/>
    DXGI_MODE_SCANLINE_ORDER_UPPER_FIELD_FIRST = 2,
    /// <include file='DXGI_MODE_SCANLINE_ORDER.xml' path='doc/member[@name="DXGI_MODE_SCANLINE_ORDER.DXGI_MODE_SCANLINE_ORDER_LOWER_FIELD_FIRST"]/*'/>
    DXGI_MODE_SCANLINE_ORDER_LOWER_FIELD_FIRST = 3,
}