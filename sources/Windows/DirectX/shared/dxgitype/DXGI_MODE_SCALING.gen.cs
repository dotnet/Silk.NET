// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DXGI_MODE_SCALING.xml' path='doc/member[@name="DXGI_MODE_SCALING"]/*'/>
public enum DXGI_MODE_SCALING
{
    /// <include file='DXGI_MODE_SCALING.xml' path='doc/member[@name="DXGI_MODE_SCALING.DXGI_MODE_SCALING_UNSPECIFIED"]/*'/>
    DXGI_MODE_SCALING_UNSPECIFIED = 0,
    /// <include file='DXGI_MODE_SCALING.xml' path='doc/member[@name="DXGI_MODE_SCALING.DXGI_MODE_SCALING_CENTERED"]/*'/>
    DXGI_MODE_SCALING_CENTERED = 1,
    /// <include file='DXGI_MODE_SCALING.xml' path='doc/member[@name="DXGI_MODE_SCALING.DXGI_MODE_SCALING_STRETCHED"]/*'/>
    DXGI_MODE_SCALING_STRETCHED = 2,
}