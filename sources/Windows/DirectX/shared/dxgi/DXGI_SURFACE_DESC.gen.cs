// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DXGI_SURFACE_DESC.xml' path='doc/member[@name="DXGI_SURFACE_DESC"]/*'/>
public partial struct DXGI_SURFACE_DESC
{
    /// <include file='DXGI_SURFACE_DESC.xml' path='doc/member[@name="DXGI_SURFACE_DESC.Width"]/*'/>
    public uint Width;
    /// <include file='DXGI_SURFACE_DESC.xml' path='doc/member[@name="DXGI_SURFACE_DESC.Height"]/*'/>
    public uint Height;
    /// <include file='DXGI_SURFACE_DESC.xml' path='doc/member[@name="DXGI_SURFACE_DESC.Format"]/*'/>
    public DXGI_FORMAT Format;
    /// <include file='DXGI_SURFACE_DESC.xml' path='doc/member[@name="DXGI_SURFACE_DESC.SampleDesc"]/*'/>
    public DXGI_SAMPLE_DESC SampleDesc;
}