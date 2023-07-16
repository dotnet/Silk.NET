// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
/// <include file='DXGI_MODE_DESC1.xml' path='doc/member[@name="DXGI_MODE_DESC1"]/*'/>
public partial struct DXGI_MODE_DESC1
{
    /// <include file='DXGI_MODE_DESC1.xml' path='doc/member[@name="DXGI_MODE_DESC1.Width"]/*'/>
    public uint Width;
    /// <include file='DXGI_MODE_DESC1.xml' path='doc/member[@name="DXGI_MODE_DESC1.Height"]/*'/>
    public uint Height;
    /// <include file='DXGI_MODE_DESC1.xml' path='doc/member[@name="DXGI_MODE_DESC1.RefreshRate"]/*'/>
    public DXGI_RATIONAL RefreshRate;
    /// <include file='DXGI_MODE_DESC1.xml' path='doc/member[@name="DXGI_MODE_DESC1.Format"]/*'/>
    public DXGI_FORMAT Format;
    /// <include file='DXGI_MODE_DESC1.xml' path='doc/member[@name="DXGI_MODE_DESC1.ScanlineOrdering"]/*'/>
    public DXGI_MODE_SCANLINE_ORDER ScanlineOrdering;
    /// <include file='DXGI_MODE_DESC1.xml' path='doc/member[@name="DXGI_MODE_DESC1.Scaling"]/*'/>
    public DXGI_MODE_SCALING Scaling;
    /// <include file='DXGI_MODE_DESC1.xml' path='doc/member[@name="DXGI_MODE_DESC1.Stereo"]/*'/>
    public BOOL Stereo;
}