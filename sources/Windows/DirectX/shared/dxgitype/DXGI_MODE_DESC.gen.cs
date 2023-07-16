// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DXGI_MODE_DESC.xml' path='doc/member[@name="DXGI_MODE_DESC"]/*'/>
public partial struct DXGI_MODE_DESC
{
    /// <include file='DXGI_MODE_DESC.xml' path='doc/member[@name="DXGI_MODE_DESC.Width"]/*'/>
    public uint Width;
    /// <include file='DXGI_MODE_DESC.xml' path='doc/member[@name="DXGI_MODE_DESC.Height"]/*'/>
    public uint Height;
    /// <include file='DXGI_MODE_DESC.xml' path='doc/member[@name="DXGI_MODE_DESC.RefreshRate"]/*'/>
    public DXGI_RATIONAL RefreshRate;
    /// <include file='DXGI_MODE_DESC.xml' path='doc/member[@name="DXGI_MODE_DESC.Format"]/*'/>
    public DXGI_FORMAT Format;
    /// <include file='DXGI_MODE_DESC.xml' path='doc/member[@name="DXGI_MODE_DESC.ScanlineOrdering"]/*'/>
    public DXGI_MODE_SCANLINE_ORDER ScanlineOrdering;
    /// <include file='DXGI_MODE_DESC.xml' path='doc/member[@name="DXGI_MODE_DESC.Scaling"]/*'/>
    public DXGI_MODE_SCALING Scaling;
}